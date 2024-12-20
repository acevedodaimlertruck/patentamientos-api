using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddSegCategoryInApertureOneAndApertureTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SegCategory",
                table: "AperturesTwo",
                type: "varchar(3)",
                unicode: false,
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegCategory",
                table: "AperturesOne",
                type: "varchar(3)",
                unicode: false,
                maxLength: 3,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AperturesOne",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "SegCategory",
                value: "NOA");

            migrationBuilder.UpdateData(
                table: "AperturesOne",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "SegCategory",
                value: "NOA");

            migrationBuilder.UpdateData(
                table: "AperturesOne",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "SegCategory",
                value: "NOA");

            migrationBuilder.UpdateData(
                table: "AperturesTwo",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "SegCategory",
                value: "NOA");

            migrationBuilder.UpdateData(
                table: "AperturesTwo",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "SegCategory",
                value: "NOA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SegCategory",
                table: "AperturesTwo");

            migrationBuilder.DropColumn(
                name: "SegCategory",
                table: "AperturesOne");
        }
    }
}
