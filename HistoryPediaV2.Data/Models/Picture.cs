using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Data.Models;

[PrimaryKey("PictureId")]
public sealed record Picture(
    [property: Key]
    long PictureId,
    string PictureName,
    string? Path,
    string? PictureText = null,
    byte[]? ImageBytes = null)
{
    public Article? Article { get; set; }
    public BlockInfo? BlockInfo { get; set; }
}
