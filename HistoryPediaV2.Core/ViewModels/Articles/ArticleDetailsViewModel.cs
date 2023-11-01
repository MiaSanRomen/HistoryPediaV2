using System.ComponentModel.DataAnnotations.Schema;
using HistoryPediaV2.Core.ViewModels.BlockInfo;
using HistoryPediaV2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Core.ViewModels.Articles;

public sealed record ArticleDetailsViewModel(
    long ArticleId,
    string Name,
    string ShortInfo,
    string Info,
    long PictureId)
{
    public List<BlockWithImageViewModel>? Blocks { get; set; }
    public Picture? Image { get; set; }
};