using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class add_fields_ofmm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "Ofmm",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CarModelId",
                table: "Ofmm",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FactoryId",
                table: "Ofmm",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Ofmm_BrandId",
                table: "Ofmm",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Ofmm_CarModelId",
                table: "Ofmm",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Ofmm_FactoryId",
                table: "Ofmm",
                column: "FactoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ofmm_Brands_BrandId",
                table: "Ofmm",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ofmm_CarModels_CarModelId",
                table: "Ofmm",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ofmm_Factories_FactoryId",
                table: "Ofmm",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ofmm_Brands_BrandId",
                table: "Ofmm");

            migrationBuilder.DropForeignKey(
                name: "FK_Ofmm_CarModels_CarModelId",
                table: "Ofmm");

            migrationBuilder.DropForeignKey(
                name: "FK_Ofmm_Factories_FactoryId",
                table: "Ofmm");

            migrationBuilder.DropIndex(
                name: "IX_Ofmm_BrandId",
                table: "Ofmm");

            migrationBuilder.DropIndex(
                name: "IX_Ofmm_CarModelId",
                table: "Ofmm");

            migrationBuilder.DropIndex(
                name: "IX_Ofmm_FactoryId",
                table: "Ofmm");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Ofmm");

            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "Ofmm");

            migrationBuilder.DropColumn(
                name: "FactoryId",
                table: "Ofmm");
        }
    }
}
