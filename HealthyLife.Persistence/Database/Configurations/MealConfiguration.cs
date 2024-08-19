using HealthyLife.Application.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations
{
    class MealConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasOne(m => m.DailySum)
                .WithMany(d => d.Meals)
                .HasForeignKey(m => m.DailySumId);

            builder.HasMany(m => m.MealItems)
                .WithOne(mi => mi.Meal)
                .HasForeignKey(mi => mi.MealId);
        }
    }
}
