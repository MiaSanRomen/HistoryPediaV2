using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.ViewModels.Articles
{
    public class SearchArticleViewModel
    {
        public string SearchText { get; set; }
        public List<Article> Articles { get; set; }
    }
}
