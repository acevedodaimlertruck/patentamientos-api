using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class FK_FilesToSegmentationPlates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FileId",
                table: "SegmentationPlates",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SegmentationPlates_FileId",
                table: "SegmentationPlates",
                column: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_SegmentationPlates_Files_FileId",
                table: "SegmentationPlates",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SegmentationPlates_Files_FileId",
                table: "SegmentationPlates");

            migrationBuilder.DropIndex(
                name: "IX_SegmentationPlates_FileId",
                table: "SegmentationPlates");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "SegmentationPlates");
        }
    }
}
