using Entity.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace WebUserDemoApi.helpers
{
    public class GenerateJwtToken
    {
        public readonly IConfiguration _configuration;

        public GenerateJwtToken(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Tuple<string,string> Generate(Acccount acc)
        {

            List<Claim> claims = new()
                {
                new Claim("username", Convert.ToString(acc.userName)),
                new Claim(ClaimTypes.NameIdentifier, Convert.ToString(acc.accountId)),
                new Claim("role", Convert.ToString(acc.Decentralization.AuthorityName.ToUpper())),
                new Claim(ClaimTypes.Role, acc.Decentralization.AuthorityName.ToUpper())
                };
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
                var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
                var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(4),
                signingCredentials: cred
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            var RefreshToken =  GenerateRefreshToken();
            Tuple<string, string> tuple = new Tuple<string, string>(jwt, RefreshToken);
            return tuple;
        }
        private string GenerateRefreshToken()
        {
            var rsa = new RSACryptoServiceProvider(2048); // Giá trị 2048 là kích thước của khóa.
            var privateKey = rsa.ExportParameters(true); // Tạo khóa được bảo mật.
            var refreshToken = Convert.ToBase64String(privateKey.Modulus); // Tạo chuỗi chuẩn Base64.

            // Lưu privateKey vào cơ sở dữ liệu tại đây. privateKey sẽ dùng để giải mã RefreshToken sau này.

            return refreshToken;
        }
    }
}
