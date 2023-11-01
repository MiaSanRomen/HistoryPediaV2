using AutoMapper;
using HistoryPediaV2.Core.ViewModels.Articles;
using HistoryPediaV2.Core.ViewModels.BlockInfo;
using HistoryPediaV2.Data.Models;

namespace HistoryPediaV2.Core.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Article, ArticleDetailsViewModel>().ReverseMap();
            CreateMap<Article, ArticleEditViewModel>().ReverseMap();
            CreateMap<Article, ArticleWithImageViewModel>().ReverseMap();
            CreateMap<Article, ArticleShortViewModel>().ReverseMap();
            
            CreateMap<BlockInfo, BlockWithImageViewModel>().ReverseMap();
            CreateMap<BlockInfo, BlockEditViewModel>().ReverseMap();
            CreateMap<BlockInfo, BlockShortViewModel>().ReverseMap();
        }
    }
}
