using LCH.MercedesBenz.Api.Models.Application;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LCH.MercedesBenz.Api.Models.Recolector
{
    public class BaseRecolectorRepository<T> : IBaseRecolectorRepository<T> where T : BaseRecolectorEntity, new()
    {
        public readonly RecolectorDbContext Context;
        private bool _disposed = false;

        public BaseRecolectorRepository(RecolectorDbContext context)
        {
            Context = context;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public BaseResponse<int> Count(Expression<Func<T, bool>>? predicate = null)
        {
            var where = predicate ?? (e => true);
            var result = Context.Set<T>().Count(where);
            return new BaseResponse<int>(StatusCodes.Status200OK, result);
        }

        public async Task<BaseResponse<int>> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            var where = predicate ?? (e => true);
            var result = await Context.Set<T>().CountAsync(where);
            return new BaseResponse<int>(StatusCodes.Status200OK, result);
        }

        public BaseResponse<T> GetAll()
        {
            var results = Context.Set<T>().ToList();
            return new BaseResponse<T>(StatusCodes.Status200OK, results);
        }

        public async Task<BaseResponse<T>> GetAllAsync()
        {
            var results = await Context.Set<T>().ToListAsync();
            return new BaseResponse<T>(StatusCodes.Status200OK, results);
        }

        public BaseResponse<T?> GetFirst(Expression<Func<T, bool>> predicate)
        {
            var result = Context.Set<T>().FirstOrDefault(predicate);
            return new BaseResponse<T?>(StatusCodes.Status200OK, result);
        }

        public async Task<BaseResponse<T?>> GetFirstAsync(Expression<Func<T, bool>> predicate)
        {
            var result = await Context.Set<T>().FirstOrDefaultAsync(predicate);
            return new BaseResponse<T?>(StatusCodes.Status200OK, result);
        }

        public BaseResponse<T?> GetSingle(Expression<Func<T, bool>> predicate)
        {
            var result = Context.Set<T>().SingleOrDefault(predicate);
            return new BaseResponse<T?>(StatusCodes.Status200OK, result);
        }

        public async Task<BaseResponse<T?>> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            var result = await Context.Set<T>().SingleOrDefaultAsync(predicate);
            return new BaseResponse<T?>(StatusCodes.Status200OK, result);
        }

        public BaseResponse<T> Get(Expression<Func<T, bool>> predicate)
        {
            var results = Context.Set<T>().Where(predicate).ToList();
            return new BaseResponse<T>(StatusCodes.Status200OK, results);
        }

        public async Task<BaseResponse<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            var results = await Context.Set<T>().Where(predicate).ToListAsync();
            return new BaseResponse<T>(StatusCodes.Status200OK, results);
        }

        public BaseResponse<T> GetByQuery(Query<T> query)
        {
            var results = new List<T>();
            if (query.Page < 0)
                return new BaseResponse<T>(StatusCodes.Status200OK, results);

            Expression<Func<T, bool>> whereTrue = e => true;
            var where = query.Where ?? whereTrue;

            if (query.OrderBy != null)
            {
                results = Context.Set<T>().Where(where).OrderBy(query.OrderBy)
                    .Skip(query.Page * query.Top)
                    .Take(query.Top)
                    .ToList();
                return new BaseResponse<T>(StatusCodes.Status200OK, results);
            }

            if (query.OrderByDescending != null)
            {
                results = Context.Set<T>().Where(where).OrderByDescending(query.OrderByDescending)
                .Skip(query.Page * query.Top)
                .Take(query.Top)
                .ToList();
                return new BaseResponse<T>(StatusCodes.Status200OK, results);
            }

            results = Context.Set<T>().Where(where)
                    .Skip(query.Page * query.Top)
                    .Take(query.Top)
                    .ToList();
            return new BaseResponse<T>(StatusCodes.Status200OK, results);
        }

        public void Insert(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public BaseResponse<int> InsertAndSave(T entity)
        {
            Insert(entity);
            var result = Save();
            return new BaseResponse<int>(StatusCodes.Status200OK, result);
        }

        public async Task<BaseResponse<int>> InsertAndSaveAsync(T entity)
        {
            Insert(entity);
            var result = await SaveAsync();
            return new BaseResponse<int>(StatusCodes.Status200OK, result);
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public BaseResponse<int> UpdateAndSave(T entity)
        {
            Update(entity);
            var result = Save();
            return new BaseResponse<int>(StatusCodes.Status200OK, result);
        }

        public async Task<BaseResponse<int>> UpdateAndSaveAsync(T entity)
        {
            Update(entity);
            var result = await SaveAsync();
            return new BaseResponse<int>(StatusCodes.Status200OK, result);
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public BaseResponse<int> DeleteAndSave(T entity)
        {
            Delete(entity);
            var result = Save();
            return new BaseResponse<int>(StatusCodes.Status200OK, result);
        }

        public async Task<BaseResponse<int>> DeleteAndSaveAsync(T entity)
        {
            Delete(entity);
            var result = await SaveAsync();
            return new BaseResponse<int>(StatusCodes.Status200OK, result);
        }

        public void DeleteSeveral(Expression<Func<T, bool>> predicate)
        {
            var response = Get(predicate);
            if (response.StatusCode != 200) return;
            Context.Set<T>().RemoveRange(response.Results);
        }

        public async Task DeleteSeveralAsync(Expression<Func<T, bool>> predicate)
        {
            var response = await GetAsync(predicate);
            if (response.StatusCode != 200) return;
            Context.Set<T>().RemoveRange(response.Results);
        }

        public BaseResponse<int> DeleteSeveralAndSave(Expression<Func<T, bool>> predicate)
        {
            DeleteSeveral(predicate);
            var result = Save();
            return new BaseResponse<int>(StatusCodes.Status200OK, result);
        }

        public async Task<BaseResponse<int>> DeleteSeveralAndSaveAsync(Expression<Func<T, bool>> predicate)
        {
            await DeleteSeveralAsync(predicate);
            var result = await SaveAsync();
            return new BaseResponse<int>(StatusCodes.Status200OK, result);
        }

        public int Save()
        {
            return Context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await Context.SaveChangesAsync();
        }
    }
}
