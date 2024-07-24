using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Persistence.Database.Configurations
{
    internal class DailyGoalConfiguration : IEntityTypeConfiguration<DailyGoal>
    {
        public void Configure(EntityTypeBuilder<DailyGoal> builder)
        {
            builder.HasOne(d => d.User)
                .WithOne(u => u.DailyGoal);
        }
    }
}
