using AccountingWebMvc.Dal.EF;
using AccountingWebMvc.Dal.Entities;
using AccountingWebMvc.Dal.Interfaces;

namespace AccountingWebMvc.Dal.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private AccountContext context;

        private ArticleRepository articleRepository;
        private InventoryRepository inventoryRepository;
        private OrderRepository orderRepository;
        private FinancialStoreRepository financialStoreRepository;

        public EFUnitOfWork(string nameOrConnectionString)
        {
            context = new AccountContext(nameOrConnectionString);
        }

        #region IUnitOfWork

        public IRepository<Article> Articles
        {
            get
            {
                if (articleRepository == null)
                    articleRepository = new ArticleRepository(context);
                return articleRepository;
            }
        }

        public IRepository<Inventory> Inventories
        {
            get
            {
                if (inventoryRepository == null)
                    inventoryRepository = new InventoryRepository(context);
                return inventoryRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(context);
                return orderRepository;
            }
        }

        public IRepository<FinancialStore> FinancialStores
        {
            get
            {
                if (financialStoreRepository == null)
                    financialStoreRepository = new FinancialStoreRepository(context);
                return financialStoreRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        #endregion
    }
}
