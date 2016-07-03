using AccountingWebMvc.Bll.Infrastructure;
using AccountingWebMvc.Bll.Interfaces;
using AccountingWebMvc.Bll.Services;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Configuration;
using System.Web.Mvc;

namespace AccountingWebMvc
{
    public static class AutofacConfigure
    {
        public static void RegisterTypes()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<AccountService>().As<IAccountService>();
            builder.RegisterModule(new ServiceModule(connectionString));
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}