using HistoryPediaV2.Core.ViewModels.BlockInfo;
using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.Repositories
{
    public interface IBlocksRepository : IGenericRepository<BlockInfo>
    {
        Task<List<BlockWithImageViewModel>> GetByArticleId(long articleId);
        Task<List<BlockShortViewModel>> GetShortByArticleId(long articleId);
        Task<BlockInfo> GetDetailsAsync(long id);
        Task<BlockEditViewModel> GetEditDetailsAsync(long id);
    }
}
