using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class add_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechInsc",
                table: "Patentings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FechaCierre",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    ZFechaCierre = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZFechaDia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZHoraDia = table.Column<TimeSpan>(type: "time", nullable: true),
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
                    table.PrimaryKey("PK_FechaCierre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ofmm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    ZOFMM = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    ValidoHasta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidoDesde = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FabricaPat = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    MarcaPat = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    MODELOPAT = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    Descripcion1 = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    Descripcion2 = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    TipoDeTexto = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    Terminal = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    Marca = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    Modelo = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    VersionPatentamiento = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    Origen = table.Column<string>(type: "char(1)", maxLength: 1, nullable: true),
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
                    table.PrimaryKey("PK_Ofmm", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FechaCierre");

            migrationBuilder.DropTable(
                name: "Ofmm");

            migrationBuilder.DropColumn(
                name: "FechInsc",
                table: "Patentings");
        }
    }
}
