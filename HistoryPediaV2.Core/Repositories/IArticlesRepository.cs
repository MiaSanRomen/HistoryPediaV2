using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.Repositories
{
    public interface IArticlesRepository : IGenericRepository<Article>
    {
        Task<List<Article>> GetByNameAsync(string name);
    }
}
