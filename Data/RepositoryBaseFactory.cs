using Data.Contracts;
using Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure.Contract;

namespace Data
{
    public class RepositoryBaseFactory : IRepositoryBaseFactory
    {
        private readonly IUnityContainer _container;
        public RepositoryBaseFactory(IUnityContainer container)
        {
            _container = container;
        }

        public T GetDataRepository<T>() where T : IBaseRepository<T>
        {
            return _container.Resolve<T>();
        }
    }
}
