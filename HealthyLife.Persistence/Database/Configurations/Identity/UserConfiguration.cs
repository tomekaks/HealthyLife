using HealthyLife.Application.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations.Identity
{
    internal class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(u => u.DailySums)
                .WithOne(d => d.User);

            builder.HasOne(u => u.DailyGoal)
                .WithOne(d => d.User);

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser()
                {
                    Id = "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                    Email = "admin@email.com",
                    NormalizedEmail = "ADMIN@EMAIL.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "Password!23"),
                    EmailConfirmed = true
                },
                new ApplicationUser()
                {
                    Id = "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                    Email = "tester@email.com",
                    NormalizedEmail = "TESTE@EMAIL.COM",
                    FirstName = "Test",
                    LastName = "User",
                    UserName = "Tester",
                    NormalizedUserName = "TESTER",
                    PasswordHash = hasher.HashPassword(null, "Password!23"),
                    EmailConfirmed = true
                });
        }
    }
}
