using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class FK_Aperture1y2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ApertureOneId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddColumn<Guid>(
                name: "ApertureTwoId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));


            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_ApertureOneId",
                table: "InternalVersionSegmentations",
                column: "ApertureOneId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_ApertureTwoId",
                table: "InternalVersionSegmentations",
                column: "ApertureTwoId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_AperturesOne_ApertureOneId",
                table: "InternalVersionSegmentations",
                column: "ApertureOneId",
                principalTable: "AperturesOne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_AperturesTwo_ApertureTwoId",
                table: "InternalVersionSegmentations",
                column: "ApertureTwoId",
                principalTable: "AperturesTwo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_AperturesOne_ApertureOneId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_AperturesTwo_ApertureTwoId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_ApertureOneId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_ApertureTwoId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "ApertureOneId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "ApertureTwoId",
                table: "InternalVersionSegmentations");
        }
    }
}
