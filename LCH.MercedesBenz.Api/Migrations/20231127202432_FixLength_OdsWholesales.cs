using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class FixLength_OdsWholesales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TransmissionType",
                table: "OdsWholesales",
                type: "varchar(1)",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldUnicode: false,
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "GearsQty",
                table: "OdsWholesales",
                type: "varchar(2)",
                unicode: false,
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)",
                oldUnicode: false,
                oldMaxLength: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TransmissionType",
                table: "OdsWholesales",
                type: "varchar(2)",
                unicode: false,
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)",
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "GearsQty",
                table: "OdsWholesales",
                type: "varchar(1)",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldUnicode: false,
                oldMaxLength: 2);
        }
    }
}
