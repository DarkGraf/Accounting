using AccountingWebMvc.Dal.Interfaces;
using AccountingWebMvc.Dal.Repositories;
using Autofac;

namespace AccountingWebMvc.Bll.Infrastructure
{
    public class ServiceModule : Module
    {
        string nameOrConnectionString;

        public ServiceModule(string nameOrConnectionString)
        {
            this.nameOrConnectionString = nameOrConnectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new EFUnitOfWork(nameOrConnectionString)).As<IUnitOfWork>();
        }
    }
}
