using Business;
using BusinessContracts.Contracts;
using Data;
using Data.Infrastructure;
using Data.Repositories;
using DataContracts.Contracts;
using DataContracts.Infrastructure;
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

            container.RegisterType<IProductRepository, ProductRepository>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}