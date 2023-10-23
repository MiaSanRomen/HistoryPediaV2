using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HistoryPediaV2.Data.DbContext;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var path = Path.GetDirectoryName(
            Directory.GetParent(
                Directory.GetCurrentDirectory())?.Parent?.FullName)
                   + "//HistoryPediaV2//HistoryPediaV2//HistoryPediaV2.MVC//appsettings.json";
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(path, optional: false, reloadOnChange: true)
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var connection = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlite(connection);

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}