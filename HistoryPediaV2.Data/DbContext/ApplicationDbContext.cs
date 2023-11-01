using HistoryPediaV2.Data.Configuration;
using HistoryPediaV2.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Data.DbContext;

public class ApplicationDbContext : IdentityDbContext<User>
{
    //todo use proper db
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Article> Articles { get; set; }
    public DbSet<BlockInfo> BlocksInfo { get; set; }
    public DbSet<Picture> Pictures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new PicturesConfiguration());
        modelBuilder.ApplyConfiguration(new UsersConfiguration());
        modelBuilder.ApplyConfiguration(new BlocksInfoConfiguration());
        modelBuilder.ApplyConfiguration(new ArticlesConfiguration());
        
        modelBuilder.Entity<User>()
            .HasMany(user => user.FavoriteArticles)
            .WithOne(article => article.User)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Article>()
            .HasMany(article => article.Blocks)
            .WithOne(block => block.Article)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Article>()
            .HasOne(article => article.Picture)
            .WithOne(picture => picture.Article)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<BlockInfo>()
            .HasOne(block => block.Picture)
            .WithOne(picture => picture.BlockInfo)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
