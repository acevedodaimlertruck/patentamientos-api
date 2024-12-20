using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class Apertura1y2OLD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apertura2",
                table: "InternalVersionSegmentations",
                newName: "Apertura2OLD");

            migrationBuilder.RenameColumn(
                name: "Apertura1",
                table: "InternalVersionSegmentations",
                newName: "Apertura1OLD");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apertura2OLD",
                table: "InternalVersionSegmentations",
                newName: "Apertura2");

            migrationBuilder.RenameColumn(
                name: "Apertura1OLD",
                table: "InternalVersionSegmentations",
                newName: "Apertura1");
        }
    }
}
