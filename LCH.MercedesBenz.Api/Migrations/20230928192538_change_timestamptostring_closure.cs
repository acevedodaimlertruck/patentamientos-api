using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class change_timestamptostring_closure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HoraCreacion",
                table: "Closures",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HoraCreacion",
                table: "Closures",
                type: "time",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false);
        }
    }
}
