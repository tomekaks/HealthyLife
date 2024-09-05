using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdDateConstraintToDailySum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DailySums_UserId",
                table: "DailySums");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "448e4f0b-ba69-453f-bd73-c430a972e11c", "AQAAAAIAAYagAAAAEDTpAbAjpeodDx7FKXSAiYHIxBg1iBwRxONgEdzvfp/U1NBL/kYyteAEA91hb1lkHQ==", "e0b65bf0-7397-407a-8095-4412e649db27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cdf13a4-7f0b-4459-8677-2d9b4d549594", "AQAAAAIAAYagAAAAEBhX11H2LnpnY8/PTIk6A0V7Uk1hcZEErwYrfkI3fXPA9lSrUb77cm2JiTBkc/UQ4A==", "2744e236-52da-4759-8de8-a81cb1a4b815" });

            migrationBuilder.CreateIndex(
                name: "IX_DailySums_UserId_Date",
                table: "DailySums",
                columns: new[] { "UserId", "Date" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DailySums_UserId_Date",
                table: "DailySums");

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

            migrationBuilder.CreateIndex(
                name: "IX_DailySums_UserId",
                table: "DailySums",
                column: "UserId");
        }
    }
}
