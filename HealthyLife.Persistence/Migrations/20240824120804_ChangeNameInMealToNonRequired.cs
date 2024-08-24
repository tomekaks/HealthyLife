using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameInMealToNonRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63c4499f-c23f-43fa-8043-5c7b365eb9a1", "AQAAAAIAAYagAAAAEKUlw9ltcBZxmyT8H2s8LDHpdJoeQxx2zukF6twE9yGuvu5/VjpfSoZBcIWojrO9jQ==", "dc81d3fa-58ad-49a8-95d4-3b63d921102e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb8cce9e-3cc1-486d-b8f1-238cd7814d48", "AQAAAAIAAYagAAAAENiMhtTJyEXwrvetMqQq+H7VuXdydUYm5HYQEkmM1z0pSlB6/xK1Q6syby5D10il3Q==", "b410d804-e0bc-4e05-abba-46f6914fcfeb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
