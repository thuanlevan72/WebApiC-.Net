using AutoMapper;
using AutoMapper.QueryableExtensions;
using BCrypt.Net;
using Entity.Models;
using Infrastructure.Repositories.InterfaceRepository;
using MapperData.DtoMapperData;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WebUserDemoApi.Controllers.UserControllers.UserViewModel;
using WebUserDemoApi.helpers;

namespace WebUserDemoApi.Services
{
    public class UserServicer : IUserServicer
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly GenerateJwtToken _generateJwtToken;
        private readonly IMapper _mapper;

        public UserServicer(IUnitOfWork unitOfWork, GenerateJwtToken generateJwtToken,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _generateJwtToken = generateJwtToken;
            _mapper = mapper;
        }

        public Task<Acccount> CreateAccount(LoginViewModel acccount)
        {
            throw new NotImplementedException();
        }

        public Task<List<Acccount>> GetAccount()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<Acccount>> GetAccount(int a)
        {
            var data  = _unitOfWork.UserRepository.GetAcccounts();
            var res = data.ProjectTo<AccountDto>(_mapper.ConfigurationProvider);
            return data;
        }
        public async Task<Tuple<string,string>> LoginAcc(LoginViewModel login)
        {
            var acc = await _unitOfWork.UserRepository.CheckLogin(login.UserName,login.Password);
            Tuple<string,string> GenerateToken = _generateJwtToken.Generate(acc);
            return GenerateToken;
        }
    }
}
