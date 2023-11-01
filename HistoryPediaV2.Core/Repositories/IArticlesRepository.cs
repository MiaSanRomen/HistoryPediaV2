using HistoryPediaV2.Core.ViewModels.Articles;
using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.Repositories
{
    public interface IArticlesRepository : IGenericRepository<ArticleDetailsViewModel>
    {
        Task<SearchArticleViewModel> GetByNameAsync(string name);
        Task<ArticleDetailsViewModel> GetDetailsAsync(long? id);
        Task<ArticleEditViewModel> GetEditDetailsAsync(long? id);
    }
}
