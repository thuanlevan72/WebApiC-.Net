using AutoMapper;
using AutoMapper.QueryableExtensions;
using Entity.Models;
using Infrastructure.Data;
using Infrastructure.Repositories.InterfaceRepository;
using MapperData.DtoMapperData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUserDemoApi.Controllers.UserControllers.UserViewModel;
using WebUserDemoApi.Filters;
using WebUserDemoApi.helpers;
using WebUserDemoApi.Services;


namespace WebUserDemoApi.Controllers.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServicer _userService;
        private readonly IUserRepository _userRepository;
        private readonly DbAppContext _context;
        private readonly AuthorizationService _authorizationService;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;



        public UserController(IUserServicer userService, DbAppContext context, IConfiguration configuration, IMapper mapper, IUserRepository userRepository, AuthorizationService authorizationService)
        {
            _userService = userService;
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
            _userRepository = userRepository;
            //_userRepository = userRepository;
            _authorizationService = authorizationService;
        }

        // GET: api/<UserController>
        [HttpGet]
        [Authorize(Roles = AuthorityPermissions.ADMIN, Policy = AuthorityPermissions.CURRENTUSER)]
        public async Task<IActionResult> Get()
        {
            var user = HttpContext.Items["User"] as Acccount;
            var acc = await _userService.GetAccount(1);
            if (acc == null)
            {
                return NotFound("Account not found");
            }
            var res = _userRepository.GetAcccounts().ProjectTo<AccountDto>(_mapper.ConfigurationProvider);
            return Ok(new { User = user, Accounts = res });
        }
        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            var query = _authorizationService.HasPermission(1, "CREATE");
            return Ok(query);
        }
        [HttpPost("SignIn")]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var token = await _userService.LoginAcc(loginViewModel);
            return Ok(new
            {
                AcessToken = token.Item1,
                RefreshToken = token.Item2,
                message = "đăng nhập thành công"
            });
        }

    }
}
