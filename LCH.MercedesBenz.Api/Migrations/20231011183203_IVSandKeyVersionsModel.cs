using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class IVSandKeyVersionsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SegCategory",
                table: "Segments",
                newName: "MercedesCategoriaId");

            migrationBuilder.AddColumn<string>(
                name: "MercedesMarcaId",
                table: "Tmmv",
                type: "varchar(max)",
                unicode: false,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MercedesModeloId",
                table: "Tmmv",
                type: "varchar(max)",
                unicode: false,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MercedesTerminalId",
                table: "Tmmv",
                type: "varchar(max)",
                unicode: false,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MercedesTerminalId",
                table: "InternalVersions",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InternalVersionSegmentations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    InternalVersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesVersionInternaId = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesCategoriaId = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SegmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesSegmentoId = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DischargeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    AltBodyst = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    AltCateg = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    AltSegm = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    AMGCompSet = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Apertura1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Apertura2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Apertura3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Apertura4 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    BodyStyle = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    CabinaCF = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    CabinaSD = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    EngineCapacity = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    CJDCompetitive = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Fuel = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    CompetitiveCJD = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Configuration = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Wheelbase = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    AxleBase = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Group = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Gears = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    MCGTotalMkt = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    MotorDT = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    NI = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Rule = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Source = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PBT = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PBT_TN = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Power = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Doors = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    RelevMB = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SSegm = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Traction = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Usage = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SegmentationAux1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SegmentationAux2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SegmentationAux3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SegmentationAux4 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SegmentationAux5 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_InternalVersionSegmentations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternalVersionSegmentations_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InternalVersionSegmentations_InternalVersions_InternalVersionId",
                        column: x => x.InternalVersionId,
                        principalTable: "InternalVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InternalVersionSegmentations_Segments_SegmentId",
                        column: x => x.SegmentId,
                        principalTable: "Segments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeyVersions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesTerminalId = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    MercedesMarcaId = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    MercedesModeloId = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    InternalVersionSegmentationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesVersionInternaSegmentacionId = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    MercedesVersionClaveId = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_KeyVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyVersions_InternalVersionSegmentations_InternalVersionSegmentationId",
                        column: x => x.InternalVersionSegmentationId,
                        principalTable: "InternalVersionSegmentations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_CategoryId",
                table: "InternalVersionSegmentations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_InternalVersionId",
                table: "InternalVersionSegmentations",
                column: "InternalVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_SegmentId",
                table: "InternalVersionSegmentations",
                column: "SegmentId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyVersions_InternalVersionSegmentationId",
                table: "KeyVersions",
                column: "InternalVersionSegmentationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeyVersions");

            migrationBuilder.DropTable(
                name: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "MercedesMarcaId",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "MercedesModeloId",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "MercedesTerminalId",
                table: "Tmmv");

            migrationBuilder.DropColumn(
                name: "MercedesTerminalId",
                table: "InternalVersions");

            migrationBuilder.RenameColumn(
                name: "MercedesCategoriaId",
                table: "Segments",
                newName: "SegCategory");
        }
    }
}
