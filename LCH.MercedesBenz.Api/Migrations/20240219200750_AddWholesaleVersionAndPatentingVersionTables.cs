using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddWholesaleVersionAndPatentingVersionTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatentingVersions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 4, nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
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
                    table.PrimaryKey("PK_PatentingVersions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WholesaleVersions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 4, nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
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
                    table.PrimaryKey("PK_WholesaleVersions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PatentingVersions",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "UpdatedAt", "UpdatedBy", "Version" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, null, null, "NOASIGNADO" });

            migrationBuilder.InsertData(
                table: "WholesaleVersions",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "UpdatedAt", "UpdatedBy", "Version" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, null, null, "NOASIGNADO" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatentingVersions");

            migrationBuilder.DropTable(
                name: "WholesaleVersions");
        }
    }
}
