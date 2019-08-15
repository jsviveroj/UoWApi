using Data.Repositories;
using Domain;
using System.Collections.Generic;
using System.Linq;
using BusinessContracts.Contracts;
using Domain.Models;
using DataContracts.Infrastructure;
using DataContracts.Contracts;
using Domain.Utilities.Mappings;

namespace Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IRepositoryBaseFactory _repFactory;

        public ProductBusiness(IRepositoryBaseFactory repFactory)
        {
            _repFactory = repFactory;
        }

        public Product CreateProduct(ProductModel productModel)
        {
            ProductMapping productMapping = new ProductMapping();
            Product product = productMapping.CreateMapping(productModel);
            var productRep = _repFactory.GetDataRepository<IProductRepository>();
            Product resultProduct = productRep.Insert(product);
            return resultProduct;
        }

        public List<ProductModel> GetAllProducts()
        {
            var productRep = _repFactory.GetDataRepository<IProductRepository>();
            List<ProductModel> list = productRep.GetAll().Select(p => new ProductModel { Name = p.Name, ProductId = p.ProductId }).ToList();
            return list;
        }
    }
}
