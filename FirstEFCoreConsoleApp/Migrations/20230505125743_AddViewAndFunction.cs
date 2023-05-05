using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstEFCoreConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class AddViewAndFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FirstEFCoreConsoleApp.SqlFiles.CreateViewAndFunction.sql");
            using var reader = new BinaryReader(stream);
            var bytes = reader.ReadBytes((int)stream.Length);
            var sql = Encoding.UTF8.GetString(bytes);

            migrationBuilder.Sql(sql);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW dbo.MostHighlyRatedBooks");
            migrationBuilder.Sql("DROP FUNCTION dbo.MostProlificAuthors");

        }
    }
}
