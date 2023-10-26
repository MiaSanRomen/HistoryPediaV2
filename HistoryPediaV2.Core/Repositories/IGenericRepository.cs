namespace HistoryPediaV2.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        // Task<T> GetAsync(int? id);
        Task<TResult> GetAsync<TResult>(long? id);
        // Task<List<T>> GetAllAsync();
        Task<List<TResult>> GetAllAsync<TResult>();
        // Task<T> AddAsync(T entity);
        Task<TResult> AddAsync<TSource, TResult>(TSource source);
        Task DeleteAsync(long id);
        // Task UpdateAsync(T entity);
        Task UpdateAsync<TSource>(long id, TSource source);
        // Task<bool> Exists(int id);
    }
}
