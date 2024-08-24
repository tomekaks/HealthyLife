using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f5c369f-1ef7-4650-ae50-164c174ddaf5", "AQAAAAIAAYagAAAAEKYUTGQ9+Jc48DKdCCLsvXdSnxJ+5XEIKpC8DFF8+Jy632yUjc6H2sMGy4ffcBHs8A==", "cf73f5b0-d58d-4370-9ffb-8b04de73de63" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9ef201b2-999c-4161-8f2b-d7994971e5ee", 0, "21b2603a-eac5-4bca-b354-4bf18b4bf15d", new DateOnly(1, 1, 1), "tester@email.com", true, "Test", "User", false, null, "TESTE@EMAIL.COM", "TESTER", "AQAAAAIAAYagAAAAEKWG9ABMPsI18lxs5WkU4mg83zeOTaPtnxXAHIvlb9npWPnhGBI9+qT65nwGs0S9qw==", null, false, "e44c9f11-1438-4cbd-ab12-ccc3d5d7745a", false, "Tester" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ee6ef51f-eaf9-406e-863e-b8012bd7045a", "9ef201b2-999c-4161-8f2b-d7994971e5ee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ee6ef51f-eaf9-406e-863e-b8012bd7045a", "9ef201b2-999c-4161-8f2b-d7994971e5ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89ea16aa-0a64-47f8-b467-0e8575a7594b", "AQAAAAIAAYagAAAAEBxt4kgShz1l4X3J1OmW5ywgyzHbYGaKWHeN7RCRuXjVF32r/GfJj7S5ZA+PkFhaAQ==", "b9e330d0-1e0a-41ae-b3b3-bdb70e78ac78" });
        }
    }
}
