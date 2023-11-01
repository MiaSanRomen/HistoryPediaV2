using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.ViewModels.BlockInfo;

public sealed record BlockWithImageViewModel(
    string Title,
    string Text,
    long PictureId)
{
    public Picture? Picture { get; set; }
};