using Microsoft.AspNetCore.Identity;

namespace HistoryPediaV2.Data.Models;

public class User : IdentityUser
{
    public List<Article>? FavoriteArticles { get; set; }
}