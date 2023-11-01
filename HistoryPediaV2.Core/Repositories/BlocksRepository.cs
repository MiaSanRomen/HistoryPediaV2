using Microsoft.EntityFrameworkCore;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using HistoryPediaV2.Core.ViewModels.Articles;
using HistoryPediaV2.Core.ViewModels.BlockInfo;
using HistoryPediaV2.Data.DbContext;
using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.Repositories;

public class BlocksRepository : GenericRepository<BlockInfo>, IBlocksRepository
{
    private readonly IPicturesRepository _picturesRepository;
    
    public BlocksRepository(ApplicationDbContext context,
        IPicturesRepository picturesRepository,
        IMapper mapper) : base(context, mapper)
    {
        _picturesRepository = picturesRepository;
    }

    public async Task<List<BlockWithImageViewModel>> GetByArticleId(long articleId)
    {
        var blocks = await Context.Set<BlockInfo>().AsQueryable()
                .Where(block => block.ArticleId.Equals(articleId))
                .ProjectTo<BlockWithImageViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        
        foreach (var block in blocks)
        {
            var picture = await _picturesRepository.GetAsync<Picture>(block.PictureId);
            block.Picture = picture;
        }

        return blocks;
    }

    public async Task<List<BlockShortViewModel>> GetShortByArticleId(long articleId)
    {
        var blocks = await Context.Set<BlockInfo>().AsQueryable()
            .Where(block => block.ArticleId.Equals(articleId))
            .ProjectTo<BlockShortViewModel>(_mapper.ConfigurationProvider)
            .ToListAsync();

        return blocks;
    }

    public async Task<BlockInfo> GetDetailsAsync(long id)
    {
        var block = await GetAsync<BlockInfo>(id);
        
        var picture = await _picturesRepository.GetAsync<Picture>(block.PictureId);
        block.Picture = picture;

        return block;
    }

    public async Task<BlockEditViewModel> GetEditDetailsAsync(long id)
    {
        var block = await GetAsync<BlockEditViewModel>(id);
        
        var picture = await _picturesRepository.GetAsync<Picture>(block.PictureId);
        block.Picture = picture;

        return block;
    }
}