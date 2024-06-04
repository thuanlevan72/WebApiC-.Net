using Entity.Models;
using Infrastructure.Repositories.InterfaceRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace WebUserDemoApi.Hubs
{

    public class ChatHub: Hub
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUnitOfWork _unitOfWork;

        public ChatHub(IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;

        }
        public override async Task OnConnectedAsync()
        {
            var context = _httpContextAccessor.HttpContext;
            if (context != null && context.Request.Query.ContainsKey("userId"))
            {
                string userIdString = context.Request.Query["userId"].ToString();
                Console.WriteLine($"userIdString: {userIdString}");

                if (int.TryParse(userIdString, out int userId))
                {
                    Console.WriteLine($"Parsed userId: {userId}");
                    var connectionId = Context.ConnectionId;

                    var userCurent = await _unitOfWork.UserRepository.FindAsync(x => x.accountId == userId);
                    if (userCurent == null)
                        await base.OnDisconnectedAsync(new Exception("không tồn tại user này trong tài khoảng"));
                    var userConnection = await _unitOfWork.UserConnectionRepository.FindAsync(x => x.UserConnectionId == userCurent.accountId);

                    if (userConnection == null)
                    {
                        await _unitOfWork.UserConnectionRepository.Add(new UserConnections
                        {
                            UserConnectionId = userId,
                            ConnectionId = connectionId,
                            NickName = userCurent.userName
                        });
                    }
                    else
                    {
                        userConnection.ConnectionId = connectionId;
                        _unitOfWork.UserConnectionRepository.Update(userConnection);
                    }

                    await base.OnConnectedAsync();
                }
                else
                {
                    throw new FormatException("The userId query parameter is not in a correct format.");
                }
            }
            else
            {
                throw new ArgumentNullException("userId query parameter is missing.");
            }
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var userId = int.Parse(_httpContextAccessor.HttpContext.Request.Query["userId"].ToString());

            var userConnection = await _unitOfWork.UserConnectionRepository.FindAsync(x => x.UserConnectionId == userId);
            if (userConnection != null)
            {
                _unitOfWork.UserConnectionRepository.Delete(userConnection);
            }

            await base.OnDisconnectedAsync(exception);
        }

        public async Task SendMessage(string recipientUserId, string message)
        {
            var recipientConnection = await _unitOfWork.UserConnectionRepository.FindAsync(x => x.UserConnectionId == int.Parse(recipientUserId));
            if (recipientConnection != null)
            {
                await Clients.Client(recipientConnection.ConnectionId).SendAsync("ReceiveMessage", Context.GetHttpContext().Request.Query["userId"].ToString(), message);
            }
        }


        //
        //
        //
        //
        //
        //private static List<UserMessageModel> _connections = new List<UserMessageModel>();
        //public override async Task OnConnectedAsync()
        //{
        //    await base.OnConnectedAsync();
        //    Clients.Caller.SendAsync("ConnectionId",Context.ConnectionId);
        //}
        //public override async Task OnDisconnectedAsync(Exception exception)
        //{
        //    await base.OnDisconnectedAsync(exception);
        //    _connections.Remove(_connections.First(u => u.ConnectionId == Context.ConnectionId));
        //}
        //public async Task GetConnections(string userName)
        //{
        //    _connections.Add(new UserMessageModel { UserName = userName, ConnectionId = Context.ConnectionId });
        //    await Clients.All.SendAsync("ReceiveConnections", _connections);
        //}
        //public async Task SendMessage(string user, string message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", user, message);
        //}
        //public async Task UserIsTyping(string user)
        //{
        //    await Clients.All.SendAsync("UserIsTyping", user);
        //}
        //public async Task CLoseTyping()
        //{
        //    await Clients.All.SendAsync("CLoseTyping", true);
        //}
    }
}
