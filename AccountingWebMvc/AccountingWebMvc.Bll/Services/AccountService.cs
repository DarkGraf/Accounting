using AccountingWebMvc.Bll.Dto;
using AccountingWebMvc.Bll.Infrastructure;
using AccountingWebMvc.Bll.Interfaces;
using AccountingWebMvc.Dal.Entities;
using AccountingWebMvc.Dal.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AccountingWebMvc.Bll.Services
{
    public class AccountService : IAccountService, IDisposable
    {
        IUnitOfWork uow;

        public AccountService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IEnumerable<ArticleDto> GetArticles()
        {
            IMapper mapper = AutoMapperCreator.CreateMapper();
            List<ArticleDto> articlesDto = mapper.Map<IEnumerable<Article>, List<ArticleDto>>(uow.Articles.GetAll());
            return articlesDto;
        }

        public ArticleDto GetArticle(Guid id)
        {
            IMapper mapper = AutoMapperCreator.CreateMapper();
            ArticleDto articlesDto = mapper.Map<Article, ArticleDto>(uow.Articles.Get(id));
            return articlesDto;
        }

        public void CreateArticle(ArticleDto articleDto)
        {
            IMapper mapper = AutoMapperCreator.CreateMapper();
            Article article = mapper.Map<ArticleDto, Article>(articleDto);
            uow.Articles.Create(article);
            uow.Save();
        }

        public void DeleteArticle(Guid id)
        {
            uow.Articles.Delete(id);
            uow.Save();
        }

        public void EditArticle(ArticleDto articleDto)
        {
            Article article = uow.Articles.Get(articleDto.Id);
            IMapper mapper = AutoMapperCreator.CreateMapper();            
            mapper.Map<ArticleDto, Article>(articleDto, article);
            uow.Save();
        }

        public IEnumerable<OrderDto> GetOrders()
        {
            IMapper mapper = AutoMapperCreator.CreateMapper();
            List<OrderDto> ordersDto = mapper.Map<IEnumerable<Order>, List<OrderDto>>(uow.Orders.GetAll());
            return ordersDto;
        }

        public OrderDto GetOrder(Guid id)
        {
            throw new NotImplementedException();
        }

        public void CreateOrder(OrderDto orderDto)
        {
            IMapper mapper = AutoMapperCreator.CreateMapper();
            Order order = mapper.Map<OrderDto, Order>(orderDto);
            uow.Orders.Create(order);
            uow.Save();
        }

        public void DeleteOrder(Guid id)
        {
            throw new NotImplementedException();
        }

        public void EditOrder(OrderDto order)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (uow != null)
            {
                uow.Dispose();
            }
        }
    }
}
