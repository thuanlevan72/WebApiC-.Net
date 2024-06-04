
using Entity.Models;
using MapperData.DtoMapperData;
using WebUserDemoApi.Controllers.UserControllers.UserViewModel;


namespace WebUserDemoApi.Services
{
    public interface IUserServicer
    {
        Task<List<Acccount>> GetAccount();
        Task<IEnumerable<Acccount>> GetAccount(int a);
        Task<Acccount> CreateAccount(LoginViewModel acccount);
        Task<Tuple<string,string>> LoginAcc(LoginViewModel login);
    }

}
