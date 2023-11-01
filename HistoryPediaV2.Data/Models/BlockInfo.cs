using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Data.Models;

[PrimaryKey("BlockInfoId")]
public sealed record BlockInfo(
    [property: Key]
    long BlockInfoId,
    string Title,
    string Text,
    [property: ForeignKey("PictureId")]
    long PictureId,
    [property: ForeignKey("ArticleId")]
    long ArticleId)
{
    [ForeignKey(nameof(PictureId))] 
    public Picture? Picture { get; set; }
    [ForeignKey(nameof(ArticleId))] 
    public Article? Article { get; set; }
}