using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class SpecialSalesCatalogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AperturesOne",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesApertureOne = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionShort = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DescriptionLong = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AperturesOne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AperturesTwo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesApertureTwo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionShort = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DescriptionLong = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AperturesTwo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuitClassifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesCuitClassification = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    DescriptionShort = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DescriptionLong = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuitClassifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstimatedTurnovers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesEstimatedTurnover = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionShort = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DescriptionLong = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimatedTurnovers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GovernmentalClassifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesGovernmentalClassification = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    DescriptionShort = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DescriptionLong = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GovernmentalClassifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LegalEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesLegalEntity = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionShort = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DescriptionLong = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogisticClassifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesLogisticClassification = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionShort = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DescriptionLong = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticClassifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialSales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    CuitOwner = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Owner = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: false),
                    LegalEntity = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionLegalEntity = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    GovernmentalClassification = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    DescriptionGovernmentalClassification = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SubgovernmentalClassification = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionSubgovernmentalClassification = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    CuitClassification = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    DescriptionCuitClassification = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Aperture1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionAperture1 = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Aperture2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionAperture2 = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    LogisticClassification = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionLogisticClassification = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    EstimatedTurnover = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionEstimatedTurnover = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SocialContractDate = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    EmployeesInfo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialSales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubgovernmentalClassifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesSubgovernmentalClassification = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DescriptionShort = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DescriptionLong = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubgovernmentalClassifications", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AperturesOne",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescriptionLong", "DescriptionShort", "IsDeleted", "MercedesApertureOne", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, "Banco", "Banco", false, "001", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, null, null, null, "Leasing", "Leasing", false, "002", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", "NOASIGNADO", false, "999", null, null }
                });

            migrationBuilder.InsertData(
                table: "AperturesTwo",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescriptionLong", "DescriptionShort", "IsDeleted", "MercedesApertureTwo", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, "Automotriz", "Automotriz", false, "001", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", "NOASIGNADO", false, "999", null, null }
                });

            migrationBuilder.InsertData(
                table: "CuitClassifications",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescriptionLong", "DescriptionShort", "IsDeleted", "MercedesCuitClassification", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, "Entidad Financiera", "Entidad Financiera", false, "EF", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", "NOASIGNADO", false, "NO", null, null }
                });

            migrationBuilder.InsertData(
                table: "EstimatedTurnovers",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescriptionLong", "DescriptionShort", "IsDeleted", "MercedesEstimatedTurnover", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, "< $500.000", "< $500.000", false, "1", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, null, null, null, "$500.000 ~ $1.000.000", "$500.000~ $1.000.000", false, "2", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 0, null, null, null, null, "$1.000.000 ~ $5.000.000", "$1000000 ~ $5000000", false, "3", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 0, null, null, null, null, "$5.000.000 ~ $20.000.000", "$5000000 ~ $20000000", false, "4", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), 0, null, null, null, null, "$20.000.000 ~ $100.000.000", "$20000000~$100000000", false, "5", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), 0, null, null, null, null, "> $100.000.000", "> $100.000.000", false, "6", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", "NOASIGNADO", false, "999", null, null }
                });

            migrationBuilder.InsertData(
                table: "GovernmentalClassifications",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescriptionLong", "DescriptionShort", "IsDeleted", "MercedesGovernmentalClassification", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, "Entidad Gubernamental", "Entidad Gubernamenta", false, "G1", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, null, null, null, "Entidad Controlada por el Estado", "Ent Cont por Estado", false, "G2", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 0, null, null, null, null, "Persona Física relacionada al Gobierno", "Per Fis rel Gobierno", false, "G3", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 0, null, null, null, null, "NO", "NO", false, "NO", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", "NOASIGNADO", false, "XX", null, null }
                });

            migrationBuilder.InsertData(
                table: "LegalEntities",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescriptionLong", "DescriptionShort", "IsDeleted", "MercedesLegalEntity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, "Asociación Civil", "Asociación Civil", false, "AS", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, null, null, null, "Consorcio de Propiedad Horizontal", "Consorcio Prop Horiz", false, "CN", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 0, null, null, null, null, "Cooperativa", "Cooperativa", false, "CO", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 0, null, null, null, null, "Persona Estado Extranjero", "Estado Extranjero", false, "ESE", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), 0, null, null, null, null, "Estado", "Estado", false, "ESN", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), 0, null, null, null, null, "Iglesia Católica", "Iglesia Católica", false, "IC", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), 0, null, null, null, null, "Iglesia", "Iglesia", false, "IG", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), 0, null, null, null, null, "Mutual", "Mutual", false, "MU", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), 0, null, null, null, null, "Sociedad Anónima", "Sociedad Anónima", false, "SA", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000010"), 0, null, null, null, null, "Sociedad Anónima con Participación Estatal Mayoritaria", "SA c/Part Est Mayori", false, "SAE", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000011"), 0, null, null, null, null, "Sociedad Anónima Unipersonal", "Soc. An. Unipersonal", false, "SAU", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000012"), 0, null, null, null, null, "Sociedad Civil", "Sociedad Civil", false, "SC", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000013"), 0, null, null, null, null, "Sociedad del Estado", "Sociedad del Estado", false, "SE", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000014"), 0, null, null, null, null, "Sociedad de Hecho", "Sociedad de Hecho", false, "SH", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000015"), 0, null, null, null, null, "Sociedad de Responsabilidad Limitada", "Soc. Resp. Limitada", false, "SRL", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", "NOASIGNADO", false, "NOA", null, null }
                });

            migrationBuilder.InsertData(
                table: "LogisticClassifications",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescriptionLong", "DescriptionShort", "IsDeleted", "MercedesLogisticClassification", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, "Transporte Pasajeros", "Transporte Pasajeros", false, "001", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", "NOASIGNADO", false, "999", null, null }
                });

            migrationBuilder.InsertData(
                table: "SubgovernmentalClassifications",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescriptionLong", "DescriptionShort", "IsDeleted", "MercedesSubgovernmentalClassification", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, "Nacional", "Nacional", false, "001", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, null, null, null, "Provincial", "Provincial", false, "002", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 0, null, null, null, null, "Municipal", "Municipal", false, "003", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 0, null, null, null, null, "CABA", "CABA", false, "004", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), 0, null, null, null, null, "Internacional", "Internacional", false, "005", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), 0, null, null, null, null, "Interjurisdiccional", "Interjurisdiccional", false, "006", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", "NOASIGNADO", false, "999", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AperturesOne");

            migrationBuilder.DropTable(
                name: "AperturesTwo");

            migrationBuilder.DropTable(
                name: "CuitClassifications");

            migrationBuilder.DropTable(
                name: "EstimatedTurnovers");

            migrationBuilder.DropTable(
                name: "GovernmentalClassifications");

            migrationBuilder.DropTable(
                name: "LegalEntities");

            migrationBuilder.DropTable(
                name: "LogisticClassifications");

            migrationBuilder.DropTable(
                name: "SpecialSales");

            migrationBuilder.DropTable(
                name: "SubgovernmentalClassifications");
        }
    }
}
