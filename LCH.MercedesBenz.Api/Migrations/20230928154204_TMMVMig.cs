using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class TMMVMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescripcionMarca",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionModelo",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionTerminal",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionVerInt",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionVerPat",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionVerWs",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VersionInterna",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VersionPatentamiento",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VersionWs",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescripcionMarca",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "DescripcionModelo",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "DescripcionTerminal",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "DescripcionVerInt",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "DescripcionVerPat",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "DescripcionVerWs",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "VersionInterna",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "VersionPatentamiento",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "VersionWs",
                table: "Tmmv");

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
    }
}
