using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class Historical_Model_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historicals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Plate = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Chassis = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    NaturalDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YearMonth = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: false),
                    NaturalYear = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: false),
                    OFMM = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FMM_MTM = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    RegNum = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Owner = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Province = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Department = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Location = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    PostalCode = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Year = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Car = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    ManufactureCountry = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    OriginCountry = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CUITPref = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    PatQuantity = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Weight = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Origin = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Motor = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    FactoryPat = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    BrandPat = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CarModelPat = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OFMMError = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    IsPatDuplicated = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CUITOwner = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
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
                    table.PrimaryKey("PK_Historicals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicals_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FileTypes",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), 0, null, null, null, null, null, false, "Histórico", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_FileId",
                table: "Historicals",
                column: "FileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historicals");

            migrationBuilder.DeleteData(
                table: "FileTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"));
        }
    }
}
