using LCH.MercedesBenz.Api.Models.Application;
using System.Linq.Expressions;

namespace LCH.MercedesBenz.Api.Models.Universal
{
    public interface IBaseUniversalRepository<T> : IDisposable where T : BaseUniversalEntity, new()
    {
        BaseResponse<int> Count(Expression<Func<T, bool>>? predicate = null);

        Task<BaseResponse<int>> CountAsync(Expression<Func<T, bool>>? predicate = null);

        BaseResponse<T> GetAll();

        Task<BaseResponse<T>> GetAllAsync();

        BaseResponse<T?> GetFirst(Expression<Func<T, bool>> predicate);

        Task<BaseResponse<T?>> GetFirstAsync(Expression<Func<T, bool>> predicate);

        BaseResponse<T?> GetSingle(Expression<Func<T, bool>> predicate);

        Task<BaseResponse<T?>> GetSingleAsync(Expression<Func<T, bool>> predicate);

        BaseResponse<T> Get(Expression<Func<T, bool>> predicate);

        Task<BaseResponse<T>> GetAsync(Expression<Func<T, bool>> predicate);

        BaseResponse<T> GetByQuery(Query<T> query);

        void Insert(T entity);

        BaseResponse<int> InsertAndSave(T entity);

        Task<BaseResponse<int>> InsertAndSaveAsync(T entity);

        void Update(T entity);

        BaseResponse<int> UpdateAndSave(T entity);

        Task<BaseResponse<int>> UpdateAndSaveAsync(T entity);

        void Delete(T entity);

        BaseResponse<int> DeleteAndSave(T entity);

        Task<BaseResponse<int>> DeleteAndSaveAsync(T entity);

        void DeleteSeveral(Expression<Func<T, bool>> predicate);

        Task DeleteSeveralAsync(Expression<Func<T, bool>> predicate);

        BaseResponse<int> DeleteSeveralAndSave(Expression<Func<T, bool>> predicate);

        Task<BaseResponse<int>> DeleteSeveralAndSaveAsync(Expression<Func<T, bool>> predicate);

        int Save();

        Task<int> SaveAsync();
    }
}
