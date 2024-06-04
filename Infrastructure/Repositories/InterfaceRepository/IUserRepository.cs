using Entity.Models;

namespace Infrastructure.Repositories.InterfaceRepository
{
    public interface IUserRepository: IGenericRepository<Acccount>
    {
        public IQueryable<Acccount> GetAcccounts();
        public Task<Acccount> CheckLogin(string userName, string password);
    }
}
