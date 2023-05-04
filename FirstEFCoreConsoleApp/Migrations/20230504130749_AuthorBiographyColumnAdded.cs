using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstEFCoreConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class AuthorBiographyColumnAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Authors");
        }
    }
}
