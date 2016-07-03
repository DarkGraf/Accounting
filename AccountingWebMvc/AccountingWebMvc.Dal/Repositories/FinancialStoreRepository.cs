using AccountingWebMvc.Dal.EF;
using AccountingWebMvc.Dal.Entities;
using AccountingWebMvc.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AccountingWebMvc.Dal.Repositories
{
    public class FinancialStoreRepository : IRepository<FinancialStore>
    {
        AccountContext context;

        public FinancialStoreRepository(AccountContext context)
        {
            this.context = context;
        }

        #region IRepository<FinancialStore>

        public void Create(FinancialStore item)
        {
            context.FinancialStores.Add(item);
        }

        public void Delete(Guid id)
        {
            FinancialStore item = context.FinancialStores.Find(id);
            if (item != null)
            {
                context.FinancialStores.Remove(item);
            }
        }

        public IEnumerable<FinancialStore> GetAll()
        {
            return context.FinancialStores;
        }

        public FinancialStore Get(Guid id)
        {
            return context.FinancialStores.Find(id);
        }

        public void Update(FinancialStore item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        #endregion
    }
}
