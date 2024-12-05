using HealthyLife.Application.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations
{
    internal class MicronutrientConfiguration : IEntityTypeConfiguration<Micronutrient>
    {
        public void Configure(EntityTypeBuilder<Micronutrient> builder)
        {
            builder.Property(m => m.Name).IsRequired();

            builder.Property(m => m.DailyRecommendedIntakeMg).HasPrecision(10,5);

            builder.Property(m => m.DailyIntakeLimitMg).HasPrecision(10,5);

            builder.HasData(
                new Micronutrient()
                {
                    Id = 1,
                    Name = "Vitamin A",
                    DailyRecommendedIntakeMg = 0.9m,
                    DailyIntakeLimitMg = 3
                },
                new Micronutrient()
                {
                    Id = 2,
                    Name = "Vitamin B1",
                    DailyRecommendedIntakeMg = 1.2m,
                },
                new Micronutrient()
                {
                    Id = 3,
                    Name = "Vitamin B2",
                    DailyRecommendedIntakeMg = 1.3m,
                },
                new Micronutrient()
                {
                    Id = 4,
                    Name = "Vitamin B3",
                    DailyRecommendedIntakeMg = 16,
                    DailyIntakeLimitMg = 35
                },
                new Micronutrient()
                {
                    Id = 5,
                    Name = "Vitamin B5",
                    DailyRecommendedIntakeMg = 5,
                },
                new Micronutrient()
                {
                    Id = 6,
                    Name = "Vitamin B6",
                    DailyRecommendedIntakeMg = 1.3m,
                    DailyIntakeLimitMg = 100
                },
                new Micronutrient()
                {
                    Id = 7,
                    Name = "Vitamin B7",
                    DailyRecommendedIntakeMg = 0.03m
                },
                new Micronutrient()
                {
                    Id = 8,
                    Name = "Vitamin B9",
                    DailyRecommendedIntakeMg = 0.4m,
                    DailyIntakeLimitMg = 1
                },
                new Micronutrient()
                {
                    Id = 9,
                    Name = "Vitamin B12",
                    DailyRecommendedIntakeMg = 0.0024m,
                },
                new Micronutrient()
                {
                    Id = 10,
                    Name = "Vitamin C",
                    DailyRecommendedIntakeMg = 0.09m,
                    DailyIntakeLimitMg = 2
                },
                new Micronutrient()
                {
                    Id = 11,
                    Name = "Choline",
                    DailyRecommendedIntakeMg = 0.55m,
                    DailyIntakeLimitMg = 3.5m
                },
                new Micronutrient()
                {
                    Id = 12,
                    Name = "Vitamin D",
                    DailyRecommendedIntakeMg = 0.015m,
                    DailyIntakeLimitMg = 0.1m
                },
                new Micronutrient()
                {
                    Id = 13,
                    Name = "Vitamin E",
                    DailyRecommendedIntakeMg = 0.015m,
                    DailyIntakeLimitMg = 1
                },
                new Micronutrient()
                {
                    Id = 14,
                    Name = "Vitamin K",
                    DailyRecommendedIntakeMg = 0.12m,
                },
                new Micronutrient()
                {
                    Id = 15,
                    Name = "Calcium",
                    DailyRecommendedIntakeMg = 1000,
                    DailyIntakeLimitMg = 2500
                },
                new Micronutrient()
                {
                    Id = 16,
                    Name = "Chloride",
                    DailyRecommendedIntakeMg = 2300
                },
                new Micronutrient()
                {
                    Id = 17,
                    Name = "Chromium",
                    DailyRecommendedIntakeMg = 0.035m
                },
                new Micronutrient()
                {
                    Id = 18,
                    Name = "Copper",
                    DailyRecommendedIntakeMg = 0.9m,
                    DailyIntakeLimitMg = 10
                },
                new Micronutrient()
                {
                    Id = 19,
                    Name = "Fluoride",
                    DailyRecommendedIntakeMg = 4,
                    DailyIntakeLimitMg = 10
                },
                new Micronutrient()
                {
                    Id = 20,
                    Name = "Iodine",
                    DailyRecommendedIntakeMg = 0.15m,
                    DailyIntakeLimitMg = 1.1m
                },
                new Micronutrient()
                {
                    Id = 21,
                    Name = "Iron",
                    DailyRecommendedIntakeMg = 8,
                    DailyIntakeLimitMg = 45
                },
                new Micronutrient()
                {
                    Id = 22,
                    Name = "Magnesium",
                    DailyRecommendedIntakeMg = 400,
                    DailyIntakeLimitMg = 400
                },
                new Micronutrient()
                {
                    Id = 23,
                    Name = "Manganese",
                    DailyRecommendedIntakeMg = 2.3m,
                    DailyIntakeLimitMg = 11
                },
                new Micronutrient()
                {
                    Id = 24,
                    Name = "Phosphorus",
                    DailyRecommendedIntakeMg = 700,
                    DailyIntakeLimitMg = 4000
                },
                new Micronutrient()
                {
                    Id = 25,
                    Name = "Potassium",
                    DailyRecommendedIntakeMg = 3000
                },
                new Micronutrient()
                {
                    Id = 26,
                    Name = "Selenium",
                    DailyRecommendedIntakeMg = 0.055m,
                    DailyIntakeLimitMg = 0.4m
                },
                new Micronutrient()
                {
                    Id = 27,
                    Name = "Sodium",
                    DailyRecommendedIntakeMg = 1500
                },
                new Micronutrient()
                {
                    Id = 28,
                    Name = "Zinc",
                    DailyRecommendedIntakeMg = 11,
                    DailyIntakeLimitMg = 40
                }
                );
        }
    }
}
