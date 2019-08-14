using AutoMapper;
using Domain;
using Data.Entities;

namespace Business.Mappings
{
    public class ProductMapping
    {
        private IMapper iMapper;
        public ProductMapping()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ProductModel, Product>();
            });
            iMapper = config.CreateMapper();
        }
        public Product CreateMapping(ProductModel productModel)
        {
            var product = iMapper.Map<ProductModel, Product>(productModel);
            return product;
        }
    }
}
