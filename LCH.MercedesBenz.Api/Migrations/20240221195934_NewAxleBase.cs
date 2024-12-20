using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class NewAxleBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AxleBaseId",
                table: "InternalVersionSegmentations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AxleBases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    MercedesAxleBase = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
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
                    table.PrimaryKey("PK_AxleBases", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "AxleBaseId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_InternalVersionSegmentations_AxleBaseId",
                table: "InternalVersionSegmentations",
                column: "AxleBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalVersionSegmentations_AxleBases_AxleBaseId",
                table: "InternalVersionSegmentations",
                column: "AxleBaseId",
                principalTable: "AxleBases",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalVersionSegmentations_AxleBases_AxleBaseId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropTable(
                name: "AxleBases");

            migrationBuilder.DropIndex(
                name: "IX_InternalVersionSegmentations_AxleBaseId",
                table: "InternalVersionSegmentations");

            migrationBuilder.DropColumn(
                name: "AxleBaseId",
                table: "InternalVersionSegmentations");
        }
    }
}
