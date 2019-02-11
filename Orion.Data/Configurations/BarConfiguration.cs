using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Orion.Data.Configurations
{
    internal class BarConfiguration : IEntityTypeConfiguration<Bar>
    {
        public void Configure(EntityTypeBuilder<Bar> builder)
        {
            // builder.HasMany(entity => entity.Children).WithOne(entity => entity.Parent);
        }
    }
}