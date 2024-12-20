using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveProvinceIdDepartmentIdAndLocationIdInRegSec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "RegSecs");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "RegSecs");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "RegSecs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "RegSecs",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "RegSecs",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProvinceId",
                table: "RegSecs",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.UpdateData(
                table: "RegSecs",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "DepartmentId", "LocationId", "ProvinceId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033") });
        }
    }
}
