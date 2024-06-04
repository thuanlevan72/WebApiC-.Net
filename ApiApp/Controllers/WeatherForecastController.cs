using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Commons.Constants.Contants;

namespace ApiApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        [Authorize(Roles = "CREATE")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("Anonymous")]
        public IActionResult GetAnonymous()
        {
            return Ok("thành viên ẩn danh");
        }

        [HttpGet("RoleUser")]
        public IActionResult GetRoleUser()
        {
            return Ok("Thông tin người dùng");
        }
        [HttpGet("RoleManager")]
        [Authorize(Roles = RoleContants.ADMIN_MANAGER)]
        public IActionResult GetRoleManager()
        {
            return Ok("Thông tin manager");
        }
        [HttpGet("RoleAdmin")]
        [Authorize(Roles = RoleContants.ADMIN)]
        public IActionResult GetRoleAdmin()
        {
            return Ok("Thông tin Admin");
        }
    }
}
