using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedMicronutrients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyRecommendedIntake",
                table: "Micronutrients");

            migrationBuilder.DropColumn(
                name: "IntakeUnit",
                table: "Micronutrients");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "SupplementMicronutrientEntries",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "ProductMicronutrientEntries",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "DailyIntakeLimitMg",
                table: "Micronutrients",
                type: "decimal(10,5)",
                precision: 10,
                scale: 5,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DailyRecommendedIntakeMg",
                table: "Micronutrients",
                type: "decimal(10,5)",
                precision: 10,
                scale: 5,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca34628c-22a2-4533-a21a-d6827a315bb6", "AQAAAAIAAYagAAAAEERhOw8/+DC3o7d3BjOr1z8qRBPGqzHRzsb7DoZXid0dYTMsNM+Ur9mOXF/W6KJgFQ==", "7a8a344d-fc79-4fbc-8b2a-4f4b188e321f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43dabcd4-cbfd-4356-b268-7aa706cdb665", "AQAAAAIAAYagAAAAEMubiJpToYOlpVIXYHYrTi2BOHcrfEIoulU/HKEHiKjIvgMtAYiajMq4446JpTdsBA==", "52cf7292-42e5-4658-899d-47a7aea97513" });

            migrationBuilder.InsertData(
                table: "Micronutrients",
                columns: new[] { "Id", "DailyIntakeLimitMg", "DailyRecommendedIntakeMg", "Name" },
                values: new object[,]
                {
                    { 1, 3m, 0.9m, "Vitamin A" },
                    { 2, null, 1.2m, "Vitamin B1" },
                    { 3, null, 1.3m, "Vitamin B2" },
                    { 4, 35m, 16m, "Vitamin B3" },
                    { 5, null, 5m, "Vitamin B5" },
                    { 6, 100m, 1.3m, "Vitamin B6" },
                    { 7, null, 0.03m, "Vitamin B7" },
                    { 8, 1m, 0.4m, "Vitamin B9" },
                    { 9, null, 0.0024m, "Vitamin B12" },
                    { 10, 2m, 0.09m, "Vitamin C" },
                    { 11, 3.5m, 0.55m, "Choline" },
                    { 12, 0.1m, 0.015m, "Vitamin D" },
                    { 13, 1m, 0.015m, "Vitamin E" },
                    { 14, null, 0.12m, "Vitamin K" },
                    { 15, 2500m, 1000m, "Calcium" },
                    { 16, null, 2300m, "Chloride" },
                    { 17, null, 0.035m, "Chromium" },
                    { 18, 10m, 0.9m, "Copper" },
                    { 19, 10m, 4m, "Fluoride" },
                    { 20, 1.1m, 0.15m, "Iodine" },
                    { 21, 45m, 8m, "Iron" },
                    { 22, 400m, 400m, "Magnesium" },
                    { 23, 11m, 2.3m, "Manganese" },
                    { 24, 4000m, 700m, "Phosphorus" },
                    { 25, null, 3000m, "Potassium" },
                    { 26, 0.4m, 0.055m, "Selenium" },
                    { 27, null, 1500m, "Sodium" },
                    { 28, 40m, 11m, "Zinc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Micronutrients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DropColumn(
                name: "DailyIntakeLimitMg",
                table: "Micronutrients");

            migrationBuilder.DropColumn(
                name: "DailyRecommendedIntakeMg",
                table: "Micronutrients");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "SupplementMicronutrientEntries",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "ProductMicronutrientEntries",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "DailyRecommendedIntake",
                table: "Micronutrients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IntakeUnit",
                table: "Micronutrients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84769151-697d-4aba-9918-a6d636a85505", "AQAAAAIAAYagAAAAEEu/0Iod7Gq8V5GfQ4eCstcOXZIXtTHaVLu5KNo/KPo2vSM2vCtVWGayf2e0I3AuFw==", "713fd4ff-0eea-427d-b8c3-9de9d544f586" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef201b2-999c-4161-8f2b-d7994971e5ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd8ae139-b556-4683-b8ed-2413201e296b", "AQAAAAIAAYagAAAAEArgUccya69xau4KvpGyy+7AGAThlcc1GtNwRcujalHSGrYh1WJl7RZy2IN4JwPhVA==", "e068c3ed-c8a2-4fd7-8e26-b61d6686dfd1" });
        }
    }
}
