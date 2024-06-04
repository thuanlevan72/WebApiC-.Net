using System.ComponentModel.DataAnnotations;

namespace ApiApp.Controllers.Authentication.AuthenticationViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "User Name is required")]
        [StringLength(50, ErrorMessage = "User Name cannot be longer than 50 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "User Name cannot be longer than 50 characters")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; }
    }
}
