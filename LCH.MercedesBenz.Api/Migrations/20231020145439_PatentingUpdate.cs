using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class PatentingUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MarcaPat",
                table: "Patentings",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModeloPat",
                table: "Patentings",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TerminalPat",
                table: "Patentings",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarcaPat",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "ModeloPat",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "TerminalPat",
                table: "Patentings");
        }
    }
}
