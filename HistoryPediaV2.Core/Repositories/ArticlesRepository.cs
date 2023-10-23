using AutoMapper;
using AutoMapper.QueryableExtensions;
using HistoryPediaV2.Data.DbContext;
using HistoryPediaV2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Core.Repositories;

public class ArticlesRepository : GenericRepository<Article>, IArticlesRepository
{
    public ArticlesRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<List<Article>> GetByNameAsync(string name)
    {
        return await Context.Set<Article>()
            .Where(article => article.Name.ToLower().Contains(name.ToLower())).ToListAsync();
    }
}