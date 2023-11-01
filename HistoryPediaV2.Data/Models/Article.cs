using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Data.Models;

[PrimaryKey("ArticleId")]
public sealed record Article(
    [property: Key]
    long ArticleId,
    string Name,
    string ShortInfo,
    string Info,
    long PictureId,
    string UserId)
{
    [ForeignKey(nameof(UserId))] 
    public User? User { get; set; }
    [ForeignKey(nameof(PictureId))] 
    public Picture? Picture { get; set; }
    public IReadOnlyList<BlockInfo>? Blocks { get; set; }
}