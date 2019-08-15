using Domain;
using Domain.Models;
using System.Collections.Generic;

namespace BusinessContracts.Contracts
{
    public interface IProductBusiness : IBaseBusinessFactory
    {
        List<ProductModel> GetAllProducts();
        Product CreateProduct(ProductModel productModel);
    }
}
