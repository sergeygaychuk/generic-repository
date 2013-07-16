using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace Besnik.GenericRepository.EntityFramework
{
    public class DynamicEntityFrameworkUnitOfWorkFactory : EntityFrameworkUnitOfWorkFactory
    {
        public DynamicEntityFrameworkUnitOfWorkFactory(string connectionString, DbModel dbModel)
        {
            this.ConnectionString = connectionString;
			this.DbModel = dbModel;
        }

        protected string ConnectionString { get; private set; }

		protected DbModel DbModel { get; private set; }


        public override void Dispose()
        {
            this.ConnectionString = null;
            this.DbModel = null;
        }

        protected override DbContext CreateDbContext()
        {
            return new DbContext(
                this.ConnectionString
                , this.DbModel.Compile()
                );
        }
    }
}
