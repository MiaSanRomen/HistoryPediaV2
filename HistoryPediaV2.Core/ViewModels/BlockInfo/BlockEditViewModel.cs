using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.ViewModels.BlockInfo;

public sealed record BlockEditViewModel(
    long BlockInfoId,
    string Title,
    string Text,
    long PictureId,
    long ArticleId)
{
    public Picture? Picture { get; set; }
};