using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations.Identity
{
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "abebd04b-4c91-40ca-a99e-8577ff0f262e",
                    UserId = "5330c916-053d-41e6-8a44-b9fe25cf27bf"
                });
        }
    }
}
