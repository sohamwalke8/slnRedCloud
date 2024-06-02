using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class changesinentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrganizationAdmins",
                columns: table => new
                {
                    OrgID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgAdminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgAdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgAdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgAdminMobNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationAdmins", x => x.OrgID);
                    table.ForeignKey(
                        name: "FK_OrganizationAdmins_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId");
                    table.ForeignKey(
                        name: "FK_OrganizationAdmins_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationAdmins_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationAdminResellerAdminUser",
                columns: table => new
                {
                    OrganizationAdminsOrgID = table.Column<int>(type: "int", nullable: false),
                    ResellerAdminUsersResellerAdminUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationAdminResellerAdminUser", x => new { x.OrganizationAdminsOrgID, x.ResellerAdminUsersResellerAdminUserId });
                    table.ForeignKey(
                        name: "FK_OrganizationAdminResellerAdminUser_OrganizationAdmins_OrganizationAdminsOrgID",
                        column: x => x.OrganizationAdminsOrgID,
                        principalTable: "OrganizationAdmins",
                        principalColumn: "OrgID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationAdminResellerAdminUser_ResellerAdminUsers_ResellerAdminUsersResellerAdminUserId",
                        column: x => x.ResellerAdminUsersResellerAdminUserId,
                        principalTable: "ResellerAdminUsers",
                        principalColumn: "ResellerAdminUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdminResellerAdminUser_ResellerAdminUsersResellerAdminUserId",
                table: "OrganizationAdminResellerAdminUser",
                column: "ResellerAdminUsersResellerAdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmins_CityId",
                table: "OrganizationAdmins",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmins_CountryId",
                table: "OrganizationAdmins",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmins_StateId",
                table: "OrganizationAdmins",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationAdminResellerAdminUser");

            migrationBuilder.DropTable(
                name: "OrganizationAdmins");
        }
    }
}
