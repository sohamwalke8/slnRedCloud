using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            

            

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                });

            

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationAdmin",
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
                    table.PrimaryKey("PK_OrganizationAdmin", x => x.OrgID);
                    table.ForeignKey(
                        name: "FK_OrganizationAdmin_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId");
                    table.ForeignKey(
                        name: "FK_OrganizationAdmin_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrganizationAdmin_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ResellerAdminUser",
                columns: table => new
                {
                    ResellerAdminUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResellerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanySupportEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RedCloudAdmin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResellerAdminUser", x => x.ResellerAdminUserId);
                    table.ForeignKey(
                        name: "FK_ResellerAdminUser_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ResellerAdminUser_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ResellerAdminUser_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationUsers",
                columns: table => new
                {
                    OrganizationUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationUserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationUserLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationUserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationID = table.Column<int>(type: "int", nullable: true),
                    OrganizationAdminOrgID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationUsers", x => x.OrganizationUserId);
                    table.ForeignKey(
                        name: "FK_OrganizationUsers_OrganizationAdmin_OrganizationAdminOrgID",
                        column: x => x.OrganizationAdminOrgID,
                        principalTable: "OrganizationAdmin",
                        principalColumn: "OrgID",
                        onDelete: ReferentialAction.NoAction);
                });

           

            migrationBuilder.CreateTable(
                name: "RedCloudAdmin",
                columns: table => new
                {
                    RedCloudAdminUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ResellerAdminUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedCloudAdmin", x => x.RedCloudAdminUserId);
                    table.ForeignKey(
                        name: "FK_RedCloudAdmin_ResellerAdminUser_ResellerAdminUserId",
                        column: x => x.ResellerAdminUserId,
                        principalTable: "ResellerAdminUser",
                        principalColumn: "ResellerAdminUserId");
                });

            migrationBuilder.CreateTable(
                name: "ResellerUsers",
                columns: table => new
                {
                    ResellerUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResellerAdminUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResellerUsers", x => x.ResellerUserId);
                    table.ForeignKey(
                        name: "FK_ResellerUsers_ResellerAdminUser_ResellerAdminUserId",
                        column: x => x.ResellerAdminUserId,
                        principalTable: "ResellerAdminUser",
                        principalColumn: "ResellerAdminUserId");
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationUserId = table.Column<int>(type: "int", nullable: false),
                    ResellerUserId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversalEIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    IdentityStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandRelationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandRegistrationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CampaignIdOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampaignIdTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseCaseOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseCaseTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDateOne = table.Column<DateOnly>(type: "date", nullable: false),
                    RegistrationDateTwo = table.Column<DateOnly>(type: "date", nullable: true),
                    RenewalDateOne = table.Column<DateOnly>(type: "date", nullable: false),
                    RenewalDateTwo = table.Column<DateOnly>(type: "date", nullable: true),
                    CampaignDescriptionOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampaignDescriptionTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.CampaignId);
                    table.ForeignKey(
                        name: "FK_Campaigns_OrganizationUsers_OrganizationUserId",
                        column: x => x.OrganizationUserId,
                        principalTable: "OrganizationUsers",
                        principalColumn: "OrganizationUserId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Campaigns_ResellerUsers_ResellerUserId",
                        column: x => x.ResellerUserId,
                        principalTable: "ResellerUsers",
                        principalColumn: "ResellerUserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_OrganizationUserId",
                table: "Campaigns",
                column: "OrganizationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_ResellerUserId",
                table: "Campaigns",
                column: "ResellerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                table: "City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmin_CityId",
                table: "OrganizationAdmin",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmin_CountryId",
                table: "OrganizationAdmin",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmin_StateId",
                table: "OrganizationAdmin",
                column: "StateId");

            

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationUsers_OrganizationAdminOrgID",
                table: "OrganizationUsers",
                column: "OrganizationAdminOrgID");

            migrationBuilder.CreateIndex(
                name: "IX_RedCloudAdmin_ResellerAdminUserId",
                table: "RedCloudAdmin",
                column: "ResellerAdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResellerAdminUser_CityId",
                table: "ResellerAdminUser",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ResellerAdminUser_CountryId",
                table: "ResellerAdminUser",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ResellerAdminUser_StateId",
                table: "ResellerAdminUser",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ResellerUsers_ResellerAdminUserId",
                table: "ResellerUsers",
                column: "ResellerAdminUserId");

           

           

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                table: "State",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "OrganizationAdminResellerAdminUser");

            migrationBuilder.DropTable(
                name: "RedCloudAdmin");

            migrationBuilder.DropTable(
                name: "RoleMapper");

            migrationBuilder.DropTable(
                name: "OrganizationUsers");

            migrationBuilder.DropTable(
                name: "ResellerUsers");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "OrganizationAdmin");

            migrationBuilder.DropTable(
                name: "ResellerAdminUser");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
