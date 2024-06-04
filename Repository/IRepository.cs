using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    internal interface IRepository: IDisposable
    {
        T Add<T>(T entity) where T : class;
        void AddRange<T>(params T[] entities) where T : class;
        T Update<T>(T entity) where T : class;
        void Delete<T>(object id) where T : class;
        T Get<T>(object id) where T : class;
        T Get<T>(Expression<Func<T, bool>> expression) where T : class;

        #region Async
        Task<T> AddAsync<T>(T entity) where T : class;
        Task AddRangeAsync<T>(params T[] entities) where T : class;
        Task<T> UpdateAsync<T>(T entity) where T : class;

        Task DeleteAsync<T, TKey>(TKey id) where T : class;
        Task DeleteAsync<T, TKey>(TKey[] ids) where T : class;
        Task DeleteAsync<T>(params Expression<Func<T, bool>>[] expression) where T : class;

        Task<T> GetAsync<T>(object id) where T : class;
        Task<T> GetAsync<T>(params Expression<Func<T, bool>>[] expression) where T : class;
        #endregion

        IQueryable<T> GetAll<T>() where T : class;
        IQueryable<T> Filter<T>(params Expression<Func<T, bool>>[] expression) where T : class;

        IQueryable<TQuery> FromSql<TQuery>(string sql, params object[] parameters)
            where TQuery : class;
        TContext GetDatabase<TContext>() where TContext : class;
        void Save();
        Task SaveAsync();
        void Dispose();
        void FromSql(string sql, params object[] parameters);
    }
}
