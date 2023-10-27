using System.Net.Mime;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using HistoryPediaV2.Data.DbContext;
using HistoryPediaV2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Core.Repositories;

public sealed class ArticlesRepository : GenericRepository<Article>, IArticlesRepository
{
    private readonly IPicturesRepository _picturesRepository;
    private readonly IBlocksRepository _blocksRepository;

    public ArticlesRepository(ApplicationDbContext context, 
        IPicturesRepository picturesRepository,
        IBlocksRepository blocksRepository,
        IMapper mapper) 
        : base(context, mapper)
    {
        _picturesRepository = picturesRepository;
        _blocksRepository = blocksRepository;
    }

    public async Task<List<Article>> GetByNameAsync(string? name)
    {
        var articles = string.IsNullOrWhiteSpace(name) 
            ? await GetAllAsync()
            : await Context.Set<Article>().AsQueryable()
                .Where(article => article.Name.ToLower().Contains(name.ToLower()))
                .ToListAsync();
        
        foreach (var article in articles)
        {
            var image = await _picturesRepository.GetAsync<Picture>(article.PictureId);
            article.Image = image;
        }

        return articles;
    }

    public async Task<Article> GetDetailsAsync(long? id)
    {
        var article = await GetAsync<Article>(id);
        
        var image = await _picturesRepository.GetAsync<Picture>(article.PictureId);
        article.Image = image;

        var blocks = await _blocksRepository.GetByArticleId(article.ArticleId);
        article.Blocks = blocks;

        return article;
    }
}