using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Audit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
        public class Repository<TContext, TUser, TUserKey> : IRepository, IDisposable where TContext : DbContext, new() where TUser : class where TUserKey : struct
        {
            private readonly TContext _context;
            private readonly IUserIdentity<TUserKey>? _userIdentity;
            private readonly ILogger<Repository<TContext, TUser, TUserKey>> _logger;

            public Repository(TContext context, IUserIdentity<TUserKey>? userIdentity)
            {
                _context = context;
                _userIdentity = userIdentity;
            }
            public Repository(TContext context)
            {
                _context = context;
            }

            public IQueryable<T> GetAll<T>() where T : class
            {
                return _context.Set<T>().AsQueryable();
            }
            public IQueryable<T> Filter<T>(params Expression<Func<T, bool>>[] expression) where T : class
            {
                return _context.Set<T>().WhereMany(expression.ToArray());
            }

            public void AddRange<T>(params T[] entities) where T : class
            {
                //if (entity == null)
                //    throw new ArgumentNullException("Entity not null.");

                try
                {
                    foreach (var entity in entities)
                    {
                        AddCreateInfo<T>(entity);
                        //AddCreateLog<T>(entity);
                        _context.Add(entity);
                    }
                    _context.SaveChanges();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public T Add<T>(T entity) where T : class
            {
                try
                {
                    if (entity == null)
                        throw new ArgumentNullException("Entity not null.");
                    AddCreateInfo<T>(entity);
                    //AddCreateLog<T>(entity);
                    _context.Add(entity);
                    _context.SaveChanges();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {

                    throw;
                }
                return entity;
            }

            public void Delete<T>(object id) where T : class
            {
                var entity = Get<T>(id);

                if (typeof(IDeleteInfo<TUser, TUserKey>).IsAssignableFrom(typeof(T)))
                {
                    AddDeleteInfo<T>(entity);
                }
                else
                {
                    _context.Remove(entity);
                }
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public T Get<T>(object id) where T : class
            {
                var entity = _context.Set<T>().Find(id);
                return entity ?? throw new ArgumentNullException("Entity is null.");
            }
            public T Update<T>(T entity) where T : class
            {
                _context.Set<T>().Update(entity);
                AddUpdateInfo<T>(entity);
                //AddUpdateLog<T>(entity);
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {
                    throw;
                }
                return entity;
            }


            public T Get<T>(Expression<Func<T, bool>> expression) where T : class
            {
                return _context.Set<T>().Where(expression).FirstOrDefault();
            }

            #region Async
            public async Task<T> AddAsync<T>(T entity) where T : class
            {
                if (entity == null)
                    throw new ArgumentNullException("Entity not null.");

                AddCreateInfo<T>(entity);
                //AddCreateLog<T>(entity);

                await _context.AddAsync(entity);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {
                    throw;
                }
                return entity;
            }

            public async Task AddRangeAsync<T>(params T[] entities) where T : class
            {
                //if (entity == null)
                //    throw new ArgumentNullException("Entity not null.");
                foreach (var entity in entities)
                {
                    await _context.AddAsync(entity);
                    AddCreateInfo<T>(entity);
                    //AddCreateLog<T>(entity);
                }
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public async Task DeleteAsync<T, TKey>(TKey id) where T : class
            {
                var entity = await GetAsync<T>(id);
                if (typeof(IDeleteInfo<TUser, TUserKey>).IsAssignableFrom(typeof(T)))
                {
                    AddDeleteInfo<T>(entity);
                }
                else
                {
                    _context.Remove(entity);
                }
                //AddDeleteLog<T>(entity);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public async Task DeleteAsync<T, TKey>(TKey[] ids) where T : class
            {
                foreach (var id in ids)
                {
                    var entity = await GetAsync<T>(id);
                    if (typeof(IDeleteInfo<TUser, TUserKey>).IsAssignableFrom(typeof(T)))
                    {
                        AddDeleteInfo<T>(entity);
                    }
                    else
                    {
                        _context.Remove(entity);
                    }
                    //AddDeleteLog<T>(entity);
                }
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public async Task DeleteAsync<T>(params Expression<Func<T, bool>>[] expression) where T : class
            {
                var entity = await GetAsync<T>(expression);
                if (typeof(IDeleteInfo<TUser, TUserKey>).IsAssignableFrom(typeof(T)))
                {
                    AddDeleteInfo<T>(entity);
                }
                else
                {
                    _context.RemoveRange(entity);
                }
                //AddDeleteLog<T>(entity);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {
                    throw;
                }
            }


            public async Task<T> GetAsync<T>(object id) where T : class
            {
                var entity = await _context.Set<T>().FindAsync(id);

                if (this is IProcessing<T>)
                {
                    try
                    {
                        (this as IProcessing<T>).OnReading(entity);
                    }
                    catch (NotFiniteNumberException)
                    {
                    }
                }


                return entity ?? throw new ArgumentNullException("Entity is null.");
            }
            public async Task<T> UpdateAsync<T>(T entity) where T : class
            {
                _context.Set<T>().Update(entity);

                AddUpdateInfo<T>(entity);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {
                    throw;
                }

                return entity;
            }


            public Task<T> GetAsync<T>(params Expression<Func<T, bool>>[] expression) where T : class
            {
                var result = _context.Set<T>().WhereMany(expression).FirstOrDefaultAsync();
                return result;
            }
            #endregion

            public virtual IQueryable<T> FromSql<T>(string sql, params object[] parameters) where T : class
            {
                return _context.Set<T>().FromSqlRaw(sql, parameters);
            }
            public DbContext GetDatabase<DbContext>() where DbContext : class
            {
                return _context as DbContext;
            }
            public void Save()
            {
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public async Task SaveAsync()
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException exc)
                {
                    var exception = HandleDbUpdateException(exc);
                    throw exception;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public void FromSql(string sql, params object[] parameters)
            {
                _context.Database.ExecuteSqlRaw(sql, parameters);
            }

            private bool disposed = false;

            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        _context.Dispose();
                    }
                }
                this.disposed = true;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            #region Add Info
            private void AddCreateInfo<TEntity>(TEntity entity)
            {
                if (entity is ICreateInfo<TUser, TUserKey>)
                {
                    (entity as ICreateInfo<TUser, TUserKey>).CreatedAt = DateTime.Now;
                    (entity as ICreateInfo<TUser, TUserKey>).CreatedUserId = _userIdentity?.UserId;
                }
            }
            private void AddUpdateInfo<TEntity>(TEntity entity)
            {
                if (entity is IUpdateInfo<TUser, TUserKey>)
                {
                    (entity as IUpdateInfo<TUser, TUserKey>).LastUpdatedDate = DateTime.Now;
                    (entity as IUpdateInfo<TUser, TUserKey>).LastUpdatedUserId = _userIdentity?.UserId;
                }
            }
            private void AddDeleteInfo<TEntity>(TEntity entity)
            {
                if (entity is IDeleteInfo<TUser, TUserKey>)
                {
                    (entity as IDeleteInfo<TUser, TUserKey>).DeletedDate = DateTime.Now;
                    (entity as IDeleteInfo<TUser, TUserKey>).DeletedUserId = _userIdentity?.UserId;
                }
            }

            // Logs

            #endregion
            //#region Add Logs
            //private void AddCreateLog<TEntity>(TEntity entity) where TEntity : class
            //{
            //    var logObj = new ExtraPropertyLogger("Tài khoản \"{username}\" đã thêm mới \"{entity}\" {identifier}",
            //        _userIdentity.UserName,
            //        typeof(TEntity).GetEntityName(),
            //        entity.ToString())
            //        .AddProp("action", DataActionType.Add)
            //        .AddProp("target", typeof(TEntity).GetTableName())
            //        .AddProp("data", JsonConvert.SerializeObject(entity, JsonSetting));

            //    AddExtraLogInfo(logObj, entity);
            //    _logger.Log(LogLevel.Information, default(EventId), logObj, null, ExtraPropertyLogger.Formatter);
            //}

            //private void AddUpdateLog<TEntity>(TEntity entity) where TEntity : class
            //{
            //    var logObj = new ExtraPropertyLogger("Tài khoản \"{username}\" đã cập nhật \"{entity}\" {identifier}",
            //        _userIdentity.UserName,
            //        typeof(TEntity).GetEntityName(),
            //        entity.ToString())
            //        .AddProp("action", DataActionType.Add)
            //        .AddProp("target", typeof(TEntity).GetTableName())
            //        .AddProp("data", JsonConvert.SerializeObject(entity, JsonSetting));

            //    AddExtraLogInfo(logObj, entity);
            //    _logger.Log(LogLevel.Information, default(EventId), logObj, null, ExtraPropertyLogger.Formatter);
            //}

            //private void AddDeleteLog<TEntity>(TEntity entity) where TEntity : class
            //{
            //    var logObj = new ExtraPropertyLogger("Tài khoản \"{username}\" đã xoá \"{entity}\" {identifier}",
            //        _userIdentity.UserName,
            //        typeof(TEntity).GetEntityName(),
            //        entity.ToString())
            //        .AddProp("action", DataActionType.Add)
            //        .AddProp("target", typeof(TEntity).GetTableName())
            //        .AddProp("data", JsonConvert.SerializeObject(entity, JsonSetting));

            //    AddExtraLogInfo(logObj, entity);
            //    _logger.Log(LogLevel.Information, default(EventId), logObj, null, ExtraPropertyLogger.Formatter);
            //}


            //private void AddExtraLogInfo<TEntity>(ExtraPropertyLogger logObj, TEntity entity)
            //{
            //    if (this is IExtraLogInfo<TEntity>)
            //    {
            //        foreach (var prop in (this as IExtraLogInfo<TEntity>).GetExtraLogInfo(entity))
            //        {
            //            logObj.AddProp(prop.Key, prop.Value);
            //        }
            //    }
            //}

            //#endregion

            private Exception HandleDbUpdateException(DbUpdateException dbu)
            {
                var builder = new StringBuilder("A DbUpdateException was caught while saving changes. ");

                try
                {
                    foreach (var result in dbu.Entries)
                    {
                        builder.AppendFormat("Type: {0} was part of the problem. ", result.Entity.GetType().Name);
                    }
                }
                catch (Exception e)
                {
                    builder.Append("Error parsing DbUpdateException: " + e.ToString());
                }

                string message = builder.ToString();
                return new Exception(message, dbu);
            }
        }
    }
