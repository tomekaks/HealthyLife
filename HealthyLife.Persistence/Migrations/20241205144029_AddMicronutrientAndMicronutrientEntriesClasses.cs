using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddMicronutrientAndMicronutrientEntriesClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Micronutrients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntakeUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyRecommendedIntake = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Micronutrients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductMicronutrientEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MicronutrientId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMicronutrientEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMicronutrientEntries_Micronutrients_MicronutrientId",
                        column: x => x.MicronutrientId,
                        principalTable: "Micronutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMicronutrientEntries_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplementMicronutrientEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MicronutrientId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    SuppelementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplementMicronutrientEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplementMicronutrientEntries_Micronutrients_MicronutrientId",
                        column: x => x.MicronutrientId,
                        principalTable: "Micronutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplementMicronutrientEntries_Supplements_SuppelementId",
                        column: x => x.SuppelementId,
                        principalTable: "Supplements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductMicronutrientEntries_MicronutrientId",
                table: "ProductMicronutrientEntries",
                column: "MicronutrientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMicronutrientEntries_ProductId",
                table: "ProductMicronutrientEntries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplementMicronutrientEntries_MicronutrientId",
                table: "SupplementMicronutrientEntries",
                column: "MicronutrientId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplementMicronutrientEntries_SuppelementId",
                table: "SupplementMicronutrientEntries",
                column: "SuppelementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductMicronutrientEntries");

            migrationBuilder.DropTable(
                name: "SupplementMicronutrientEntries");

            migrationBuilder.DropTable(
                name: "Micronutrients");

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
    }
}
