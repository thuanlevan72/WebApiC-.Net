using System.ComponentModel.DataAnnotations;

namespace WebUserDemoApi.Controllers.UserControllers.UserViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User name is required")]
        [StringLength(50, ErrorMessage = "User name cannot be longer than 50 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; }
    }
}
