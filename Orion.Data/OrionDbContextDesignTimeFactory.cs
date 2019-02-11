using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Orion.Data
{
    public class OrionDbContextDesignTimeFactory : IDesignTimeDbContextFactory<OrionDbContext>
    {
        public OrionDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<OrionDbContext>();

            options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Orion;Integrated Security=True");

            return new OrionDbContext(options.Options);
        }
    }
}