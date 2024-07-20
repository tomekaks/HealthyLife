using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Persistence.Database.Configurations
{
    class MealConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasOne(m => m.Product)
                   .WithMany()
                   .HasForeignKey(m => m.ProductId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.Property(m => m.Date)
                   .IsRequired();

            builder.Property(m => m.UserId)
                   .IsRequired();
        }
    }
}
