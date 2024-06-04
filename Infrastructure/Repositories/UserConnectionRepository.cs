using Entity.Models;
using Infrastructure.Data;
using Infrastructure.Repositories.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserConnectionRepository : GenericRepository<UserConnections>, IUserConnectionRepository
    {
        public UserConnectionRepository(DbAppContext dbContext) : base(dbContext)
        {

        }
    }
}
