using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class FileIdInOdsOwners : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FileId",
                table: "SpecialSales",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FileId",
                table: "OdsOwnerClassifications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SpecialSales_FileId",
                table: "SpecialSales",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsOwnerClassifications_FileId",
                table: "OdsOwnerClassifications",
                column: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_OdsOwnerClassifications_Files_FileId",
                table: "OdsOwnerClassifications",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecialSales_Files_FileId",
                table: "SpecialSales",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OdsOwnerClassifications_Files_FileId",
                table: "OdsOwnerClassifications");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecialSales_Files_FileId",
                table: "SpecialSales");

            migrationBuilder.DropIndex(
                name: "IX_SpecialSales_FileId",
                table: "SpecialSales");

            migrationBuilder.DropIndex(
                name: "IX_OdsOwnerClassifications_FileId",
                table: "OdsOwnerClassifications");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "SpecialSales");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "OdsOwnerClassifications");
        }
    }
}
