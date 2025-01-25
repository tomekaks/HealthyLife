using HealthyLife.Application.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace HealthyLife.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<DailySum> DailySums { get; set; }
        DbSet<Meal> Meals { get; set; }
        DbSet<MealItem> MealItems { get; set; }
        DbSet<DailyGoal> DailyGoals { get; set; }
        DbSet<Workout> Workouts { get; set; }
        DbSet<Exercise> Exercises { get; set; }
        DbSet<Supplement> Supplements { get; set; }
        DbSet<Micronutrient> Micronutrients { get; set; }
        DbSet<ProductMicronutrientEntry> ProductMicronutrientEntries { get; set; }
        DbSet<SupplementMicronutrientEntry> SupplementMicronutrientEntries { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
