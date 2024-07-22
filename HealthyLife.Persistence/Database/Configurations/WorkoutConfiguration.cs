using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Persistence.Database.Configurations
{
    class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder.HasOne(a => a.Exercise)
                   .WithMany()
                   .HasForeignKey(m => m.ExerciseId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
