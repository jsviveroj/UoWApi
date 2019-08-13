using Domain;
using System.Collections.Generic;

namespace Business.Interface
{
    public interface IProductBusiness
    {
        List<ProductModel> GetAllProducts();
    }
}
