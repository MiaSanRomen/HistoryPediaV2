using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.ViewModels.Articles
{
    public class SearchArticleViewModel
    {
        public User User { get; set; }
        public List<Article> Articles { get; set; }
    }
}
