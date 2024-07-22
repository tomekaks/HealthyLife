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

            builder.HasOne(m => m.DailySum)
                .WithMany(d => d.Meals)
                .HasForeignKey(m => m.DailySumId);
        }
    }
}
