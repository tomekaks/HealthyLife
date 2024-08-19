using HealthyLife.Application.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations
{
    class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder.HasOne(w => w.Exercise)
                   .WithMany()
                   .HasForeignKey(w => w.ExerciseId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(w => w.DailySum)
                   .WithMany(d => d.Workouts)
                   .HasForeignKey(w => w.DailySumId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
