using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class SegmentationPlateModel4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SegmentationPlates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    PatentingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OfmmId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KeyVersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MercedesSegmentacionDominioId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
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
                    table.PrimaryKey("PK_SegmentationPlates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SegmentationPlates_KeyVersions_KeyVersionId",
                        column: x => x.KeyVersionId,
                        principalTable: "KeyVersions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SegmentationPlates_Ofmm_OfmmId",
                        column: x => x.OfmmId,
                        principalTable: "Ofmm",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SegmentationPlates_Patentings_PatentingId",
                        column: x => x.PatentingId,
                        principalTable: "Patentings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SegmentationPlates_KeyVersionId",
                table: "SegmentationPlates",
                column: "KeyVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentationPlates_OfmmId",
                table: "SegmentationPlates",
                column: "OfmmId");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentationPlates_PatentingId",
                table: "SegmentationPlates",
                column: "PatentingId",
                unique: true,
                filter: "[PatentingId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SegmentationPlates");
        }
    }
}
