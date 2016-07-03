using AccountingWebMvc.Bll.Dto;
using System;
using System.Collections.Generic;

namespace AccountingWebMvc.Bll.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<ArticleDto> GetArticles();
        ArticleDto GetArticle(Guid id);
        void CreateArticle(ArticleDto article);
        void DeleteArticle(Guid id);
        void EditArticle(ArticleDto article);

        IEnumerable<OrderDto> GetOrders();
        OrderDto GetOrder(Guid id);
        void CreateOrder(OrderDto order);
        void DeleteOrder(Guid id);
        void EditOrder(OrderDto order);
    }
}
