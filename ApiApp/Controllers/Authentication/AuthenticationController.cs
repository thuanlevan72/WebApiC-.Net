using ApiApp.Controllers.Authentication.AuthenticationViewModels;
using ApiApp.Helpers;
using ApiApp.Services;
using ApiApp.Services.AuthServices;
using Entity.Models.ModelV2;
using Microsoft.AspNetCore.Mvc;
using SpireDoclibrary.Servicer;
using System.Collections.ObjectModel;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiApp.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly PasswordService _passwordService;
        private readonly JwtTokenHelper _jwtTokenHelper;
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(PasswordService passwordService, JwtTokenHelper jwtTokenHelper, IAuthenticationService authenticationService)
        {
            _passwordService  = passwordService;
            _jwtTokenHelper = jwtTokenHelper;
            _authenticationService = authenticationService;
        }
        // GET: api/<AuthenticationController>
        [HttpGet]
        public IActionResult Get()
        {
            SpireDocx document =  new SpireDocx();
            return File(document.GetDocument(), "application/pdf", "HeaderExample.pdf");
        }

        // GET api/<AuthenticationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuthenticationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel registerViewModel)
        {
            var user = await _authenticationService.Register(registerViewModel);
            return Ok(user);
        }

        // POST api/<AuthenticationController>
        [HttpPost("SignIn")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel loginViewModel)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var user = await _authenticationService.Login(loginViewModel);
            if (user == null)
                return BadRequest("có 1 lỗi được phát sinh nào đấy");
            var data = _jwtTokenHelper.Generate(user);
            stopwatch.Stop();
            var QueryTime = stopwatch.ElapsedMilliseconds;
            // So sánh kết quả
            Console.WriteLine($"Single Query Time: {QueryTime} ms");
            return Ok(data);
        }

        // PUT api/<AuthenticationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthenticationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
