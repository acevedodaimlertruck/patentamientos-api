using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class ModifyInternalVersionSegmentationv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_InternalVersions_InternalVersionId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_InternalVersionId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "InternalVersionId",
                table: "InternalVersionSegmentations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "InternalVersionId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "InternalVersionId",
                value: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_InternalVersionId",
                table: "InternalVersionSegmentations",
                column: "InternalVersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_InternalVersions_InternalVersionId",
                table: "InternalVersionSegmentations",
                column: "InternalVersionId",
                principalTable: "InternalVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
