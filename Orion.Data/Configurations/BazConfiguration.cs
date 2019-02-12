using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orion.Entities;

namespace Orion.Data.Configurations
{
    internal class BazConfiguration : IEntityTypeConfiguration<Baz>
    {
        public void Configure(EntityTypeBuilder<Baz> builder)
        {
            builder.HasKey(entity => entity.BarId);
        }
    }
}