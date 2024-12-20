using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class IVS_KV_Out : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeyVersions_InternalVersionSegmentations_InternalVersionSegmentationId",
                table: "KeyVersions");

            migrationBuilder.DropIndex(
                name: "IX_KeyVersions_InternalVersionSegmentationId",
                table: "KeyVersions");

            migrationBuilder.DropColumn(
                name: "InternalVersionSegmentationId",
                table: "KeyVersions");

            migrationBuilder.DropColumn(
                name: "MercedesVersionInternaSegmentacionId",
                table: "KeyVersions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "InternalVersionSegmentationId",
                table: "KeyVersions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "MercedesVersionInternaSegmentacionId",
                table: "KeyVersions",
                type: "varchar(3)",
                unicode: false,
                maxLength: 3,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "KeyVersions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "InternalVersionSegmentationId", "MercedesVersionInternaSegmentacionId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), null });

            migrationBuilder.CreateIndex(
                name: "IX_KeyVersions_InternalVersionSegmentationId",
                table: "KeyVersions",
                column: "InternalVersionSegmentationId");

            migrationBuilder.AddForeignKey(
                name: "FK_KeyVersions_InternalVersionSegmentations_InternalVersionSegmentationId",
                table: "KeyVersions",
                column: "InternalVersionSegmentationId",
                principalTable: "InternalVersionSegmentations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
