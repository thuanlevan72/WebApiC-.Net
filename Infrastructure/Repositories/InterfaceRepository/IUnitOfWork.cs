using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.InterfaceRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }

        IUserConnectionRepository UserConnectionRepository { get; }

        IUserEntityRepository UserEntityRepository { get; }

        IUserRoleRepository UserRoleRepository { get; }
        int Save();

    }
}
