using Microsoft.EntityFrameworkCore;
using AutoMapper;
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

    public async Task<List<BlockInfo>> GetByArticleId(long articleId)
    {
        var blocks = await Context.Set<BlockInfo>().AsQueryable()
                .Where(block => block.ArticleId.Equals(articleId))
                .ToListAsync();
        
        foreach (var block in blocks)
        {
            var image = await _picturesRepository.GetAsync<Picture>(block.PictureId);
            block.Image = image;
        }

        return blocks;
    }

    public async Task<BlockInfo> GetDetailsAsync(long id)
    {
        var block = await GetAsync<BlockInfo>(id);
        
        var image = await _picturesRepository.GetAsync<Picture>(block.PictureId);
        block.Image = image;

        return block;
    }
}