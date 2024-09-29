using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSupplementTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServingForm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServingUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServingSize = table.Column<int>(type: "int", nullable: false),
                    Servings = table.Column<int>(type: "int", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PricePerServing = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplements", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplements");

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
    }
}
