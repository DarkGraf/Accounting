using System.Data.Entity;

namespace AccountingWebMvc.Dal.EF
{
    public class StoreDbInitializer : CreateDatabaseIfNotExists<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            context.Articles.Add(new Entities.Article { Name = "Зарплата", Sign = 1 });
            context.Articles.Add(new Entities.Article { Name = "Аванс", Sign = 1 });
            context.Articles.Add(new Entities.Article { Name = "Ипотека", Sign = -1 });
            context.Articles.Add(new Entities.Article { Name = "Коммунальные платежи", Sign = -1 });

            context.SaveChanges();
        }
    }
}