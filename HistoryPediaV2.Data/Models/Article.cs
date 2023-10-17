using System.Net.Mime;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Data.Models;

[PrimaryKey("Id")]
public sealed record Article(
    string Name,
    string ShirtInfo,
    string Info,
    string ImageName)
{
    public int Id { get; set; }
    public List<BlockInfo> Blocks { get; set; }
    public Picture Image { get; set; }
    public string UserId { get; set; }
};