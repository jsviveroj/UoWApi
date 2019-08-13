using Business.Interface;
using Data.Infrastructure.Contract;
using Data.Repositories;
using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductRepository productRepository;

        public ProductBusiness(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            productRepository = new ProductRepository(unitOfWork);
        }
        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> list = productRepository.GetAll().Select( p =>  new ProductModel { Name = p.Name, ProductId = p.ProductId }).ToList();
            return list;
        }
    }
}
