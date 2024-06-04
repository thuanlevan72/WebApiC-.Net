using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using WebUserDemoApi.helpers;
using WebUserDemoApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebUserDemoApi.Controllers
{
    [Route("sw/[controller]")]
    [ApiController]
    public class WebSocketController : ControllerBase
    {
        private readonly IUserServicer _userService;
        private readonly DbAppContext _context;
        private readonly IConfiguration _configuration;

        public WebSocketController(IUserServicer userService, DbAppContext context, IConfiguration configuration)
        {
            _userService = userService;
            _context = context;
            _configuration = configuration;
        }
        // GET: api/<WebSocketController>
        [HttpGet]
        //[Authorize(Roles = AuthorityPermissions.ADMIN)]
        public async Task Get()
        {
            if (HttpContext.WebSockets.IsWebSocketRequest)
            {
                using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
               
                var random = new Random();
                int previousCount = -1;
                while (webSocket.State == WebSocketState.Open)
                {
                    var currentCount = _context.Acccounts.Count();

                    if (currentCount != previousCount)
                    {
                        string jsonString = JsonSerializer.Serialize(currentCount);
                        var buffer = Encoding.UTF8.GetBytes(jsonString);
                        await webSocket.SendAsync(
                            new ArraySegment<byte>(buffer),
                            WebSocketMessageType.Text, true, CancellationToken.None);

                        previousCount = currentCount;
                    }
                    await Task.Delay(2000); 
                }
                await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure,
                            "Connection closed by the server", CancellationToken.None);
            }
            else
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        // GET api/<WebSocketController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WebSocketController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WebSocketController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WebSocketController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
