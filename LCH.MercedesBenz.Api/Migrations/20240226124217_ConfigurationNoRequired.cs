using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class ConfigurationNoRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Configurations_ConfigurationId",
                table: "InternalVersionSegmentations");

            migrationBuilder.AlterColumn<Guid>(
                name: "ConfigurationId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

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

            migrationBuilder.AlterColumn<Guid>(
                name: "ConfigurationId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Configurations_ConfigurationId",
                table: "InternalVersionSegmentations",
                column: "ConfigurationId",
                principalTable: "Configurations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
