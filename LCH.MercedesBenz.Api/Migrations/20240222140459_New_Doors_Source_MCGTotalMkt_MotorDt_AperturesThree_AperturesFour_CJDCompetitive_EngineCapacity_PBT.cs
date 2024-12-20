using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class New_Doors_Source_MCGTotalMkt_MotorDt_AperturesThree_AperturesFour_CJDCompetitive_EngineCapacity_PBT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ApertureFourId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApertureThreeId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CJDCompetitiveId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DoorId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EngineCapacityId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MCGTotalMktId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MotorDTId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PBTId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SourceId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AperturesFour",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesApertureFour = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_AperturesFour", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AperturesThree",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesApertureThree = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_AperturesThree", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CJDCompetitives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesCJDCompetitive = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_CJDCompetitives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesDoor = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_Doors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EngineCapacitys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesEngineCapacity = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_EngineCapacitys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MCGTotalMkts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesMCGTotalMkt = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_MCGTotalMkts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotorDTs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesMotorDT = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_MotorDTs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PBTs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesPBT = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_PBTs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesSource = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AperturesFour",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesApertureFour", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "AperturesThree",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesApertureThree", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "CJDCompetitives",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesCJDCompetitive", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesDoor", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "EngineCapacitys",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesEngineCapacity", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "ApertureFourId", "ApertureThreeId", "CJDCompetitiveId", "DoorId", "EngineCapacityId", "MCGTotalMktId", "MotorDTId", "PBTId", "SourceId" },
                values: new object[] { null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "MCGTotalMkts",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesMCGTotalMkt", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "MotorDTs",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesMotorDT", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "PBTs",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesPBT", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesSource", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_ApertureFourId",
                table: "InternalVersionSegmentations",
                column: "ApertureFourId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_ApertureThreeId",
                table: "InternalVersionSegmentations",
                column: "ApertureThreeId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_CJDCompetitiveId",
                table: "InternalVersionSegmentations",
                column: "CJDCompetitiveId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_DoorId",
                table: "InternalVersionSegmentations",
                column: "DoorId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_EngineCapacityId",
                table: "InternalVersionSegmentations",
                column: "EngineCapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_MCGTotalMktId",
                table: "InternalVersionSegmentations",
                column: "MCGTotalMktId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_MotorDTId",
                table: "InternalVersionSegmentations",
                column: "MotorDTId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_PBTId",
                table: "InternalVersionSegmentations",
                column: "PBTId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_SourceId",
                table: "InternalVersionSegmentations",
                column: "SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_AperturesFour_ApertureFourId",
                table: "InternalVersionSegmentations",
                column: "ApertureFourId",
                principalTable: "AperturesFour",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_AperturesThree_ApertureThreeId",
                table: "InternalVersionSegmentations",
                column: "ApertureThreeId",
                principalTable: "AperturesThree",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_CJDCompetitives_CJDCompetitiveId",
                table: "InternalVersionSegmentations",
                column: "CJDCompetitiveId",
                principalTable: "CJDCompetitives",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Doors_DoorId",
                table: "InternalVersionSegmentations",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_EngineCapacitys_EngineCapacityId",
                table: "InternalVersionSegmentations",
                column: "EngineCapacityId",
                principalTable: "EngineCapacitys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_MCGTotalMkts_MCGTotalMktId",
                table: "InternalVersionSegmentations",
                column: "MCGTotalMktId",
                principalTable: "MCGTotalMkts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_MotorDTs_MotorDTId",
                table: "InternalVersionSegmentations",
                column: "MotorDTId",
                principalTable: "MotorDTs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_PBTs_PBTId",
                table: "InternalVersionSegmentations",
                column: "PBTId",
                principalTable: "PBTs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Sources_SourceId",
                table: "InternalVersionSegmentations",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_AperturesFour_ApertureFourId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_AperturesThree_ApertureThreeId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_CJDCompetitives_CJDCompetitiveId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Doors_DoorId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_EngineCapacitys_EngineCapacityId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_MCGTotalMkts_MCGTotalMktId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_MotorDTs_MotorDTId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_PBTs_PBTId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Sources_SourceId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropTable(
                name: "AperturesFour");

            migrationBuilder.DropTable(
                name: "AperturesThree");

            migrationBuilder.DropTable(
                name: "CJDCompetitives");

            migrationBuilder.DropTable(
                name: "Doors");

            migrationBuilder.DropTable(
                name: "EngineCapacitys");

            migrationBuilder.DropTable(
                name: "MCGTotalMkts");

            migrationBuilder.DropTable(
                name: "MotorDTs");

            migrationBuilder.DropTable(
                name: "PBTs");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_ApertureFourId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_ApertureThreeId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_CJDCompetitiveId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_DoorId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_EngineCapacityId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_MCGTotalMktId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_MotorDTId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_PBTId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_SourceId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "ApertureFourId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "ApertureThreeId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "CJDCompetitiveId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "DoorId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "EngineCapacityId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "MCGTotalMktId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "MotorDTId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "PBTId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "InternalVersionSegmentations");
        }
    }
}
