﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthyLife.Persistence.Database.Configurations.Identity
{
    internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole()
                {
                    Id = "abebd04b-4c91-40ca-a99e-8577ff0f262e",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole()
                {
                    Id = "ee6ef51f-eaf9-406e-863e-b8012bd7045a",
                    Name = "User",
                    NormalizedName = "USER"
                });
        }
    }
}
