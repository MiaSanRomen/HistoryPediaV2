using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Data.Models;

[PrimaryKey("PictureId")]
public sealed record Picture(
    long PictureId,
    string PictureName,
    string? Path,
    string? PictureText = null,
    byte[]? Image = null);
