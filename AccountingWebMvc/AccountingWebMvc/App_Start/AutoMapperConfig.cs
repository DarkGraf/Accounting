using AccountingWebMvc.Bll.Dto;
using AccountingWebMvc.Models;
using AutoMapper;

namespace AccountingWebMvc
{
    public static class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ArticleDto, ArticleViewModel>()
                    .ForMember(entity => entity.Type, opt => opt.MapFrom(m => (ArticleTypes)m.Sign));
                cfg.CreateMap<ArticleCreateViewModel, ArticleDto>()
                    .ForMember(entity => entity.Sign, opt => opt.MapFrom(m => (short)m.Type));
                cfg.CreateMap<ArticleViewModel, ArticleDto>()
                    .ForMember(entity => entity.Sign, opt => opt.MapFrom(m => (short)m.Type));
                cfg.CreateMap<ArticleDto, ArticleViewModel>()
                    .ForMember(entity => entity.Type, opt => opt.MapFrom(m => (ArticleTypes)m.Sign));

                cfg.CreateMap<OrderDto, OrderIndexViewModel>();
                cfg.CreateMap<OrderCreateViewModel, OrderDto>();
            });
        }
    }
}