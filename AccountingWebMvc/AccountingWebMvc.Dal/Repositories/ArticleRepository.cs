using AccountingWebMvc.Dal.EF;
using AccountingWebMvc.Dal.Entities;
using AccountingWebMvc.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AccountingWebMvc.Dal.Repositories
{
    public class ArticleRepository : IRepository<Article>
    {
        AccountContext context;

        public ArticleRepository(AccountContext context)
        {
            this.context = context;
        }

        #region IRepository<Article>

        public void Create(Article item)
        {
            context.Articles.Add(item);
        }

        public void Delete(Guid id)
        {
            Article item = context.Articles.Find(id);
            if (item != null)
            {
                context.Articles.Remove(item);
            }
        }

        public IEnumerable<Article> GetAll()
        {
            return context.Articles;
        }

        public Article Get(Guid id)
        {
            return context.Articles.Find(id);
        }

        public void Update(Article item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        #endregion
    }
}
