using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class GradoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MarcaWs = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    ModeloWs = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    Grade = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MercedesTerminalId = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    MercedesMarcaId = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    MercedesModeloId = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    CarModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionWs = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    DischargeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_Grados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grados_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grados",
                columns: new[] { "Id", "AutoId", "CarModelId", "CreatedAt", "CreatedBy", "DateFrom", "DateTo", "DeletedAt", "DeletedBy", "DischargeDate", "Grade", "IsDeleted", "MarcaWs", "MercedesMarcaId", "MercedesModeloId", "MercedesTerminalId", "ModeloWs", "UpdatedAt", "UpdatedBy", "VersionWs" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, new Guid("00000000-0000-0000-0000-000000000033"), null, null, null, null, null, null, null, "NOASIGN", false, "NOAS", null, null, null, "NOASI", null, null, "NOAS" });

            migrationBuilder.CreateIndex(
                name: "IX_Grados_CarModelId",
                table: "Grados",
                column: "CarModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grados");
        }
    }
}
