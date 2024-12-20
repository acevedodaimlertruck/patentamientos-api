using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class IVS_FKs_v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usage",
                table: "InternalVersionSegmentations",
                newName: "MercedesUsage");

            migrationBuilder.RenameColumn(
                name: "Traction",
                table: "InternalVersionSegmentations",
                newName: "MercedesTraction");

            migrationBuilder.RenameColumn(
                name: "SSegm",
                table: "InternalVersionSegmentations",
                newName: "MercedesSSegm");

            migrationBuilder.RenameColumn(
                name: "Power",
                table: "InternalVersionSegmentations",
                newName: "MercedesPower");

            migrationBuilder.RenameColumn(
                name: "Configuration",
                table: "InternalVersionSegmentations",
                newName: "MercedesConfiguration");

            migrationBuilder.RenameColumn(
                name: "BodyStyle",
                table: "InternalVersionSegmentations",
                newName: "MercedesBodyStyle");

            migrationBuilder.AddColumn<Guid>(
                name: "BodyStyleId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddColumn<Guid>(
                name: "BodyworkId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddColumn<Guid>(
                name: "PowerId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubsegmentId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddColumn<Guid>(
                name: "TractionId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsageId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.CreateTable(
                name: "BodyStyles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesBodyStyle = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_BodyStyles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bodyworks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesBodywork = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_Bodyworks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Powers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesPower = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_Powers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subsegments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesSubsegment = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_Subsegments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tractions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesTraction = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_Tractions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesUsage = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    SegCategory = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
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
                    table.PrimaryKey("PK_Usages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BodyStyles",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesBodyStyle", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "Bodyworks",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesBodywork", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "BodyStyleId", "BodyworkId", "PowerId", "SubsegmentId", "TractionId", "UsageId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033") });

            migrationBuilder.InsertData(
                table: "Powers",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesPower", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "Subsegments",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesSubsegment", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "Tractions",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesTraction", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.InsertData(
                table: "Usages",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesUsage", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_BodyStyleId",
                table: "InternalVersionSegmentations",
                column: "BodyStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_BodyworkId",
                table: "InternalVersionSegmentations",
                column: "BodyworkId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_PowerId",
                table: "InternalVersionSegmentations",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_SubsegmentId",
                table: "InternalVersionSegmentations",
                column: "SubsegmentId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_TractionId",
                table: "InternalVersionSegmentations",
                column: "TractionId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_UsageId",
                table: "InternalVersionSegmentations",
                column: "UsageId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_BodyStyles_BodyStyleId",
                table: "InternalVersionSegmentations",
                column: "BodyStyleId",
                principalTable: "BodyStyles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Bodyworks_BodyworkId",
                table: "InternalVersionSegmentations",
                column: "BodyworkId",
                principalTable: "Bodyworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Powers_PowerId",
                table: "InternalVersionSegmentations",
                column: "PowerId",
                principalTable: "Powers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Subsegments_SubsegmentId",
                table: "InternalVersionSegmentations",
                column: "SubsegmentId",
                principalTable: "Subsegments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Tractions_TractionId",
                table: "InternalVersionSegmentations",
                column: "TractionId",
                principalTable: "Tractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_Usages_UsageId",
                table: "InternalVersionSegmentations",
                column: "UsageId",
                principalTable: "Usages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_BodyStyles_BodyStyleId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Bodyworks_BodyworkId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Powers_PowerId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Subsegments_SubsegmentId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Tractions_TractionId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_Usages_UsageId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropTable(
                name: "BodyStyles");

            migrationBuilder.DropTable(
                name: "Bodyworks");

            migrationBuilder.DropTable(
                name: "Powers");

            migrationBuilder.DropTable(
                name: "Subsegments");

            migrationBuilder.DropTable(
                name: "Tractions");

            migrationBuilder.DropTable(
                name: "Usages");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_BodyStyleId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_BodyworkId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_PowerId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_SubsegmentId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_TractionId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_UsageId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "BodyStyleId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "BodyworkId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "PowerId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "SubsegmentId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "TractionId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "UsageId",
                table: "InternalVersionSegmentations");

            migrationBuilder.RenameColumn(
                name: "MercedesUsage",
                table: "InternalVersionSegmentations",
                newName: "Usage");

            migrationBuilder.RenameColumn(
                name: "MercedesTraction",
                table: "InternalVersionSegmentations",
                newName: "Traction");

            migrationBuilder.RenameColumn(
                name: "MercedesSSegm",
                table: "InternalVersionSegmentations",
                newName: "SSegm");

            migrationBuilder.RenameColumn(
                name: "MercedesPower",
                table: "InternalVersionSegmentations",
                newName: "Power");

            migrationBuilder.RenameColumn(
                name: "MercedesConfiguration",
                table: "InternalVersionSegmentations",
                newName: "Configuration");

            migrationBuilder.RenameColumn(
                name: "MercedesBodyStyle",
                table: "InternalVersionSegmentations",
                newName: "BodyStyle");
        }
    }
}
