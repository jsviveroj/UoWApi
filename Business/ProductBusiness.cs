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
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductRepository productRepository;
        private readonly IRepositoryBaseFactory _repFactory;

        public ProductBusiness(IUnitOfWork unitOfWork, IRepositoryBaseFactory repFactory)
        {
            _unitOfWork = unitOfWork;
            _repFactory = repFactory;
            productRepository = new ProductRepository(unitOfWork);
        }

        public Product CreateProduct(ProductModel productModel)
        {
            ProductMapping productMapping = new ProductMapping();
            Product product = productMapping.CreateMapping(productModel);
            Product resultProduct = productRepository.Insert(product);
            return resultProduct;
        }

        public List<ProductModel> GetAllProducts()
        {
            //var productRep = _repFactory.GetDataRepository<IProductRepository>();
            List<ProductModel> list = productRepository.GetAll().Select( p =>  new ProductModel { Name = p.Name, ProductId = p.ProductId }).ToList();
            return list;
        }
    }
}
