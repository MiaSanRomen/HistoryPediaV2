using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Data.Models;

[PrimaryKey("BlockInfoId")]
public sealed record BlockInfo(
    long BlockInfoId,
    string BlockName,
    string Text,
    [property: ForeignKey("PictureId")]
    long PictureId,
    [property: ForeignKey("ArticleId")]
    long ArticleId)
{
    public string? PrevName { get; set; }
    public Picture? Image { get; set; }
}