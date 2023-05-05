using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstEFCoreConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class AddProlophicKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProliphicAuthors",
                columns: table => new
                {
                    ProliphicAuthorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    BookCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProliphicAuthors", x => x.ProliphicAuthorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProliphicAuthors");
        }
    }
}
