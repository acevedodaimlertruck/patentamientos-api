using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class NewOlds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Configurations_ConfigurationId",
                table: "InternalVersionSegmentations");

            migrationBuilder.RenameColumn(
                name: "Wheelbase",
                table: "InternalVersionSegmentations",
                newName: "WheelbaseOLD");

            migrationBuilder.RenameColumn(
                name: "Gears",
                table: "InternalVersionSegmentations",
                newName: "GearsOLD");

            migrationBuilder.RenameColumn(
                name: "AxleBase",
                table: "InternalVersionSegmentations",
                newName: "AxleBaseOLD");

            migrationBuilder.AlterColumn<Guid>(
                name: "ConfigurationId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "ConfigurationId",
                value: new Guid("00000000-0000-0000-0000-000000000033"));

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Configurations_ConfigurationId",
                table: "InternalVersionSegmentations");

            migrationBuilder.RenameColumn(
                name: "WheelbaseOLD",
                table: "InternalVersionSegmentations",
                newName: "Wheelbase");

            migrationBuilder.RenameColumn(
                name: "GearsOLD",
                table: "InternalVersionSegmentations",
                newName: "Gears");

            migrationBuilder.RenameColumn(
                name: "AxleBaseOLD",
                table: "InternalVersionSegmentations",
                newName: "AxleBase");

            migrationBuilder.AlterColumn<Guid>(
                name: "ConfigurationId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "ConfigurationId",
                value: null);

        }
    }
}
