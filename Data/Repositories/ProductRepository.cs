using Data.Infrastructure;
using DataContracts.Contracts;
using DataContracts.Infrastructure;
using Domain;

namespace Data.Repositories
{
    public class ProductRepository : BaseRepository<Product> , IProductRepository
    {
        public ProductRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
