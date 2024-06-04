using Entity.Models;
using Entity.Models.ModelV2;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace ApiApp.Helpers
{
    using ApiApp.OptionsPattern;
    using ApiApp.Services;
    using Commons.Constants;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Reflection;
    using System.Security.Claims;
    using System.Security.Cryptography;
    using System.Text;

    public class JwtTokenHelper
    {
        private readonly AppSettings _appSettings;
        private readonly AuthorizationService _authorizationService;

        public JwtTokenHelper(IOptions<AppSettings> appSettings, AuthorizationService authorizationService)
        {
            _appSettings = appSettings.Value;
            _authorizationService = authorizationService;
        }
        /// <summary>
        /// lấy danh sách các claim
        /// </summary>
        /// <param name="userRoles"></param>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        private List<Claim> GetClaim(ICollection<UserRole> userRoles,int userId,string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, userName),
                new Claim(JwtRegisteredClaimNames.Jti, userId.ToString())
            };
            List<string> roles = new List<string>();
            foreach (var item in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, item.Role.Name));
                // Lấy tất cả các thuộc tính của lớp PermissionContants
                var permissionConstantsType = typeof(Contants.PermissionContants);
                var fields = permissionConstantsType.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
              
                foreach (var field in fields)
                {
                    // Lấy giá trị của từng thuộc tính
                    var value = field.GetValue(null).ToString();
                    var hasPermission = _authorizationService.HasPermission(userId, value);
                    if (hasPermission)
                    {
                        roles.Add(value);
                       
                    }
                }
            }
            List<string> distinctActions = roles.Distinct().ToList();
            foreach(var action in distinctActions) {
                claims.Add(new Claim(ClaimTypes.Role, action));
            }

            return claims;

        } 
        /// <summary>
        /// Khởi tạo token
        /// </summary>
        /// <param name="acc"></param>
        /// <returns></returns>
        public Tuple<string, string> Generate(UserEntity acc)
        {
            var userRoles = acc.UserRoles;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.Token));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: GetClaim(userRoles, acc.UserEntityId,acc.UserName),
                expires: DateTime.Now.AddHours(4),
                signingCredentials: cred
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            var refreshToken = GenerateRefreshToken();
            Tuple<string, string> tuple = new Tuple<string, string>(jwt, refreshToken);
            return tuple;
        }
        /// <summary>
        /// khởi tạo refreshToken
        /// </summary>
        /// <returns></returns>
        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
        /// <summary>
        /// kiểm tra tính hợp pháp của token cũ
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="SecurityTokenException"></exception>
        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.Token)),
                ValidateLifetime = false // Chúng ta không kiểm tra thời gian hết hạn của token ở đây
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha512, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;
        }
        /// <summary>
        /// tạo token mới 
        /// </summary>
        /// <param name="expiredToken"></param>
        /// <returns></returns>
        public string GenerateNewTokenFromExpiredToken(string expiredToken)
        {
            var principal = GetPrincipalFromExpiredToken(expiredToken);
            var username = principal.Identity.Name;

            // Tạo token mới
            var newJwtToken = Generate(new UserEntity { UserName = username, UserRoles = new List<UserRole>() }); // Cập nhật UserEntity theo cách của bạn
            return newJwtToken.Item1;
        }
    }
    /// <summary>
    /// vứt cụ hàm này đi
    /// </summary>
    public class ClaimComparer : IEqualityComparer<Claim>
    {
        public bool Equals(Claim x, Claim y)
        {
            return x.Type == ClaimTypes.Role && y.Type == ClaimTypes.Role && x.Value == y.Value;
        }

        public int GetHashCode(Claim obj)
        {
            return obj.Type == ClaimTypes.Role ? obj.Value.GetHashCode() : obj.GetHashCode();
        }
    }
}
