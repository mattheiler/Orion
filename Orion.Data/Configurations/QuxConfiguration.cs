using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Orion.Data.Configurations
{
    internal class QuxConfiguration : IEntityTypeConfiguration<Qux>
    {
        public void Configure(EntityTypeBuilder<Qux> builder)
        {
        }
    }
}