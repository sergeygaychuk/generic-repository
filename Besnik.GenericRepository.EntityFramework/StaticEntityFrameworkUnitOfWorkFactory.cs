using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Besnik.GenericRepository.EntityFramework
{
    public class StaticEntityFrameworkUnitOfWorkFactory<TContext> : EntityFrameworkUnitOfWorkFactory where TContext : DbContext, new()
    {
        protected override DbContext CreateDbContext()
        {
            return new TContext();
        }

        public override void Dispose()
        {
        }
    }
}
