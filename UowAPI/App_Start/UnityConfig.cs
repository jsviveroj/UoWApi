using Business;
using Business.Interface;
using Data.Infrastructure;
using Data.Infrastructure.Contract;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace UowAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IProductBusiness, ProductBusiness>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}