using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedByPropToSupplementTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Supplements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a77f574-7bfb-46ad-8e92-262326bafa3d", "AQAAAAIAAYagAAAAEPxW8DFiyBCncBSO/4/SK321e4ERiZmV9gc4H8WBh0Qs7a5b7ZcVxBef00hOvRU4Eg==", "d3b032e1-b45f-436b-a06f-5345a8f58a03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50b67f12-189e-4c2c-9345-1cdc54986e55", "AQAAAAIAAYagAAAAEFFQXQQsnoaipVdneJGey69QEOe5LAlOs5a3awqDlZnC59qDOP0hgMFddr5xBxIlPQ==", "e3f68879-9fee-4be4-93c4-2e16f2cf1557" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Supplements");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "653861cf-ba56-446d-a861-c9cd254c8194", "AQAAAAIAAYagAAAAEDCYw4qo26LsxlSaRnJ67JNtMSe4WM1rRjCni2xb3TYwetXf49RqE64ddSRSxyZ5WQ==", "f2b5c021-0f6e-4fa3-88e2-47d9e44078a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93bebaa5-5ef4-430b-bfa0-eff11c8b4471", "AQAAAAIAAYagAAAAEFlwTTidb4+gelBqjfWuwjCvGjJzcYAbNhaykRX5lwvy0H6IDdrhv9k1gzAu9+Q+fw==", "82e96289-cd5a-4e4b-9b30-46ae937166d6" });
        }
    }
}
