using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyLife.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedMealItemModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Products_ProductId",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_ProductId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Meals");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Meals",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "MealItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<double>(type: "float", nullable: false),
                    Proteins = table.Column<double>(type: "float", nullable: false),
                    Carbs = table.Column<double>(type: "float", nullable: false),
                    Fats = table.Column<double>(type: "float", nullable: false),
                    Fiber = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealItems_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MealItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89ea16aa-0a64-47f8-b467-0e8575a7594b", "AQAAAAIAAYagAAAAEBxt4kgShz1l4X3J1OmW5ywgyzHbYGaKWHeN7RCRuXjVF32r/GfJj7S5ZA+PkFhaAQ==", "b9e330d0-1e0a-41ae-b3b3-bdb70e78ac78" });

            migrationBuilder.CreateIndex(
                name: "IX_MealItems_MealId",
                table: "MealItems",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_MealItems_ProductId",
                table: "MealItems",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealItems");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Meals");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a004b5f8-5c79-4770-873c-7c357921bdeb", "AQAAAAIAAYagAAAAEDKtODxhl9zPpIeWL5n+HCtwCU9vWa2PKEpse9dMUMZtmchrGCzCIkvPOPJGoEgXeg==", "c46201f9-5407-4316-8185-b22320fcfd75" });

            migrationBuilder.CreateIndex(
                name: "IX_Meals_ProductId",
                table: "Meals",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Products_ProductId",
                table: "Meals",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
