using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedRolesAndAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "abebd04b-4c91-40ca-a99e-8577ff0f262e", null, "Administrator", "ADMINISTRATOR" },
                    { "ee6ef51f-eaf9-406e-863e-b8012bd7045a", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5330c916-053d-41e6-8a44-b9fe25cf27bf", 0, "1a4c4dd0-425a-4319-8bb8-4195f7583aea", new DateOnly(1, 1, 1), "admin@email.com", true, "System", "Admin", false, null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEH1S9FTDuSiYl4pUjzIfkFOA92dWLvCQVOpOrz/8ca9Gk80kEcw4Q+MV77lrnXzLtg==", null, false, "b74975f9-9129-48bd-bdde-7eba774bf916", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "abebd04b-4c91-40ca-a99e-8577ff0f262e", "5330c916-053d-41e6-8a44-b9fe25cf27bf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee6ef51f-eaf9-406e-863e-b8012bd7045a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "abebd04b-4c91-40ca-a99e-8577ff0f262e", "5330c916-053d-41e6-8a44-b9fe25cf27bf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abebd04b-4c91-40ca-a99e-8577ff0f262e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf");
        }
    }
}
