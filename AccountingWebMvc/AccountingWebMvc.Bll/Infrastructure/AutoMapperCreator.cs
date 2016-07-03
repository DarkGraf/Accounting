using AccountingWebMvc.Bll.Dto;
using AccountingWebMvc.Dal.Entities;
using AutoMapper;

namespace AccountingWebMvc.Bll.Infrastructure
{
    public static class AutoMapperCreator
    {
        public static IMapper CreateMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Article, ArticleDto>();
                cfg.CreateMap<ArticleDto, Article>();

                cfg.CreateMap<Order, OrderDto>();
                cfg.CreateMap<OrderDto, Order>().ForMember(entity => entity.CreationDate, opt => opt.Ignore());
            });
            return config.CreateMapper();
        }
    }
}
