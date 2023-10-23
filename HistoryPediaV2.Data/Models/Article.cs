using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Data.Models;

[PrimaryKey("ArticleId")]
public sealed record Article(
    long ArticleId,
    string Name,
    string ShirtInfo,
    string Info,
    [property: ForeignKey("PictureId")]
    long PictureId)
{
    public List<BlockInfo>? Blocks { get; set; }
    public Picture? Image { get; set; }
};