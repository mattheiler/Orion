using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Orion.Data.Configurations
{
    internal class BazQuxConfiguration : IEntityTypeConfiguration<BazQux>
    {
        public void Configure(EntityTypeBuilder<BazQux> builder)
        {
            builder.HasKey(entity => new { entity.BazId, entity.QuxId });
        }
    }
}