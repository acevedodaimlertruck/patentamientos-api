using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    MercedesTerminalId = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    MercedesMarcaId = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    MercedesTerminalId = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    MercedesMarcaId = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    MercedesModeloId = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
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
                    table.PrimaryKey("PK_FileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    CUIT = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
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
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    Ordering = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    MercedesProvinciaId = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
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
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RuleTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
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
                    table.PrimaryKey("PK_RuleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    SessionTime = table.Column<int>(type: "int", nullable: false),
                    NumberLogins = table.Column<int>(type: "int", nullable: false),
                    MinCharacters = table.Column<int>(type: "int", nullable: false),
                    MaxCharacters = table.Column<int>(type: "int", nullable: false),
                    IncludeCapitalLetter = table.Column<bool>(type: "bit", nullable: false),
                    IncludeNumbers = table.Column<bool>(type: "bit", nullable: false),
                    IncludeSpecialCharacters = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_SecurityParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatePatentas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
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
                    table.PrimaryKey("PK_StatePatentas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terminals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    MercedesTerminalId = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_Terminals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_VehicleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Status = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    RecordQuantity = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    URL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Date = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    Day = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    Month = table.Column<string>(type: "varchar(24)", unicode: false, maxLength: 24, nullable: false),
                    Year = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    FileTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileUpload = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
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
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_FileTypes_FileTypeID",
                        column: x => x.FileTypeID,
                        principalTable: "FileTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    MercedesFabricaId = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Factories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factories_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Pin = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Biometric = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Surname = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    PhoneCountryCode = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    PhoneAreaCode = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    FullPhoneNumber = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true),
                    Photo = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true),
                    Dni = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    RuleTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Rules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rules_RuleTypes_RuleTypeId",
                        column: x => x.RuleTypeId,
                        principalTable: "RuleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dailies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Source = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Plate = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Motor = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    Chassis = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    FMM_MTM = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Factory_D = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    Brand_D = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Model_D = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    Type_D = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Reg_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegSec = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Desc_Reg = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Desc_Prov = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Taxi = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CUIT = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
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
                    table.PrimaryKey("PK_Dailies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dailies_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    FileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    UserName = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
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
                    table.PrimaryKey("PK_EventFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventFiles_Files_FileID",
                        column: x => x.FileID,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monthlies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Source = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Plate = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Motor = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    Chassis = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    FMM_MTM = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Factory_D = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    Brand_D = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Model_D = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    Type_D = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Reg_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegSec = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Desc_Reg = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Mode = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Owner = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    CUIT_PREF = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    COD_PRO = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    DESC_PROV = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    COD_DPT = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    DESC_DPT = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    COD_LOC = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    DESC_LOC = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    City = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Zip = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Year_Model = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CodCar = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CountryFA = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CountryPR = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Weight = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CUIT = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
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
                    table.PrimaryKey("PK_Monthlies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monthlies_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wholesales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YearMonth = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CodBrand = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Brand = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    CodModel = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Model = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    CodTrademark = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Trademark = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
                    DoorsQty = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Engine = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    MotorType = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    FuelType = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Power = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    PowerUnit = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    VehicleType = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Traction = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    GearsQty = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    TransmissionType = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    AxleQty = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Weight = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    LoadCapacity = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Category = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Origin = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    InitialStock = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Import_ProdMonth = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Import_ProdAccum = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MonthlySale = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MonthlyAccum = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ExportMonthly = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ExportAccum = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    SavingSystemMonthly = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    SavingSystemAccum = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    FinalStock = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NoOkStock = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
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
                    table.PrimaryKey("PK_Wholesales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wholesales_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patentings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FactoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Plate = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Motor = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Chasis = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    OFMM = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatePatentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TerminalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Patentings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patentings_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patentings_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patentings_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patentings_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patentings_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patentings_StatePatentas_StatePatentaId",
                        column: x => x.StatePatentaId,
                        principalTable: "StatePatentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patentings_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patentings_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RulePatenting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    RuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatentingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_RulePatenting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RulePatenting_Patentings_PatentingId",
                        column: x => x.PatentingId,
                        principalTable: "Patentings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RulePatenting_Rules_RuleId",
                        column: x => x.RuleId,
                        principalTable: "Rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FileTypes",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000010"), 0, null, null, null, null, null, false, "Diario", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000020"), 0, null, null, null, null, null, false, "Venta", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000030"), 0, null, null, null, null, null, false, "Mensual", null, null }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "Ordering", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, "Inicio", false, "Inicio", 100, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, null, null, null, "Administración", false, "Administración", 200, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 0, null, null, null, null, "Seguridad", false, "Seguridad", 400, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 0, null, null, null, null, "Seguridad > Roles y Permisos", false, "Seguridad > Roles y Permisos", 500, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), 0, null, null, null, null, "Seguridad > Roles y Permisos > Agregar Rol", false, "Seguridad > Roles y Permisos > Agregar Rol", 501, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), 0, null, null, null, null, "Seguridad > Roles y Permisos > Editar Rol", false, "Seguridad > Roles y Permisos > Editar Rol", 502, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), 0, null, null, null, null, "Seguridad > Roles y Permisos > Eliminar Rol", false, "Seguridad > Roles y Permisos > Eliminar Rol", 503, null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, "Super Admin", false, "Super Admin", null, null });

            migrationBuilder.InsertData(
                table: "RuleTypes",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, null, false, "RulePatenta", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, null, null, null, null, false, "RuleMensual", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 0, null, null, null, null, null, false, "RuleWhosale", null, null }
                });

            migrationBuilder.InsertData(
                table: "SecurityParameters",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IncludeCapitalLetter", "IncludeNumbers", "IncludeSpecialCharacters", "IsDeleted", "MaxCharacters", "MinCharacters", "NumberLogins", "SessionTime", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, true, true, true, false, 12, 6, 3, 3, null, null });

            migrationBuilder.InsertData(
                table: "StatePatentas",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, null, false, "Borrador", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, null, null, null, null, false, "Error", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 0, null, null, null, null, null, false, "Exito", null, null }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "PermissionId", "RoleId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), null, null, null, null, false, new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), null, null, null, null, false, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), null, null, null, null, false, new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), null, null, null, null, false, new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), null, null, null, null, false, new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), null, null, null, null, false, new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), null, null, null, null, false, new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001"), null, null }
                });

            migrationBuilder.InsertData(
                table: "Rules",
                columns: new[] { "Id", "AutoId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "RuleTypeId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, null, null, null, null, false, "OFFM No Existente", new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, null, null, null, null, false, "Fecha Atrasada en un año", new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 0, null, null, null, null, null, false, "Mes Fecha Inscripción mayor al mes de la fecha de corte", new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 0, null, null, null, null, null, false, "Dominio duplicado ya ha sido cargado", new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), 0, null, null, null, null, null, false, "Chasis duplicado ya ha sido cargado", new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), 0, null, null, null, null, null, false, "Dominio duplicado en el mismo archivo", new Guid("00000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), 0, null, null, null, null, null, false, "Chasis en blanco", new Guid("00000000-0000-0000-0000-000000000001"), null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AutoId", "Biometric", "Birthdate", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Dni", "Email", "FullPhoneNumber", "IsDeleted", "Name", "Password", "PhoneAreaCode", "PhoneCountryCode", "PhoneNumber", "Photo", "Pin", "RoleId", "Surname", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "", null, null, false, "Super", new byte[] { 99, 229, 77, 38, 236, 34, 30, 130, 162, 65, 112, 126, 122, 27, 217, 175, 222, 92, 14, 28, 77, 68, 113, 218, 33, 239, 146, 85, 148, 167, 119, 114 }, null, null, null, null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Admin", null, null, "superadmin" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "", null, null, false, "Usuario", new byte[] { 94, 136, 72, 152, 218, 40, 4, 113, 81, 208, 229, 111, 141, 198, 41, 39, 115, 96, 61, 13, 106, 171, 189, 214, 42, 17, 239, 114, 29, 21, 66, 216 }, null, null, null, null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Usuario", null, null, "usuario" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dailies_FileId",
                table: "Dailies",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_EventFiles_FileID",
                table: "EventFiles",
                column: "FileID");

            migrationBuilder.CreateIndex(
                name: "IX_EventFiles_Id",
                table: "EventFiles",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Factories_ProvinceId",
                table: "Factories",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FileTypeID",
                table: "Files",
                column: "FileTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_Id",
                table: "Files",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileTypes_Name",
                table: "FileTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Monthlies_FileId",
                table: "Monthlies",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_BrandId",
                table: "Patentings",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_CarModelId",
                table: "Patentings",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_FactoryId",
                table: "Patentings",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_FileId",
                table: "Patentings",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_OwnerId",
                table: "Patentings",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_StatePatentaId",
                table: "Patentings",
                column: "StatePatentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_TerminalId",
                table: "Patentings",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_Patentings_VehicleTypeId",
                table: "Patentings",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_Name",
                table: "Permissions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleId",
                table: "RolePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RulePatenting_PatentingId",
                table: "RulePatenting",
                column: "PatentingId");

            migrationBuilder.CreateIndex(
                name: "IX_RulePatenting_RuleId",
                table: "RulePatenting",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_Name",
                table: "Rules",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rules_RuleTypeId",
                table: "Rules",
                column: "RuleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RuleTypes_Name",
                table: "RuleTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StatePatentas_Name",
                table: "StatePatentas",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wholesales_FileId",
                table: "Wholesales",
                column: "FileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dailies");

            migrationBuilder.DropTable(
                name: "EventFiles");

            migrationBuilder.DropTable(
                name: "Monthlies");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "RulePatenting");

            migrationBuilder.DropTable(
                name: "SecurityParameters");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Wholesales");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Patentings");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Factories");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "StatePatentas");

            migrationBuilder.DropTable(
                name: "Terminals");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "RuleTypes");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "FileTypes");
        }
    }
}
