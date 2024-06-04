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
    public class UserRoleRepository : GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(DbAppContext context) : base(context)
        {
        }
    }
}
