using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.ViewModels.Articles;

public sealed record ArticleWithImageViewModel(
    long ArticleId,
    string Name,
    string ShortInfo,
    long PictureId)
{
    public Picture? Image { get; set; }
};