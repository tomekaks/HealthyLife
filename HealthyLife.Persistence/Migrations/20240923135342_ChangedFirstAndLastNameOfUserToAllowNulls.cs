using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangedFirstAndLastNameOfUserToAllowNulls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a61b511-d291-45ab-ae16-ad6245e93e81", "AQAAAAIAAYagAAAAELAru6tVzsNIpw0lwGKxYvIlnFCJamWm0d11ascOqaYrNM3OMDXAKwwB0MI3Fk6FPA==", "de8c9045-28bb-449e-aeb3-c5648fbdf2c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c750ef4e-fa03-40e8-9ac4-3ecf17910608", "AQAAAAIAAYagAAAAEAhXmm5yy4yPIyzkWsauv8sZNMJs0n5M5htmYL1Nh59SkTkTL1Yl+vo+hKrJQCIPmQ==", "11d9523c-e94f-4fd2-968a-e4ea70c3bbe4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
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
                values: new object[] { "448e4f0b-ba69-453f-bd73-c430a972e11c", "AQAAAAIAAYagAAAAEDTpAbAjpeodDx7FKXSAiYHIxBg1iBwRxONgEdzvfp/U1NBL/kYyteAEA91hb1lkHQ==", "e0b65bf0-7397-407a-8095-4412e649db27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cdf13a4-7f0b-4459-8677-2d9b4d549594", "AQAAAAIAAYagAAAAEBhX11H2LnpnY8/PTIk6A0V7Uk1hcZEErwYrfkI3fXPA9lSrUb77cm2JiTBkc/UQ4A==", "2744e236-52da-4759-8de8-a81cb1a4b815" });
        }
    }
}
