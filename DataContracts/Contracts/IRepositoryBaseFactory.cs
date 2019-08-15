using DataContracts.Infrastructure;

namespace DataContracts.Contracts
{
    public interface IRepositoryBaseFactory
    {
        T GetDataRepository<T>() where T : IBaseRepository;
    }
}
