using AccountingWebMvc.Dal.EF;
using AccountingWebMvc.Dal.Entities;
using AccountingWebMvc.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AccountingWebMvc.Dal.Repositories
{
    public class InventoryRepository : IRepository<Inventory>
    {
        AccountContext context;

        public InventoryRepository(AccountContext context)
        {
            this.context = context;
        }

        #region IRepository<Article>

        public void Create(Inventory item)
        {
            context.Inventories.Add(item);
        }

        public void Delete(Guid id)
        {
            Inventory item = context.Inventories.Find(id);
            if (item != null)
            {
                context.Inventories.Remove(item);
            }
        }

        public IEnumerable<Inventory> GetAll()
        {
            return context.Inventories;
        }

        public Inventory Get(Guid id)
        {
            return context.Inventories.Find(id);
        }

        public void Update(Inventory item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        #endregion
    }
}
