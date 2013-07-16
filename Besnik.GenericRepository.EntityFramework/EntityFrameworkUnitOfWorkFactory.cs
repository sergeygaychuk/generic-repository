using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Besnik.GenericRepository.EntityFramework
{
    /// <summary>
    /// Unit of work factory implementation for Entity Framework.
    /// Note: implementation based on extension Feature CTP4.
    /// </summary>
    public abstract class EntityFrameworkUnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork BeginUnitOfWork()
        {
			return new EntityFrameworkUnitOfWork(
				this.CreateDbContext()
				);
        }

        public void EndUnitOfWork(IUnitOfWork unitOfWork)
        {
			var linqToSqlUnitOfWork = unitOfWork as EntityFrameworkUnitOfWork;
			if (linqToSqlUnitOfWork != null)
			{
				linqToSqlUnitOfWork.Dispose();
				linqToSqlUnitOfWork = null;
			}
        }

        protected abstract DbContext CreateDbContext();
        public abstract void Dispose();
    }
}
