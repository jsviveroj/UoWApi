using Data.Entities;
using Data.Infrastructure.Contract;
using System.Data.Entity;

namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UowTestEntities _dbContext;

        public UnitOfWork()
        {
            _dbContext = new UowTestEntities();
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
