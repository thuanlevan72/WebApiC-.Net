using Infrastructure.Data;
using Infrastructure.Repositories.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DbAppContext _dbContext;
        public IUserRepository  UserRepository { get; }
        public IUserConnectionRepository UserConnectionRepository { get; }
        public IUserEntityRepository UserEntityRepository { get; }
        public IUserRoleRepository UserRoleRepository { get; }

        public UnitOfWork(DbAppContext dbContext)
        {
            _dbContext = dbContext;

        }

        public UnitOfWork(DbAppContext dbContext, IUserRepository userRepository, IUserConnectionRepository userConnectionRepository, IUserEntityRepository userEntityRepository, IUserRoleRepository userRoleRepository)
        {
            _dbContext = dbContext;
            UserRepository = userRepository;
            UserConnectionRepository = userConnectionRepository;
            UserEntityRepository = userEntityRepository;
            UserRoleRepository = userRoleRepository;
        }

      
        public int Save()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
