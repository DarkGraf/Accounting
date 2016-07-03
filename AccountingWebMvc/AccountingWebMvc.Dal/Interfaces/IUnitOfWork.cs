using AccountingWebMvc.Dal.Entities;
using System;

namespace AccountingWebMvc.Dal.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Article> Articles { get; }
        IRepository<Inventory> Inventories { get; }
        IRepository<Order> Orders { get; }
        IRepository<FinancialStore> FinancialStores { get; }
        void Save();
    }
}
