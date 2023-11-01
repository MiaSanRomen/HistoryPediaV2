using HistoryPediaV2.Data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HistoryPediaV2.Data.Configuration;

public class UsersConfiguration : IEntityTypeConfiguration<User>
{
    public static string AdminId => "admin";
    public void Configure(EntityTypeBuilder<User> builder)
    {
        var adminUser = new User()
        {
            Id = AdminId,
            UserName = "Admin",
            EmailConfirmed = true,
            Email = "raman.bryzinski.poland@gmail.com"
        };
        adminUser.PasswordHash = new PasswordHasher<User>().HashPassword(adminUser, "admin");
        
        builder.HasData(
            adminUser
        );
    }
}