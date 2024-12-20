using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class FKFuelType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_FuelTypes_FuelTypeId",
                table: "InternalVersionSegmentations");

            migrationBuilder.AlterColumn<Guid>(
                name: "FuelTypeId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_FuelTypes_FuelTypeId",
                table: "InternalVersionSegmentations",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_FuelTypes_FuelTypeId",
                table: "InternalVersionSegmentations");

            migrationBuilder.AlterColumn<Guid>(
                name: "FuelTypeId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_FuelTypes_FuelTypeId",
                table: "InternalVersionSegmentations",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id");
        }
    }
}
