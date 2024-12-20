using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCH.MercedesBenz.Api.Migrations
{
    /// <inheritdoc />
    public partial class OdsOwnerClassificationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OdsOwnerClassifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    CuitOwner = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Owner = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: false),
                    MercedesLegalEntity = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    LegalEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesGovernmentalClassification = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    GovernmentalClassificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesSubgovernmentalClassification = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    SubgovernmentalClassificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesCuitClassification = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    CuitClassificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aperture1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    ApertureOneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aperture2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    ApertureTwoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesLogisticClassification = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    LogisticClassificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercedesEstimatedTurnover = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    EstimatedTurnoverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocialContractDate = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    EmployeesInfo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_OdsOwnerClassifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OdsOwnerClassifications_AperturesOne_ApertureOneId",
                        column: x => x.ApertureOneId,
                        principalTable: "AperturesOne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsOwnerClassifications_AperturesTwo_ApertureTwoId",
                        column: x => x.ApertureTwoId,
                        principalTable: "AperturesTwo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsOwnerClassifications_CuitClassifications_CuitClassificationId",
                        column: x => x.CuitClassificationId,
                        principalTable: "CuitClassifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsOwnerClassifications_EstimatedTurnovers_EstimatedTurnoverId",
                        column: x => x.EstimatedTurnoverId,
                        principalTable: "EstimatedTurnovers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsOwnerClassifications_GovernmentalClassifications_GovernmentalClassificationId",
                        column: x => x.GovernmentalClassificationId,
                        principalTable: "GovernmentalClassifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsOwnerClassifications_LegalEntities_LegalEntityId",
                        column: x => x.LegalEntityId,
                        principalTable: "LegalEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsOwnerClassifications_LogisticClassifications_LogisticClassificationId",
                        column: x => x.LogisticClassificationId,
                        principalTable: "LogisticClassifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdsOwnerClassifications_SubgovernmentalClassifications_SubgovernmentalClassificationId",
                        column: x => x.SubgovernmentalClassificationId,
                        principalTable: "SubgovernmentalClassifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OdsOwnerClassifications_ApertureOneId",
                table: "OdsOwnerClassifications",
                column: "ApertureOneId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsOwnerClassifications_ApertureTwoId",
                table: "OdsOwnerClassifications",
                column: "ApertureTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsOwnerClassifications_CuitClassificationId",
                table: "OdsOwnerClassifications",
                column: "CuitClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsOwnerClassifications_EstimatedTurnoverId",
                table: "OdsOwnerClassifications",
                column: "EstimatedTurnoverId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsOwnerClassifications_GovernmentalClassificationId",
                table: "OdsOwnerClassifications",
                column: "GovernmentalClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsOwnerClassifications_LegalEntityId",
                table: "OdsOwnerClassifications",
                column: "LegalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsOwnerClassifications_LogisticClassificationId",
                table: "OdsOwnerClassifications",
                column: "LogisticClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_OdsOwnerClassifications_SubgovernmentalClassificationId",
                table: "OdsOwnerClassifications",
                column: "SubgovernmentalClassificationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OdsOwnerClassifications");
        }
    }
}
