using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class OdsWholesales_ver2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OdsWholesales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    YearMonth = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    CodBrand = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    Brand = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CodModel = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    Model = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CodTrademark = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: false),
                    Trademark = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    GradoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoorsQty = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Engine = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    MotorType = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    FuelType = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Power = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    PowerUnit = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    MercedesVehicleType = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    VehicleTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Traction = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    GearsQty = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    TransmissionType = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    AxleQty = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Weight = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    LoadCapacity = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    MercedesCategory = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Origin = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    InitialStock = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Import_ProdMonth = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Import_ProdAccum = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MonthlySale = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MonthlyAccum = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ExportMonthly = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ExportAccum = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SavingSystemMonthly = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SavingSystemAccum = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FinalStock = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NoOkStock = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    StatePatentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_OdsWholesales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OdsWholesales_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsWholesales_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsWholesales_Grados_GradoId",
                        column: x => x.GradoId,
                        principalTable: "Grados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsWholesales_StatePatentas_StatePatentaId",
                        column: x => x.StatePatentaId,
                        principalTable: "StatePatentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsWholesales_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OdsWholesales_CategoryId",
                table: "OdsWholesales",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsWholesales_FileId",
                table: "OdsWholesales",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsWholesales_GradoId",
                table: "OdsWholesales",
                column: "GradoId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsWholesales_StatePatentaId",
                table: "OdsWholesales",
                column: "StatePatentaId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsWholesales_VehicleTypeId",
                table: "OdsWholesales",
                column: "VehicleTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OdsWholesales");
        }
    }
}
