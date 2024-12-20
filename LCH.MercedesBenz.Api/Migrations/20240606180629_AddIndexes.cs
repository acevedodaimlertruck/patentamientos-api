using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RegSecs_RegistryNumber",
                table: "RegSecs",
                column: "RegistryNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_MercedesProvinciaId",
                table: "Provinces",
                column: "MercedesProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_Plate_Chasis",
                table: "Patentings",
                columns: new[] { "Plate", "Chasis" });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_MercedesLocalidadId_MercedesDepartamentoId_MercedesProvinciaId",
                table: "Locations",
                columns: new[] { "MercedesLocalidadId", "MercedesDepartamentoId", "MercedesProvinciaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Factories_MercedesFabricaId",
                table: "Factories",
                column: "MercedesFabricaId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MercedesDepartamentoId_MercedesProvinciaId",
                table: "Departments",
                columns: new[] { "MercedesDepartamentoId", "MercedesProvinciaId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RegSecs_RegistryNumber",
                table: "RegSecs");

            migrationBuilder.DropIndex(
                name: "IX_Provinces_MercedesProvinciaId",
                table: "Provinces");

            migrationBuilder.DropIndex(
                name: "IX_Patentings_Plate_Chasis",
                table: "Patentings");

            migrationBuilder.DropIndex(
                name: "IX_Locations_MercedesLocalidadId_MercedesDepartamentoId_MercedesProvinciaId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Factories_MercedesFabricaId",
                table: "Factories");

            migrationBuilder.DropIndex(
                name: "IX_Departments_MercedesDepartamentoId_MercedesProvinciaId",
                table: "Departments");
        }
    }
}
