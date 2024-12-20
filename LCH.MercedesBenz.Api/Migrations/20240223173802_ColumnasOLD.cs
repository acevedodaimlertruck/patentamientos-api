using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class ColumnasOLD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Source",
                table: "InternalVersionSegmentations",
                newName: "SourceOLD");

            migrationBuilder.RenameColumn(
                name: "SegmentationAux1",
                table: "InternalVersionSegmentations",
                newName: "SegmentationAux1OLD");

            migrationBuilder.RenameColumn(
                name: "SSegm",
                table: "InternalVersionSegmentations",
                newName: "SSegmOLD");

            migrationBuilder.RenameColumn(
                name: "RelevMB",
                table: "InternalVersionSegmentations",
                newName: "RelevMBOLD");

            migrationBuilder.RenameColumn(
                name: "PBT_TN",
                table: "InternalVersionSegmentations",
                newName: "PBT_TNOLD");

            migrationBuilder.RenameColumn(
                name: "NI",
                table: "InternalVersionSegmentations",
                newName: "NIOLD");

            migrationBuilder.RenameColumn(
                name: "MotorDT",
                table: "InternalVersionSegmentations",
                newName: "MotorDTOLD");

            migrationBuilder.RenameColumn(
                name: "MCGTotalMkt",
                table: "InternalVersionSegmentations",
                newName: "MCGTotalMktOLD");

            migrationBuilder.RenameColumn(
                name: "Group",
                table: "InternalVersionSegmentations",
                newName: "GroupOLD");

            migrationBuilder.RenameColumn(
                name: "EngineCapacity",
                table: "InternalVersionSegmentations",
                newName: "EngineCapacityOLD");

            migrationBuilder.RenameColumn(
                name: "Doors",
                table: "InternalVersionSegmentations",
                newName: "DoorsOLD");

            migrationBuilder.RenameColumn(
                name: "CompetitiveCJD",
                table: "InternalVersionSegmentations",
                newName: "CompetitiveCJDOLD");

            migrationBuilder.RenameColumn(
                name: "CabinaSD",
                table: "InternalVersionSegmentations",
                newName: "CabinaSDOLD");

            migrationBuilder.RenameColumn(
                name: "CabinaCF",
                table: "InternalVersionSegmentations",
                newName: "CabinaCFOLD");

            migrationBuilder.RenameColumn(
                name: "CJDCompetitive",
                table: "InternalVersionSegmentations",
                newName: "CJDCompetitiveOLD");

            migrationBuilder.RenameColumn(
                name: "Apertura4",
                table: "InternalVersionSegmentations",
                newName: "Apertura4OLD");

            migrationBuilder.RenameColumn(
                name: "Apertura3",
                table: "InternalVersionSegmentations",
                newName: "Apertura3OLD");

            migrationBuilder.RenameColumn(
                name: "AltSegm",
                table: "InternalVersionSegmentations",
                newName: "AltSegmOLD");

            migrationBuilder.RenameColumn(
                name: "AltCateg",
                table: "InternalVersionSegmentations",
                newName: "AltCategOLD");

            
            migrationBuilder.RenameColumn(
                name: "AMGCompSet",
                table: "InternalVersionSegmentations",
                newName: "AMGCompSetOLD");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SourceOLD",
                table: "InternalVersionSegmentations",
                newName: "Source");

            migrationBuilder.RenameColumn(
                name: "SegmentationAux1OLD",
                table: "InternalVersionSegmentations",
                newName: "SegmentationAux1");

            migrationBuilder.RenameColumn(
                name: "SSegmOLD",
                table: "InternalVersionSegmentations",
                newName: "SSegm");

            migrationBuilder.RenameColumn(
                name: "RelevMBOLD",
                table: "InternalVersionSegmentations",
                newName: "RelevMB");

            migrationBuilder.RenameColumn(
                name: "PBT_TNOLD",
                table: "InternalVersionSegmentations",
                newName: "PBT_TN");

            migrationBuilder.RenameColumn(
                name: "NIOLD",
                table: "InternalVersionSegmentations",
                newName: "NI");

            migrationBuilder.RenameColumn(
                name: "MotorDTOLD",
                table: "InternalVersionSegmentations",
                newName: "MotorDT");

            migrationBuilder.RenameColumn(
                name: "MCGTotalMktOLD",
                table: "InternalVersionSegmentations",
                newName: "MCGTotalMkt");

            migrationBuilder.RenameColumn(
                name: "GroupOLD",
                table: "InternalVersionSegmentations",
                newName: "Group");

            migrationBuilder.RenameColumn(
                name: "EngineCapacityOLD",
                table: "InternalVersionSegmentations",
                newName: "EngineCapacity");

            migrationBuilder.RenameColumn(
                name: "DoorsOLD",
                table: "InternalVersionSegmentations",
                newName: "Doors");

            migrationBuilder.RenameColumn(
                name: "CompetitiveCJDOLD",
                table: "InternalVersionSegmentations",
                newName: "CompetitiveCJD");

            migrationBuilder.RenameColumn(
                name: "CabinaSDOLD",
                table: "InternalVersionSegmentations",
                newName: "CabinaSD");

            migrationBuilder.RenameColumn(
                name: "CabinaCFOLD",
                table: "InternalVersionSegmentations",
                newName: "CabinaCF");

            migrationBuilder.RenameColumn(
                name: "CJDCompetitiveOLD",
                table: "InternalVersionSegmentations",
                newName: "CJDCompetitive");

            migrationBuilder.RenameColumn(
                name: "Apertura4OLD",
                table: "InternalVersionSegmentations",
                newName: "Apertura4");

            migrationBuilder.RenameColumn(
                name: "Apertura3OLD",
                table: "InternalVersionSegmentations",
                newName: "Apertura3");

            migrationBuilder.RenameColumn(
                name: "AltSegmOLD",
                table: "InternalVersionSegmentations",
                newName: "AltSegm");

            migrationBuilder.RenameColumn(
                name: "AltCategOLD",
                table: "InternalVersionSegmentations",
                newName: "AltCateg");            

            migrationBuilder.RenameColumn(
                name: "AMGCompSetOLD",
                table: "InternalVersionSegmentations",
                newName: "AMGCompSet");
        }
    }
}
