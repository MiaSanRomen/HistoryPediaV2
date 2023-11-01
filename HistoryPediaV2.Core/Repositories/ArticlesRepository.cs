using System.Net.Mime;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using HistoryPediaV2.Core.ViewModels.Articles;
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

    public async Task<SearchArticleViewModel> GetByNameAsync(string? name)
    {
        var articles = string.IsNullOrWhiteSpace(name) 
            ? await GetAllAsync<ArticleWithImageViewModel>()
            : await Context.Set<Article>().AsQueryable()
                .Where(article => article.Name.ToLower().Contains(name.ToLower()))
                .ProjectTo<ArticleWithImageViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        
        foreach (var article in articles)
        {
            var picture = await _picturesRepository.GetAsync<Picture>(article.PictureId);
            article.Image = picture;
        }

        return new SearchArticleViewModel(name, articles);
    }

    public async Task<ArticleDetailsViewModel> GetDetailsAsync(long? id)
    {
        var article = await GetAsync<ArticleDetailsViewModel>(id);
        
        var picture = await _picturesRepository.GetAsync<Picture>(article.PictureId);
        article.Image = picture;

        var blocks = await _blocksRepository.GetByArticleId(article.ArticleId);
        article.Blocks = blocks;

        return article;
    }

    public async Task<ArticleEditViewModel> GetEditDetailsAsync(long? id)
    {
        var article = await GetAsync<ArticleEditViewModel>(id);
        
        var picture = await _picturesRepository.GetAsync<Picture>(article.PictureId);
        article.Image = picture;

        var blocks = await _blocksRepository.GetShortByArticleId(article.ArticleId);
        article.Blocks = blocks;

        return article;
    }
}