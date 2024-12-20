using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class InternalVersionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InternalVersions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesMarcaId = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    CarModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesModeloId = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    TerminalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionPatentamiento = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    VersionWs = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    VersionInterna = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    DescripcionVerInt = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_InternalVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternalVersions_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InternalVersions_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InternalVersions_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersions_BrandId",
                table: "InternalVersions",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersions_CarModelId",
                table: "InternalVersions",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersions_TerminalId",
                table: "InternalVersions",
                column: "TerminalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InternalVersions");
        }
    }
}
