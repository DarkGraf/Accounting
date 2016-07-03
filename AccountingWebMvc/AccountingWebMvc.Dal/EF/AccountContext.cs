using AccountingWebMvc.Dal.Entities;
using System.Data.Entity;

namespace AccountingWebMvc.Dal.EF
{
    public class AccountContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<FinancialStore> FinancialStores { get; set; }

        static AccountContext()
        {
            Database.SetInitializer<AccountContext>(new StoreDbInitializer());
        }

        public AccountContext(string nameOrConnectionString) : base(nameOrConnectionString) { }
    }
}