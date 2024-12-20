using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class DefaultValuesColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SegmentationAux1Id",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SSegmId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RelevMBId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "PBTTNId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "NIId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MotorDTId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MCGTotalMktId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "EngineCapacityId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoorId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompetitiveCJDId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CabinSDId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CabinCFId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CJDCompetitiveId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ApertureThreeId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ApertureFourId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AltSegmId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AltCategId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AMGCompSetId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "AMGCompSetId", "AltCategId", "AltSegmId", "ApertureFourId", "ApertureThreeId", "CJDCompetitiveId", "CabinCFId", "CabinSDId", "CompetitiveCJDId", "DoorId", "EngineCapacityId", "GroupId", "MCGTotalMktId", "MotorDTId", "NIId", "PBTTNId", "RelevMBId", "SSegmId", "SegmentationAux1Id", "SourceId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SegmentationAux1Id",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SSegmId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "RelevMBId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "PBTTNId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "NIId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "MotorDTId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "MCGTotalMktId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "EngineCapacityId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "DoorId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CompetitiveCJDId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CabinSDId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CabinCFId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CJDCompetitiveId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ApertureThreeId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ApertureFourId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AltSegmId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AltCategId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AMGCompSetId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "AMGCompSetId", "AltCategId", "AltSegmId", "ApertureFourId", "ApertureThreeId", "CJDCompetitiveId", "CabinCFId", "CabinSDId", "CompetitiveCJDId", "DoorId", "EngineCapacityId", "GroupId", "MCGTotalMktId", "MotorDTId", "NIId", "PBTTNId", "RelevMBId", "SSegmId", "SegmentationAux1Id", "SourceId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") });
        }
    }
}
