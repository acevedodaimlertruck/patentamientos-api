using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class New_CabinCF_CabinSD_CompetitiveCJD_Configuration_AltBodyst_AltCateg_AltSegm_AMGCompSet_PBTTN_NI_RelevMB_SegmentationAux1_SSegm_Group : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Cabins_CabinId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropTable(
                name: "Cabins");

            migrationBuilder.RenameColumn(
                name: "CabinId",
                table: "InternalVersionSegmentations",
                newName: "SegmentationAux1Id");

            migrationBuilder.RenameIndex(
                name: "IX_InternalVersionSegmentations_CabinId",
                table: "InternalVersionSegmentations",
                newName: "IX_InternalVersionSegmentations_SegmentationAux1Id");

            migrationBuilder.AddColumn<Guid>(
                name: "AMGCompSetId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AltBodystId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AltCategId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AltSegmId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CabinCFId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CabinSDId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompetitiveCJDId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ConfigurationId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NIId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PBTTNId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RelevMBId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SSegmId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AltBodysts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesAltBodyst = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_AltBodysts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AltCategs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesAltCateg = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_AltCategs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AltSegms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesAltSegm = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_AltSegms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AMGCompSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesAMGCompSet = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_AMGCompSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CabinCFs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesCabinCF = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_CabinCFs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CabinSDs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesCabinSD = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_CabinSDs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetitiveCJDs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesCompetitiveCJD = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_CompetitiveCJDs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesConfiguration = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_Configurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesGroup = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NIs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesNI = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_NIs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PBTTNs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesPBTTN = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_PBTTNs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelevMBs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesRelevMB = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_RelevMBs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SegmentationAux1s",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesSegmentationAux1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_SegmentationAux1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SSegms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesSSegm = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_SSegms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AMGCompSets",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesAMGCompSet", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "AltBodysts",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesAltBodyst", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "AltCategs",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesAltCateg", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "AltSegms",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesAltSegm", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "CabinCFs",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesCabinCF", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "CabinSDs",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesCabinSD", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "CompetitiveCJDs",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesCompetitiveCJD", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesConfiguration", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesGroup", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "AMGCompSetId", "AltBodystId", "AltCategId", "AltSegmId", "CabinCFId", "CabinSDId", "CompetitiveCJDId", "ConfigurationId", "GroupId", "NIId", "PBTTNId", "RelevMBId", "SSegmId" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "NIs",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesNI", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "PBTTNs",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesPBTTN", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "RelevMBs",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesRelevMB", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "SSegms",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesSSegm", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "SegmentationAux1s",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesSegmentationAux1", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_AltBodystId",
                table: "InternalVersionSegmentations",
                column: "AltBodystId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_AltCategId",
                table: "InternalVersionSegmentations",
                column: "AltCategId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_AltSegmId",
                table: "InternalVersionSegmentations",
                column: "AltSegmId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_AMGCompSetId",
                table: "InternalVersionSegmentations",
                column: "AMGCompSetId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_CabinCFId",
                table: "InternalVersionSegmentations",
                column: "CabinCFId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_CabinSDId",
                table: "InternalVersionSegmentations",
                column: "CabinSDId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_CompetitiveCJDId",
                table: "InternalVersionSegmentations",
                column: "CompetitiveCJDId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_ConfigurationId",
                table: "InternalVersionSegmentations",
                column: "ConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_GroupId",
                table: "InternalVersionSegmentations",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_NIId",
                table: "InternalVersionSegmentations",
                column: "NIId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_PBTTNId",
                table: "InternalVersionSegmentations",
                column: "PBTTNId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_RelevMBId",
                table: "InternalVersionSegmentations",
                column: "RelevMBId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_SSegmId",
                table: "InternalVersionSegmentations",
                column: "SSegmId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_AMGCompSets_AMGCompSetId",
                table: "InternalVersionSegmentations",
                column: "AMGCompSetId",
                principalTable: "AMGCompSets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_AltBodysts_AltBodystId",
                table: "InternalVersionSegmentations",
                column: "AltBodystId",
                principalTable: "AltBodysts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_AltCategs_AltCategId",
                table: "InternalVersionSegmentations",
                column: "AltCategId",
                principalTable: "AltCategs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_AltSegms_AltSegmId",
                table: "InternalVersionSegmentations",
                column: "AltSegmId",
                principalTable: "AltSegms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_CabinCFs_CabinCFId",
                table: "InternalVersionSegmentations",
                column: "CabinCFId",
                principalTable: "CabinCFs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_CabinSDs_CabinSDId",
                table: "InternalVersionSegmentations",
                column: "CabinSDId",
                principalTable: "CabinSDs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_CompetitiveCJDs_CompetitiveCJDId",
                table: "InternalVersionSegmentations",
                column: "CompetitiveCJDId",
                principalTable: "CompetitiveCJDs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Configurations_ConfigurationId",
                table: "InternalVersionSegmentations",
                column: "ConfigurationId",
                principalTable: "Configurations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Groups_GroupId",
                table: "InternalVersionSegmentations",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_NIs_NIId",
                table: "InternalVersionSegmentations",
                column: "NIId",
                principalTable: "NIs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_PBTTNs_PBTTNId",
                table: "InternalVersionSegmentations",
                column: "PBTTNId",
                principalTable: "PBTTNs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_RelevMBs_RelevMBId",
                table: "InternalVersionSegmentations",
                column: "RelevMBId",
                principalTable: "RelevMBs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_SSegms_SSegmId",
                table: "InternalVersionSegmentations",
                column: "SSegmId",
                principalTable: "SSegms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_SegmentationAux1s_SegmentationAux1Id",
                table: "InternalVersionSegmentations",
                column: "SegmentationAux1Id",
                principalTable: "SegmentationAux1s",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_AMGCompSets_AMGCompSetId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_AltBodysts_AltBodystId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_AltCategs_AltCategId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_AltSegms_AltSegmId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_CabinCFs_CabinCFId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_CabinSDs_CabinSDId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_CompetitiveCJDs_CompetitiveCJDId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Configurations_ConfigurationId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Groups_GroupId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_NIs_NIId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_PBTTNs_PBTTNId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_RelevMBs_RelevMBId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_SSegms_SSegmId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_SegmentationAux1s_SegmentationAux1Id",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropTable(
                name: "AltBodysts");

            migrationBuilder.DropTable(
                name: "AltCategs");

            migrationBuilder.DropTable(
                name: "AltSegms");

            migrationBuilder.DropTable(
                name: "AMGCompSets");

            migrationBuilder.DropTable(
                name: "CabinCFs");

            migrationBuilder.DropTable(
                name: "CabinSDs");

            migrationBuilder.DropTable(
                name: "CompetitiveCJDs");

            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "NIs");

            migrationBuilder.DropTable(
                name: "PBTTNs");

            migrationBuilder.DropTable(
                name: "RelevMBs");

            migrationBuilder.DropTable(
                name: "SegmentationAux1s");

            migrationBuilder.DropTable(
                name: "SSegms");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_AltBodystId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_AltCategId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_AltSegmId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_AMGCompSetId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_CabinCFId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_CabinSDId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_CompetitiveCJDId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_ConfigurationId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_GroupId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_NIId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_PBTTNId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_RelevMBId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_SSegmId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "AMGCompSetId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "AltBodystId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "AltCategId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "AltSegmId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "CabinCFId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "CabinSDId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "CompetitiveCJDId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "ConfigurationId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "NIId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "PBTTNId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "RelevMBId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "SSegmId",
                table: "InternalVersionSegmentations");

            migrationBuilder.RenameColumn(
                name: "SegmentationAux1Id",
                table: "InternalVersionSegmentations",
                newName: "CabinId");

            migrationBuilder.RenameIndex(
                name: "IX_InternalVersionSegmentations_SegmentationAux1Id",
                table: "InternalVersionSegmentations",
                newName: "IX_InternalVersionSegmentations_CabinId");

            migrationBuilder.CreateTable(
                name: "Cabins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MercedesCabin = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabins", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cabins",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesCabin", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Cabins_CabinId",
                table: "InternalVersionSegmentations",
                column: "CabinId",
                principalTable: "Cabins",
                principalColumn: "Id");
        }
    }
}
