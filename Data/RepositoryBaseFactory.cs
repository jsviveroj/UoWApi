using DataContracts.Contracts;
using DataContracts.Infrastructure;
using Unity;


namespace Data
{
    public class RepositoryBaseFactory : IRepositoryBaseFactory
    {
        private readonly IUnityContainer _container;
        public RepositoryBaseFactory(IUnityContainer container)
        {
            _container = container;
        }

        T IRepositoryBaseFactory.GetDataRepository<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
