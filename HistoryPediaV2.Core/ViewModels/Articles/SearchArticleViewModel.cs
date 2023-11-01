using HistoryPediaV2.Core.ViewModels.Articles;
using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.ViewModels.Articles;
    
public sealed record SearchArticleViewModel(
    string? SearchText,
    List<ArticleWithImageViewModel> Articles);

