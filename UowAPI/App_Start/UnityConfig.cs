using Business;
using Business.Interface;
using Data;
using Data.Contracts;
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

            // it is NOT necessary to register your controllers

            container.RegisterType<IRepositoryBaseFactory, RepositoryBaseFactory>();

            container.RegisterType<IBusinessFactory,BusinessFactory>();

            container.RegisterType<IProductBusiness, ProductBusiness>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}