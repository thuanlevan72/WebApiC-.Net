using ApiApp.Controllers.Authentication.AuthenticationViewModels;
using ApiApp.Helpers;
using Entity.Models.ModelV2;
using Infrastructure.Repositories.InterfaceRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using BCryptNet = BCrypt.Net.BCrypt;

namespace ApiApp.Services.AuthServices
{
    public class AuthenticationService: IAuthenticationService
    {
        private readonly PasswordService _passwordService;
        private readonly IUnitOfWork _unitOfWork;
       
        public AuthenticationService(PasswordService passwordService, IUnitOfWork unitOfWork) {
            _passwordService = passwordService;
            _unitOfWork = unitOfWork;
        }

        public async Task<UserEntity> Login(LoginViewModel loginViewModel)
        {
            var user = await _unitOfWork.UserEntityRepository.FindAsync(x=>x.UserName.Contains(loginViewModel.UserName));
            if (user == null)
                return null;
            var IsColect = BCryptNet.Verify(loginViewModel.Password, user.HashPassword);
            if (user == null || !BCryptNet.Verify(loginViewModel.Password, user.HashPassword))
                return null;
            return user;
        }

        public async Task<UserEntity> Register(RegisterViewModel registerViewModel)
        {
            var user = new UserEntity()
            {
                CreateAt = DateTime.UtcNow,
                Email = registerViewModel.Email,
                HashPassword = BCryptNet.HashPassword(registerViewModel.Password),
                UserName = registerViewModel.UserName, 
                UpdateAt = null,
            };
            await _unitOfWork.UserEntityRepository.Add(user);
            var userRole = new List<UserRole>();
            userRole.Add(new UserRole()
            {
                RoleId = 2,
                UserId = user.UserEntityId
            });
            await _unitOfWork.UserRoleRepository.AddRange(userRole);
            return user;
        }
    }
}
