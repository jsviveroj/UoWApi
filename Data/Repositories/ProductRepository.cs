using Data.Contracts;
using Data.Entities;
using Data.Infrastructure;
using Data.Infrastructure.Contract;

namespace Data.Repositories
{
    public class ProductRepository : BaseRepository<Product> , IProductRepository
    {
        public ProductRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
