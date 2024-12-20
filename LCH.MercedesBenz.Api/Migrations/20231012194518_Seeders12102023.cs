using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class Seeders12102023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesMarcaId", "MercedesTerminalId", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, null, null, "NOASIGNADO", null, null });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesMarcaId", "MercedesModeloId", "MercedesTerminalId", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, null, null, null, "NOASIGNADO", null, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "SegCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "NOA", null, null });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesDepartamentoId", "MercedesProvinciaId", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, null, null, "NOASIGNADO", null, null });

            migrationBuilder.InsertData(
                table: "Factories",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesFabricaId", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, null, "NOASIGNADO", null, null });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesDepartamentoId", "MercedesLocalidadId", "MercedesProvinciaId", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, null, null, null, "NOASIGNADO", null, null });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "AutoId", "CUIT", "CreatedAt", "CreatedBy", "CuitPref", "DeletedAt", "DeletedBy", "FullName", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, "", null, null, "", null, null, "NOASIGNADO", false, null, null });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesProvinciaId", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, null, "NOASIGNADO", null, null });

            migrationBuilder.InsertData(
                table: "RegSecs",
                columns: new[] { "Id", "AutoId", "AutoZoneDealer", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "RegistryDepartment", "RegistryLocation", "RegistryNumber", "RegistryProvince", "TruckZoneDealer", "UpdatedAt", "UpdatedBy", "VanZoneDealer" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, null, "NOASIGNADO", false, "NOASIGNADO", null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Segments",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescriptionLong", "DescriptionShort", "IsDeleted", "MercedesCategoriaId", "SegName", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", "NOASIGNADO", false, null, "NOA", null, null });

            migrationBuilder.InsertData(
                table: "Terminals",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "MercedesTerminalId", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, null, "NOASIGNADO", null, null });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, "NOASIGNADO", false, "NOASIGNADO", null, null });

            migrationBuilder.InsertData(
                table: "InternalVersions",
                columns: new[] { "Id", "AutoId", "BrandId", "CarModelId", "CreatedAt", "CreatedBy", "DateFrom", "DateTo", "DeletedAt", "DeletedBy", "DescripcionVerInt", "IsDeleted", "MercedesMarcaId", "MercedesModeloId", "MercedesTerminalId", "TerminalId", "UpdatedAt", "UpdatedBy", "UploadDate", "VersionInterna", "VersionPatentamiento", "VersionWs" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), null, null, null, null, null, null, "NOASIGNADO", false, null, null, null, new Guid("00000000-0000-0000-0000-000000000033"), null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Ofmm",
                columns: new[] { "Id", "AutoId", "BrandId", "CarModelId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Descripcion1", "Descripcion2", "FabricaPat", "FactoryId", "IsDeleted", "MODELOPAT", "Marca", "MarcaPat", "Modelo", "Origen", "Terminal", "TipoDeTexto", "UpdatedAt", "UpdatedBy", "ValidoDesde", "ValidoHasta", "VersionPatentamiento", "ZOFMM" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), null, null, null, null, "NOASIGNADO", "NOASIGNADO", null, new Guid("00000000-0000-0000-0000-000000000033"), false, null, null, null, null, null, null, null, null, null, null, null, null, "NOASIGNADO" });

            migrationBuilder.InsertData(
                table: "Tmmv",
                columns: new[] { "Id", "AutoId", "BrandId", "CarModelId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescripcionMarca", "DescripcionModelo", "DescripcionTerminal", "DescripcionVerInt", "DescripcionVerPat", "DescripcionVerWs", "IsDeleted", "MercedesMarcaId", "MercedesModeloId", "MercedesTerminalId", "TerminalId", "UpdatedAt", "UpdatedBy", "VersionInterna", "VersionPatentamiento", "VersionWs" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), null, null, null, null, "NOASIGNADO", "NOASIGNADO", "NOASIGNADO", "NOASIGNADO", "NOASIGNADO", "NOASIGNADO", false, null, null, null, new Guid("00000000-0000-0000-0000-000000000033"), null, null, "NOASIGNADO", "NOASIGNADO", "NOASIGNADO" });

            migrationBuilder.InsertData(
                table: "InternalVersionSegmentations",
                columns: new[] { "Id", "AMGCompSet", "AltBodyst", "AltCateg", "AltSegm", "Apertura1", "Apertura2", "Apertura3", "Apertura4", "AutoId", "AxleBase", "BodyStyle", "CJDCompetitive", "CabinaCF", "CabinaSD", "CategoryId", "CompetitiveCJD", "Configuration", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "DischargeDate", "Doors", "EngineCapacity", "Fuel", "Gears", "Group", "InternalVersionId", "IsDeleted", "MCGTotalMkt", "MercedesCategoriaId", "MercedesSegmentoId", "MercedesVersionInternaId", "MotorDT", "NI", "PBT", "PBT_TN", "Power", "RelevMB", "Rule", "SSegm", "SegmentId", "SegmentationAux1", "SegmentationAux2", "SegmentationAux3", "SegmentationAux4", "SegmentationAux5", "Source", "Traction", "UpdatedAt", "UpdatedBy", "Usage", "Wheelbase" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), null, null, null, null, null, null, null, null, 0, null, null, null, null, null, new Guid("00000000-0000-0000-0000-000000000033"), null, null, null, null, null, null, "NOASIGNADO", null, null, null, null, null, null, new Guid("00000000-0000-0000-0000-000000000033"), false, null, null, null, null, null, null, null, null, null, null, null, null, new Guid("00000000-0000-0000-0000-000000000033"), null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "KeyVersions",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DateFrom", "DateTo", "DeletedAt", "DeletedBy", "DescriptionLong", "DescriptionShort", "InternalVersionSegmentationId", "IsDeleted", "MercedesMarcaId", "MercedesModeloId", "MercedesTerminalId", "MercedesVersionClaveId", "MercedesVersionInternaSegmentacionId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000033"), 0, null, null, null, null, null, null, "NOASIGNADO", "NOASIGNADO", new Guid("00000000-0000-0000-0000-000000000033"), false, null, null, null, null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "KeyVersions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Ofmm",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "RegSecs",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Tmmv",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Factories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "InternalVersionSegmentations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "InternalVersions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Terminals",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));
        }
    }
}
