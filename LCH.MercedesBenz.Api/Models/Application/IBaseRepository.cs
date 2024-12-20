using System.Collections.Generic;
using System.Linq.Expressions;

namespace LCH.MercedesBenz.Api.Models.Application
{
    public interface IBaseRepository<T> : IDisposable where T : BaseEntity, new()
    {
        BaseResponse<T> GetAll();

        Task<BaseResponse<T>> GetAllAsync();

        BaseResponse<T> GetAllOrderBy(SortBy<T> sortBy);

        BaseResponse<T?> GetById(Guid id);

        Task<BaseResponse<T?>> GetByIdAsync(Guid id);

        BaseResponse<T?> GetFirst(Expression<Func<T, bool>> predicate);

        Task<BaseResponse<T?>> GetFirstAsync(Expression<Func<T, bool>> predicate);

        BaseResponse<T?> GetSingle(Expression<Func<T, bool>> predicate);

        Task<BaseResponse<T?>> GetSingleAsync(Expression<Func<T, bool>> predicate);

        BaseResponse<T> Get(Expression<Func<T, bool>> predicate);

        Task<BaseResponse<T>> GetAsync(Expression<Func<T, bool>> predicate);

        BaseResponse<T> GetOrderBy(Expression<Func<T, bool>> predicate, SortBy<T> sortBy);

        BaseResponse<T> GetByQuery(Query<T> query);

        BaseResponse<int> Count(Expression<Func<T, bool>>? predicate = null);

        Task<BaseResponse<int>> CountAsync(Expression<Func<T, bool>>? predicate = null);

        void Insert(T entity);

        BaseResponse<int> InsertAndSave(T entity);

        Task<BaseResponse<int>> InsertAndSaveAsync(T entity);

        void Update(T entity);

        BaseResponse<int> UpdateAndSave(T entity);

        Task<BaseResponse<int>> UpdateAndSaveAsync(T entity);

        void Delete(T entity);

        BaseResponse<int> DeleteAndSave(T entity);

        Task<BaseResponse<int>> DeleteAndSaveAsync(T entity);

        void DeleteById(Guid id);

        Task DeleteByIdAsync(Guid id);

        BaseResponse<int> DeleteByIdAndSave(Guid id);

        Task<BaseResponse<int>> DeleteByIdAndSaveAsync(Guid id);

        void DeleteSeveral(Expression<Func<T, bool>> predicate);

        Task DeleteSeveralAsync(Expression<Func<T, bool>> predicate);

        BaseResponse<int> DeleteSeveralAndSave(Expression<Func<T, bool>> predicate);

        Task<BaseResponse<int>> DeleteSeveralAndSaveAsync(Expression<Func<T, bool>> predicate);

        int Save();

        Task<int> SaveAsync();

        void BulkInsert(IList<T> entities);

        Task BulkInsertAsync(IList<T> entities);
    }
}
