using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Persistence.Database.Configurations
{
    class MyActivityConfiguration : IEntityTypeConfiguration<MyActivity>
    {
        public void Configure(EntityTypeBuilder<MyActivity> builder)
        {
            builder.HasOne(a => a.Exercise)
                   .WithMany()
                   .HasForeignKey(m => m.ExerciseId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
