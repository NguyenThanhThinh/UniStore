using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using UniStore.Models;
using UniStore.Models.Repositories;

namespace UniStore.App_Start
{
    public class DependencyConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.Register(t => new UnitOfWork(new UniStoreDbContext())).As<IUnitOfWork>();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));

            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                   .Where(t => t.Name.EndsWith("Store"))
                   .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assembly)
                   .Where(t => t.Name.EndsWith("Handler"))
                   .AsImplementedInterfaces();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}