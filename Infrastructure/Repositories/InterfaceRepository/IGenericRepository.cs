using Infrastructure.Response;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.InterfaceRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        void Delete(T entity);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        Task<T> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] propertyExpression);
        Task<T> FindAsync(Expression<Func<T, bool>> expression, bool trackChanges = false, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);
        IQueryable<T> FilterAsync(Expression<Func<T, bool>> expression, bool trackChanges = false, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
        Task<PagedResponse<T>> GetPagedAsync(int pageNumber, int pageSize, Expression<Func<T, object>> orderBy, bool ascending = true);
        Task AddOrUpdateAsync(T entity, Expression<Func<T, bool>> predicate);
        public IQueryable<T> GetFromSqlAsync(string sql, params object[] parameters);
    }
}
