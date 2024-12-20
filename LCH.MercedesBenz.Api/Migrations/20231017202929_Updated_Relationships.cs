using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class Updated_Relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersions_Brands_BrandId",
                table: "InternalVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersions_Terminals_TerminalId",
                table: "InternalVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_Ofmm_Brands_BrandId",
                table: "Ofmm");

            migrationBuilder.DropForeignKey(
                name: "FK_Patentings_Brands_BrandId",
                table: "Patentings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tmmv_Brands_BrandId",
                table: "Tmmv");

            migrationBuilder.DropForeignKey(
                name: "FK_Tmmv_Terminals_TerminalId",
                table: "Tmmv");

            migrationBuilder.DropIndex(
                name: "IX_Tmmv_BrandId",
                table: "Tmmv");

            migrationBuilder.DropIndex(
                name: "IX_Tmmv_TerminalId",
                table: "Tmmv");

            migrationBuilder.DropIndex(
                name: "IX_Patentings_BrandId",
                table: "Patentings");

            migrationBuilder.DropIndex(
                name: "IX_Ofmm_BrandId",
                table: "Ofmm");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersions_BrandId",
                table: "InternalVersions");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersions_TerminalId",
                table: "InternalVersions");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "TerminalId",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Ofmm");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "InternalVersions");

            migrationBuilder.DropColumn(
                name: "TerminalId",
                table: "InternalVersions");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "CarModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddColumn<Guid>(
                name: "TerminalId",
                table: "Brands",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "TerminalId",
                value: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "BrandId",
                value: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_BrandId",
                table: "CarModels",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_TerminalId",
                table: "Brands",
                column: "TerminalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Terminals_TerminalId",
                table: "Brands",
                column: "TerminalId",
                principalTable: "Terminals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_Brands_BrandId",
                table: "CarModels",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Terminals_TerminalId",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_CarModels_Brands_BrandId",
                table: "CarModels");

            migrationBuilder.DropIndex(
                name: "IX_CarModels_BrandId",
                table: "CarModels");

            migrationBuilder.DropIndex(
                name: "IX_Brands_TerminalId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "TerminalId",
                table: "Brands");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "Tmmv",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TerminalId",
                table: "Tmmv",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "Patentings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "Ofmm",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "InternalVersions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TerminalId",
                table: "InternalVersions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "InternalVersions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "BrandId", "TerminalId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033") });

            migrationBuilder.UpdateData(
                table: "Ofmm",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "BrandId",
                value: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.UpdateData(
                table: "Tmmv",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "BrandId", "TerminalId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033") });

            migrationBuilder.CreateIndex(
                name: "IX_Tmmv_BrandId",
                table: "Tmmv",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Tmmv_TerminalId",
                table: "Tmmv",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_BrandId",
                table: "Patentings",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Ofmm_BrandId",
                table: "Ofmm",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersions_BrandId",
                table: "InternalVersions",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersions_TerminalId",
                table: "InternalVersions",
                column: "TerminalId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersions_Brands_BrandId",
                table: "InternalVersions",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersions_Terminals_TerminalId",
                table: "InternalVersions",
                column: "TerminalId",
                principalTable: "Terminals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ofmm_Brands_BrandId",
                table: "Ofmm",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patentings_Brands_BrandId",
                table: "Patentings",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tmmv_Brands_BrandId",
                table: "Tmmv",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tmmv_Terminals_TerminalId",
                table: "Tmmv",
                column: "TerminalId",
                principalTable: "Terminals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
