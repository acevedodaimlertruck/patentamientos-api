using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddCat_InternalVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AlterColumn<string>(
                name: "MercedesTerminalId",
                table: "Tmmv",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MercedesModeloId",
                table: "Tmmv",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MercedesMarcaId",
                table: "Tmmv",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionVerWs",
                table: "Tmmv",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldUnicode: false,
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionVerPat",
                table: "Tmmv",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldUnicode: false,
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionVerInt",
                table: "Tmmv",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldUnicode: false,
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionTerminal",
                table: "Tmmv",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldUnicode: false,
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionModelo",
                table: "Tmmv",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldUnicode: false,
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionMarca",
                table: "Tmmv",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldUnicode: false,
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Cat_InternalVersions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    CarModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesTerminalId = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    MercedesMarcaId = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    MercedesModeloId = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Version = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Description = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
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
                    table.PrimaryKey("PK_Cat_InternalVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cat_InternalVersions_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cat_InternalVersions_CarModelId",
                table: "Cat_InternalVersions",
                column: "CarModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cat_InternalVersions");

            migrationBuilder.AlterColumn<string>(
                name: "VersionWs",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VersionPatentamiento",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VersionInterna",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MercedesTerminalId",
                table: "Tmmv",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MercedesModeloId",
                table: "Tmmv",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MercedesMarcaId",
                table: "Tmmv",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionVerWs",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldUnicode: false,
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionVerPat",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldUnicode: false,
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionVerInt",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldUnicode: false,
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionTerminal",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldUnicode: false,
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionModelo",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldUnicode: false,
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionMarca",
                table: "Tmmv",
                type: "varchar(512)",
                unicode: false,
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldUnicode: false,
                oldMaxLength: 60,
                oldNullable: true);
        }
    }
}
