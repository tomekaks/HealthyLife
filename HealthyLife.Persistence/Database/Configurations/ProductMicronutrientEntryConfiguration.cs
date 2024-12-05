using HealthyLife.Application.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations
{
    internal class ProductMicronutrientEntryConfiguration : IEntityTypeConfiguration<ProductMicronutrientEntry>
    {
        public void Configure(EntityTypeBuilder<ProductMicronutrientEntry> builder)
        {
            builder.HasOne(me => me.Micronutrient)
                    .WithMany()
                    .HasForeignKey(me => me.MicronutrientId);

            builder.HasOne(me => me.Product)
                    .WithMany(p => p.Micronutrients)
                    .HasForeignKey(me => me.ProductId);
        }
    }
}
