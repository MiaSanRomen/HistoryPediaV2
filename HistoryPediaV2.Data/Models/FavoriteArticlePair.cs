using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Data.Models;

[PrimaryKey("FavoritePairId")]
public sealed record FavoriteArticlePair(
    [property: Key]
    long FavoritePairId,
    string UserId,
    long ArticleId)
{
    [ForeignKey(nameof(UserId))] 
    public User? User { get; set; }
    [ForeignKey(nameof(ArticleId))] 
    public Article? Article { get; set; }
}