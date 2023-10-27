using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.Repositories
{
    public interface IBlocksRepository : IGenericRepository<BlockInfo>
    {
        Task<List<BlockInfo>> GetByArticleId(long articleId);
        Task<BlockInfo> GetDetailsAsync(long id);
    }
}
