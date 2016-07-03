using AccountingWebMvc.Dal.EF;
using AccountingWebMvc.Dal.Entities;
using AccountingWebMvc.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AccountingWebMvc.Dal.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        AccountContext context;

        public OrderRepository(AccountContext context)
        {
            this.context = context;
        }

        #region IRepository<Article>

        public void Create(Order item)
        {
            context.Orders.Add(item);
        }

        public void Delete(Guid id)
        {
            Order item = context.Orders.Find(id);
            if (item != null)
            {
                context.Orders.Remove(item);
            }
        }

        public IEnumerable<Order> GetAll()
        {
            return context.Orders;
        }

        public Order Get(Guid id)
        {
            return context.Orders.Find(id);
        }

        public void Update(Order item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        #endregion
    }
}
