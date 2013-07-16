namespace Besnik.GenericRepository.Tests.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class EntityFrameworkMigrationConfiguration : DbMigrationsConfiguration<Besnik.GenericRepository.Tests.Mocks.EntityFramework.EntityFrameworkCustomerDbContext>
    {
        public EntityFrameworkMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Besnik.GenericRepository.Tests.Mocks.EntityFramework.EntityFrameworkCustomerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
