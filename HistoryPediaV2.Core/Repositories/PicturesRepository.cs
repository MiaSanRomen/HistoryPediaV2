using AutoMapper;
using HistoryPediaV2.Data.DbContext;
using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.Repositories;

public sealed class PicturesRepository : GenericRepository<Picture>, IPicturesRepository
{
    public PicturesRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}