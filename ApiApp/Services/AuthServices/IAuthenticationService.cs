using ApiApp.Controllers.Authentication.AuthenticationViewModels;
using Entity.Models.ModelV2;

namespace ApiApp.Services.AuthServices
{
    public interface IAuthenticationService
    {
        public Task<UserEntity> Login(LoginViewModel loginViewModel);

        public Task<UserEntity> Register(RegisterViewModel registerViewModel);
    }
}
