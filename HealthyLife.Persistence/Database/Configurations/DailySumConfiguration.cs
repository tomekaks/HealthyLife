using HealthyLife.Application.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations
{
    class DailySumConfiguration : IEntityTypeConfiguration<DailySum>
    {
        public void Configure(EntityTypeBuilder<DailySum> builder)
        {
            builder.Property(d => d.Date)
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasIndex(d => new { d.UserId, d.Date })
                   .IsUnique();

            builder.HasMany(d => d.Meals)
                   .WithOne(m => m.DailySum);

            builder.HasMany(d => d.Workouts)
                   .WithOne(w => w.DailySum);

            builder.HasOne(d => d.User)
                   .WithMany(u => u.DailySums)
                   .HasForeignKey(d => d.UserId);

        }
    }
}
