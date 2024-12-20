using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class ModifyHistoricalIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Historicals_Chassis_Plate_CUITOwner_FMM_MTM_Department_Province_Location_RegNum_CarModelPat_BrandPat",
                table: "Historicals");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_BrandPat",
                table: "Historicals",
                column: "BrandPat");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_CarModelPat",
                table: "Historicals",
                column: "CarModelPat");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_Chassis",
                table: "Historicals",
                column: "Chassis");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_CUITOwner",
                table: "Historicals",
                column: "CUITOwner");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_Department",
                table: "Historicals",
                column: "Department");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_FMM_MTM",
                table: "Historicals",
                column: "FMM_MTM");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_Location",
                table: "Historicals",
                column: "Location");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_Plate",
                table: "Historicals",
                column: "Plate");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_Province",
                table: "Historicals",
                column: "Province");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_RegNum",
                table: "Historicals",
                column: "RegNum");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Historicals_BrandPat",
                table: "Historicals");

            migrationBuilder.DropIndex(
                name: "IX_Historicals_CarModelPat",
                table: "Historicals");

            migrationBuilder.DropIndex(
                name: "IX_Historicals_Chassis",
                table: "Historicals");

            migrationBuilder.DropIndex(
                name: "IX_Historicals_CUITOwner",
                table: "Historicals");

            migrationBuilder.DropIndex(
                name: "IX_Historicals_Department",
                table: "Historicals");

            migrationBuilder.DropIndex(
                name: "IX_Historicals_FMM_MTM",
                table: "Historicals");

            migrationBuilder.DropIndex(
                name: "IX_Historicals_Location",
                table: "Historicals");

            migrationBuilder.DropIndex(
                name: "IX_Historicals_Plate",
                table: "Historicals");

            migrationBuilder.DropIndex(
                name: "IX_Historicals_Province",
                table: "Historicals");

            migrationBuilder.DropIndex(
                name: "IX_Historicals_RegNum",
                table: "Historicals");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_Chassis_Plate_CUITOwner_FMM_MTM_Department_Province_Location_RegNum_CarModelPat_BrandPat",
                table: "Historicals",
                columns: new[] { "Chassis", "Plate", "CUITOwner", "FMM_MTM", "Department", "Province", "Location", "RegNum", "CarModelPat", "BrandPat" });
        }
    }
}
