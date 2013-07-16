using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Besnik.Domain.EntityFramework;

namespace Besnik.GenericRepository.Tests.Mocks.EntityFramework
{
    class EntityFrameworkCustomerDbContext : DbContext
    {
        public EntityFrameworkCustomerDbContext()
            : base(ConnectionStringKey)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
        }

        /// <summary>
        /// Gets key in connection strings section used to load connection string from app.config.
        /// </summary>
        public static string ConnectionStringKey
        {
            get
            {
                return "EntityFrameworkConnectionString";
            }
        }
    }
}
