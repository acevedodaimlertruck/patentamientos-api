using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnsPatenting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fabrica_D",
                table: "Patentings",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Marca_D",
                table: "Patentings",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modelo_D",
                table: "Patentings",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo_D",
                table: "Patentings",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fabrica_D",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "Marca_D",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "Modelo_D",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "Tipo_D",
                table: "Patentings");
        }
    }
}
