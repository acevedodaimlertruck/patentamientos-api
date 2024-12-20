using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class RegSecModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegSecs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    RegistryNumber = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    RegistryProvince = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    RegistryDepartment = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    RegistryLocation = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    AutoZoneDealer = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    TruckZoneDealer = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    VanZoneDealer = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_RegSecs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegSecs");
        }
    }
}
