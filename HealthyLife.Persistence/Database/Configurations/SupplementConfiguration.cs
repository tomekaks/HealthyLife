using HealthyLife.Application.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations
{
    internal class SupplementConfiguration : IEntityTypeConfiguration<Supplement>
    {
        public void Configure(EntityTypeBuilder<Supplement> builder)
        {
            builder.Property(s => s.Name).IsRequired();

            builder.Property(s => s.Category).IsRequired();

            builder.Property(s => s.ServingForm).IsRequired();

            builder.Property(s => s.ServingUnit).IsRequired();
        }
    }
}
