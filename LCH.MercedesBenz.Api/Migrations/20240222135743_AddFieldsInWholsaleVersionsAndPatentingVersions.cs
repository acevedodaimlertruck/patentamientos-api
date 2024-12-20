using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsInWholsaleVersionsAndPatentingVersions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WholesaleVersions",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CarModelId",
                table: "WholesaleVersions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "MercedesMarcaId",
                table: "WholesaleVersions",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MercedesModeloId",
                table: "WholesaleVersions",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MercedesTerminalId",
                table: "WholesaleVersions",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PatentingVersions",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CarModelId",
                table: "PatentingVersions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "MercedesMarcaId",
                table: "PatentingVersions",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MercedesModeloId",
                table: "PatentingVersions",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MercedesTerminalId",
                table: "PatentingVersions",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PatentingVersions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "CarModelId", "MercedesMarcaId", "MercedesModeloId", "MercedesTerminalId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), null, null, null });

            migrationBuilder.UpdateData(
                table: "WholesaleVersions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "CarModelId", "MercedesMarcaId", "MercedesModeloId", "MercedesTerminalId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_WholesaleVersions_CarModelId",
                table: "WholesaleVersions",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PatentingVersions_CarModelId",
                table: "PatentingVersions",
                column: "CarModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatentingVersions_CarModels_CarModelId",
                table: "PatentingVersions",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WholesaleVersions_CarModels_CarModelId",
                table: "WholesaleVersions",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatentingVersions_CarModels_CarModelId",
                table: "PatentingVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_WholesaleVersions_CarModels_CarModelId",
                table: "WholesaleVersions");

            migrationBuilder.DropIndex(
                name: "IX_WholesaleVersions_CarModelId",
                table: "WholesaleVersions");

            migrationBuilder.DropIndex(
                name: "IX_PatentingVersions_CarModelId",
                table: "PatentingVersions");

            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "WholesaleVersions");

            migrationBuilder.DropColumn(
                name: "MercedesMarcaId",
                table: "WholesaleVersions");

            migrationBuilder.DropColumn(
                name: "MercedesModeloId",
                table: "WholesaleVersions");

            migrationBuilder.DropColumn(
                name: "MercedesTerminalId",
                table: "WholesaleVersions");

            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "PatentingVersions");

            migrationBuilder.DropColumn(
                name: "MercedesMarcaId",
                table: "PatentingVersions");

            migrationBuilder.DropColumn(
                name: "MercedesModeloId",
                table: "PatentingVersions");

            migrationBuilder.DropColumn(
                name: "MercedesTerminalId",
                table: "PatentingVersions");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WholesaleVersions",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldUnicode: false,
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PatentingVersions",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldUnicode: false,
                oldMaxLength: 60,
                oldNullable: true);
        }
    }
}
