using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddPositionPropertyToMeal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd8f95e2-23c7-4faa-9964-e6be75153b5a", "AQAAAAIAAYagAAAAEDkE5+OvqxDXEq6g4/htnjlN+4MNvEcgZkAYvW4mgyv1WrHyaU8iwCrrsyYGDWeAwA==", "6ada6740-cfea-4f05-8d9d-e720e949ed79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce54b3c5-e35c-4899-b7b9-3797b65f36a2", "AQAAAAIAAYagAAAAEBkwbaNB8Mf7TxaxK8+G8WDJ6gETPEq3TC+2gV5BkiUTjA8//miJOzj9NAWkssnb3Q==", "648fe000-8540-47a9-9cb7-6683ac5ac50f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Meals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f5c369f-1ef7-4650-ae50-164c174ddaf5", "AQAAAAIAAYagAAAAEKYUTGQ9+Jc48DKdCCLsvXdSnxJ+5XEIKpC8DFF8+Jy632yUjc6H2sMGy4ffcBHs8A==", "cf73f5b0-d58d-4370-9ffb-8b04de73de63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21b2603a-eac5-4bca-b354-4bf18b4bf15d", "AQAAAAIAAYagAAAAEKWG9ABMPsI18lxs5WkU4mg83zeOTaPtnxXAHIvlb9npWPnhGBI9+qT65nwGs0S9qw==", "e44c9f11-1438-4cbd-ab12-ccc3d5d7745a" });
        }
    }
}
