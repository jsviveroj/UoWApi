using Business;
using Business.Interface;
using Data.Infrastructure;
using Data.Infrastructure.Contract;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace UowAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();

            container.RegisterType<IProductBusiness, ProductBusiness>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}