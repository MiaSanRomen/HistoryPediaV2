using HistoryPediaV2.Core.Repositories;

namespace HistoryPediaV2.MVC.AppSetUps;

public static class CustomDependencies
{
    public static IServiceCollection RegisterRepositories(this IServiceCollection services)
    {
        services.AddScoped<IArticlesRepository, ArticlesRepository>();
        services.AddScoped<IPicturesRepository, PicturesRepository>();
        return services;
    }
}