using Data.Entities;
using DataContracts.Infrastructure;
using System.Data.Entity;

namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _dbContext;

        public UnitOfWork()
        {
            _dbContext = new Context();
        }

        public DbContext Db
        {
            get { return _dbContext; }
        }

        public void Dispose()
        {
        }
    }
}
