﻿using Domain;
using System.Collections.Generic;
using Data.Entities;
using System.Net.Http;

namespace Business.Interface
{
    public interface IProductBusiness
    {
        List<ProductModel> GetAllProducts();
        Product CreateProduct(ProductModel product);
    }
}
