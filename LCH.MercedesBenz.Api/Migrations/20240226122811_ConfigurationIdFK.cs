using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class ConfigurationIdFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Configurations_ConfigurationId",
                table: "InternalVersionSegmentations",
                column: "ConfigurationId",
                principalTable: "Configurations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Configurations_ConfigurationId",
                table: "InternalVersionSegmentations");
        }
    }
}
