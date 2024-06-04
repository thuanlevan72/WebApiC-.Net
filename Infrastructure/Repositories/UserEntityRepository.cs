using Entity.Models.ModelV2;
using Infrastructure.Data;
using Infrastructure.Repositories.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserEntityRepository : GenericRepository<UserEntity>, IUserEntityRepository
    {
        public UserEntityRepository(DbAppContext dbContext) : base(dbContext)
        {

        }
    }
}
