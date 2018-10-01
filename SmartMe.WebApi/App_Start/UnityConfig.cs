using SmartMe.Core.Data;
using SmartMe.Core.Domain.Books;
using SmartMe.Data;
using SmartMe.Services.Books;
using SmartMe.WebApi.Controllers;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace SmartMe.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();
      container.RegisterType<IDbContext, SmartObjectContext>();
      container.RegisterType<IRepository<Book>, EfRepository<Book>>();
      container.RegisterType<ValuesController>();
      container.RegisterType<IBookService, BookService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
      GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
    }
    }
}