using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTMMVTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZMarca",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "ZModelo",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "ZTerminal",
                table: "Tmmv");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ZMarca",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZModelo",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZTerminal",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);
        }
    }
}
