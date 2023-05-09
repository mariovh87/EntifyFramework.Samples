using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstEFCoreConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class IndexesAndComputedColums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "Apellido1",
                comment: "Primer apellido en España. Surname en otros paises",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldComment: "Primer apellido en España. Surname en otros paises");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Authors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoadeDate",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "getutcdate()");

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                computedColumnSql: "Name + ' ' + LastName",
                stored: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_AuthorName_LastName",
                table: "Authors",
                columns: new[] { "AuthorName", "LastName" });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_CountryId",
                table: "Authors",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Countries_CountryId",
                table: "Authors",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Countries_CountryId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_AuthorName_LastName",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_CountryId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "LoadeDate",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                comment: "Primer apellido en España. Surname en otros paises",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldDefaultValue: "Apellido1",
                oldComment: "Primer apellido en España. Surname en otros paises");
        }
    }
}
