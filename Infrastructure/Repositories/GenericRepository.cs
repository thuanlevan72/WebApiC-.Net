using Infrastructure.Repositories.InterfaceRepository;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Helper;
using Infrastructure.Data;
using Infrastructure.Response;

namespace Infrastructure.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbAppContext _dbContext;

        protected GenericRepository(DbAppContext context)
        {
            _dbContext = context;
        }

        public async Task<T> GetById(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();    
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            using(var context = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    await _dbContext.Set<T>().AddRangeAsync(entities);
                    await _dbContext.SaveChangesAsync();
                    await context.CommitAsync();
                }
                catch (Exception ex)
                {
                    await context.RollbackAsync();
                    throw;
                }
               
            }
            
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();

        }
        
        public void UpdateRange(IEnumerable<T> entities)
        {
            using (var context = _dbContext.Database.BeginTransaction())
            {
                try
                {
                     _dbContext.Set<T>().UpdateRange(entities);
                     _dbContext.SaveChanges();
                    context.Commit();

                }
                catch (Exception ex)
                {
                    context.Rollback();
                    throw;
                }

            }
        }

        public async Task<T> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] propertyExpression)
        {
            var model = await _dbContext.Set<T>().IncludeMultiple(propertyExpression).Where(predicate).FirstOrDefaultAsync();
            return model;
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> expression, bool trackChanges = false, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        {
            // Get query
            IQueryable<T> query = _dbContext.Set<T>();

            // Apply filter
            query = query.Where(expression);

            // Include
            if (include != null)
            {
                query = include(query);
            }

            // Tracking
            if (!trackChanges)
                query.AsNoTracking();
            return await query.SingleOrDefaultAsync() ?? default;
        }

        public IQueryable<T> FilterAsync(Expression<Func<T, bool>> expression, bool trackChanges = false, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        {
            // Get query
            IQueryable<T> query = _dbContext.Set<T>();

            // Apply filter
            query = query.Where(expression);

            // Include
            if (include != null)
            {
                query = include(query);
            }

            // Tracking
            if (!trackChanges)
                query.AsNoTracking();

            return query;
        }
        public IQueryable<T> GetFromSqlAsync(string sql, params object[] parameters)
        {
            return _dbContext.Set<T>().FromSqlRaw(sql, parameters).AsQueryable();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            if(predicate == null)
                return await _dbContext.Set<T>().CountAsync(); 
            return await _dbContext.Set<T>().CountAsync(predicate);
        }

        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate)
        {
            var res = await _dbContext.Set<T>().AnyAsync(predicate);
            return res;
        }
        public async Task<PagedResponse<T>> GetPagedAsync(int pageNumber, int pageSize, Expression<Func<T, object>> orderBy, bool ascending = true)
        {
            IQueryable<T> query = _dbContext.Set<T>();

            if (ascending)
            {
                query = query.OrderBy(orderBy);
            }
            else
            {
                query = query.OrderByDescending(orderBy);
            }

            var totalRecords = await query.CountAsync();
            var data = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            return PagedResponse<T>.CreatePagedResponse(data, pageNumber, pageSize, totalRecords);
        }

        public async Task AddOrUpdateAsync(T entity, Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
