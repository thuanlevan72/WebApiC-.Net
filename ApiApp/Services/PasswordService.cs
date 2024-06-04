using Microsoft.AspNetCore.Identity;
using BCryptNet = BCrypt.Net.BCrypt;
namespace ApiApp.Services
{
    public class PasswordService
    {
        public string HashPassword(string password)
        {
            return BCryptNet.HashPassword(password);
        }

        public bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            return BCryptNet.Verify(providedPassword, providedPassword); ;
        }
    }
}
