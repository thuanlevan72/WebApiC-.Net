using Entity.Models;
using Infrastructure.Data;
using Infrastructure.Repositories.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<Acccount>, IUserRepository
    {
        public UserRepository(DbAppContext dbContext) : base(dbContext)
        {

        }

        public async Task<Acccount> CheckLogin(string userName, string password)
        {
          var acc = await this.FindAsync(x => x.userName.ToLower() == userName.ToLower());
          if(acc == null)
          {
                throw new Exception("Tài khoảng không tồn tại ${402}");
          }
          bool isPasswordCorrect = BCryptNet.Verify(password, acc.hashPassword);
          if(!isPasswordCorrect)
          {
                throw new Exception("Mật khẩu sai ${401}");
          }
          return acc;

        }

        public IQueryable<Acccount> GetAcccounts()
        {
           return _dbContext.Acccounts;
        }
    }
}
