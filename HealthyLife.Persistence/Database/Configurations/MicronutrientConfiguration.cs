using HealthyLife.Application.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations
{
    internal class MicronutrientConfiguration : IEntityTypeConfiguration<Micronutrient>
    {
        public void Configure(EntityTypeBuilder<Micronutrient> builder)
        {
            builder.Property(m => m.Name).IsRequired();

            builder.Property(m => m.IntakeUnit).IsRequired();
        }
    }
}
