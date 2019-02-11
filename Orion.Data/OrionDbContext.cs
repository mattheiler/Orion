using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Orion.Data
{
    public class OrionDbContext : DbContext
    {
        public OrionDbContext(DbContextOptions<OrionDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Foo> Foo { get; private set; }

        public virtual DbSet<Bar> Bar { get; private set; }

        public virtual DbSet<Baz> Baz { get; private set; }

        public virtual DbSet<Qux> Qux { get; private set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}