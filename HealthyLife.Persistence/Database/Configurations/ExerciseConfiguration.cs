using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Persistence.Database.Configurations
{
    internal class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.Property(p => p.Name)
                   .IsRequired();
        }
    }
}
