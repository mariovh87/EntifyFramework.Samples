using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFramework.Samples.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "1234 Main St", null, "Carson", "Alexander", "555-555-5555" },
                    { 2, "1234 Main St", null, "Meredith", "Alonso", "555-555-5555" },
                    { 3, "1234 Main St", null, "Arturo", "Anand", "555-555-5555" },
                    { 4, "1234 Main St", null, "Gytis", "Barzdukas", "555-555-5555" },
                    { 5, "1234 Main St", null, "Yan", "Li", "555-555-5555" },
                    { 6, "1234 Main St", null, "Peggy", "Justice", "555-555-5555" },
                    { 7, "1234 Main St", null, "Laura", "Norman", "555-555-5555" },
                    { 8, "1234 Main St", null, "Nino", "Olivetto", "555-555-5555" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Pizza Margherita", 10.00m },
                    { 2, "Pizza Marinara", 10.00m },
                    { 3, "Pizza Quattro Stagioni", 10.00m },
                    { 4, "Pizza Quattro Formaggi", 10.00m },
                    { 5, "Pizza Capricciosa", 10.00m },
                    { 6, "Pizza Funghi", 12.00m },
                    { 7, "Pizza Prosciutto", 12.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);
        }
    }
}
