using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddHistoricalIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Historicals_Chassis_Plate_CUITOwner_FMM_MTM_Department_Province_Location_RegNum_CarModelPat_BrandPat",
                table: "Historicals",
                columns: new[] { "Chassis", "Plate", "CUITOwner", "FMM_MTM", "Department", "Province", "Location", "RegNum", "CarModelPat", "BrandPat" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Historicals_Chassis_Plate_CUITOwner_FMM_MTM_Department_Province_Location_RegNum_CarModelPat_BrandPat",
                table: "Historicals");
        }
    }
}
