using HealthyLife.Application.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations
{
    internal class SupplementMicronutrientEntryConfiguration : IEntityTypeConfiguration<SupplementMicronutrientEntry>
    {
        public void Configure(EntityTypeBuilder<SupplementMicronutrientEntry> builder)
        {
            builder.HasOne(me => me.Micronutrient)
                    .WithMany()
                    .HasForeignKey(me => me.MicronutrientId);

            builder.HasOne(me => me.Supplement)
                    .WithMany(p => p.Micronutrients)
                    .HasForeignKey(me => me.SuppelementId);
        }
    }
}
