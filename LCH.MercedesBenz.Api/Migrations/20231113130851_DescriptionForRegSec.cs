using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class DescriptionForRegSec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AutoZoneDescription",
                table: "RegSecs",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TruckZoneDescription",
                table: "RegSecs",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VanZoneDescription",
                table: "RegSecs",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegSecs",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "AutoZoneDescription", "TruckZoneDescription", "VanZoneDescription" },
                values: new object[] { null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutoZoneDescription",
                table: "RegSecs");

            migrationBuilder.DropColumn(
                name: "TruckZoneDescription",
                table: "RegSecs");

            migrationBuilder.DropColumn(
                name: "VanZoneDescription",
                table: "RegSecs");
        }
    }
}
