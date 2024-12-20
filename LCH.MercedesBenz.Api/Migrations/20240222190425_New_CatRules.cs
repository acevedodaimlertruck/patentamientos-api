using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class New_CatRules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CatRuleId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatRules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesCatRule = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_CatRules", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CatRules",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesCatRule", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "999", "NOA", null, null });

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "CatRuleId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_CatRuleId",
                table: "InternalVersionSegmentations",
                column: "CatRuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_CatRules_CatRuleId",
                table: "InternalVersionSegmentations",
                column: "CatRuleId",
                principalTable: "CatRules",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_CatRules_CatRuleId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropTable(
                name: "CatRules");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_CatRuleId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "CatRuleId",
                table: "InternalVersionSegmentations");
        }
    }
}
