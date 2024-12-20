using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddCat_InternalVersionv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Cat_InternalVersionId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "Cat_InternalVersionId",
                value: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_Cat_InternalVersionId",
                table: "InternalVersionSegmentations",
                column: "Cat_InternalVersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Cat_InternalVersions_Cat_InternalVersionId",
                table: "InternalVersionSegmentations",
                column: "Cat_InternalVersionId",
                principalTable: "Cat_InternalVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Cat_InternalVersions_Cat_InternalVersionId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_Cat_InternalVersionId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "Cat_InternalVersionId",
                table: "InternalVersionSegmentations");
        }
    }
}
