using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePatentingDto5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factories_Provinces_ProvinceId",
                table: "Factories");

            migrationBuilder.DropForeignKey(
                name: "FK_Patentings_Terminals_TerminalId",
                table: "Patentings");

            migrationBuilder.DropIndex(
                name: "IX_Patentings_TerminalId",
                table: "Patentings");

            migrationBuilder.DropIndex(
                name: "IX_Factories_ProvinceId",
                table: "Factories");

            migrationBuilder.DropColumn(
                name: "TerminalId",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Factories");

            migrationBuilder.RenameColumn(
                name: "CUIT_PREF",
                table: "Owners",
                newName: "CuitPref");

            migrationBuilder.AddColumn<string>(
                name: "Anio",
                table: "Patentings",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Auto",
                table: "Patentings",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CalDay",
                table: "Patentings",
                type: "varchar(2)",
                unicode: false,
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CalMonth",
                table: "Patentings",
                type: "varchar(2)",
                unicode: false,
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CalYear",
                table: "Patentings",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CantPatentamiento",
                table: "Patentings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CodigoPostal",
                table: "Patentings",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "Patentings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("25d46165-da2e-4127-9239-ac868c1d535d"));

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Patentings",
                type: "varchar(150)",
                unicode: false,
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Es_Duplicado",
                table: "Patentings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FMM_MTM",
                table: "Patentings",
                type: "varchar(9)",
                unicode: false,
                maxLength: 9,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCarga",
                table: "Patentings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "Patentings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e8db5422-48d1-49b2-a4d8-ad000c86d635"));

            migrationBuilder.AddColumn<string>(
                name: "NroRegistro",
                table: "Patentings",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OFMM_ERROR",
                table: "Patentings",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Origen",
                table: "Patentings",
                type: "varchar(1)",
                unicode: false,
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaisFabrica",
                table: "Patentings",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaisProced",
                table: "Patentings",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Peso",
                table: "Patentings",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ProvinceId",
                table: "Patentings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("85926a2c-e316-46ad-acae-fd53124ccb21"));

            migrationBuilder.AddColumn<Guid>(
                name: "RegSecId",
                table: "Patentings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("2bb7b784-0749-4ea5-9247-b8bef1c5dcb2"));

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_DepartmentId",
                table: "Patentings",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_LocationId",
                table: "Patentings",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_ProvinceId",
                table: "Patentings",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_RegSecId",
                table: "Patentings",
                column: "RegSecId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patentings_Departments_DepartmentId",
                table: "Patentings",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patentings_Locations_LocationId",
                table: "Patentings",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patentings_Provinces_ProvinceId",
                table: "Patentings",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patentings_RegSecs_RegSecId",
                table: "Patentings",
                column: "RegSecId",
                principalTable: "RegSecs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patentings_Departments_DepartmentId",
                table: "Patentings");

            migrationBuilder.DropForeignKey(
                name: "FK_Patentings_Locations_LocationId",
                table: "Patentings");

            migrationBuilder.DropForeignKey(
                name: "FK_Patentings_Provinces_ProvinceId",
                table: "Patentings");

            migrationBuilder.DropForeignKey(
                name: "FK_Patentings_RegSecs_RegSecId",
                table: "Patentings");

            migrationBuilder.DropIndex(
                name: "IX_Patentings_DepartmentId",
                table: "Patentings");

            migrationBuilder.DropIndex(
                name: "IX_Patentings_LocationId",
                table: "Patentings");

            migrationBuilder.DropIndex(
                name: "IX_Patentings_ProvinceId",
                table: "Patentings");

            migrationBuilder.DropIndex(
                name: "IX_Patentings_RegSecId",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "Anio",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "Auto",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "CalDay",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "CalMonth",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "CalYear",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "CantPatentamiento",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "CodigoPostal",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "Es_Duplicado",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "FMM_MTM",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "FechaCarga",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "NroRegistro",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "OFMM_ERROR",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "Origen",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "PaisFabrica",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "PaisProced",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Patentings");

            migrationBuilder.DropColumn(
                name: "RegSecId",
                table: "Patentings");

            migrationBuilder.RenameColumn(
                name: "CuitPref",
                table: "Owners",
                newName: "CUIT_PREF");

            migrationBuilder.AddColumn<Guid>(
                name: "TerminalId",
                table: "Patentings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProvinceId",
                table: "Factories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_TerminalId",
                table: "Patentings",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_Factories_ProvinceId",
                table: "Factories",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Factories_Provinces_ProvinceId",
                table: "Factories",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patentings_Terminals_TerminalId",
                table: "Patentings",
                column: "TerminalId",
                principalTable: "Terminals",
                principalColumn: "Id");
        }
    }
}
