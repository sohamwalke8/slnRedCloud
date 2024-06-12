using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class latestdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "GetRates",
                columns: table => new
                {
                    GetRateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GetResellerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GetMonthlyNumber = table.Column<int>(type: "int", nullable: false),
                    GetUsers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetRates", x => x.GetRateId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_States_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RoleMapper",
                columns: table => new
                {
                    RoleMapperId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMapper", x => x.RoleMapperId);
                    table.ForeignKey(
                        name: "FK_RoleMapper_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RoleMapper_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.NoAction);
                });

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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrganizationAdmins_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ResellerAdminUsers",
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
                    table.PrimaryKey("PK_ResellerAdminUsers", x => x.ResellerAdminUserId);
                    table.ForeignKey(
                        name: "FK_ResellerAdminUsers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ResellerAdminUsers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ResellerAdminUsers_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Campaign",
                columns: table => new
                {
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgID = table.Column<int>(type: "int", nullable: false),
                    OrganizationAdminOrgID = table.Column<int>(type: "int", nullable: false),
                    ResellerAdminUserId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversalEIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    IdentityStatus = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Campaign", x => x.CampaignId);
                    table.ForeignKey(
                        name: "FK_Campaign_OrganizationAdmins_OrganizationAdminOrgID",
                        column: x => x.OrganizationAdminOrgID,
                        principalTable: "OrganizationAdmins",
                        principalColumn: "OrgID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Campaign_ResellerAdminUsers_ResellerAdminUserId",
                        column: x => x.ResellerAdminUserId,
                        principalTable: "ResellerAdminUsers",
                        principalColumn: "ResellerAdminUserId",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrganizationAdminResellerAdminUser_ResellerAdminUsers_ResellerAdminUsersResellerAdminUserId",
                        column: x => x.ResellerAdminUsersResellerAdminUserId,
                        principalTable: "ResellerAdminUsers",
                        principalColumn: "ResellerAdminUserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    RateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResellerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResellerAdminUserId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InboundSMS = table.Column<int>(type: "int", nullable: false),
                    OutboundSMS = table.Column<int>(type: "int", nullable: false),
                    InboundMMS = table.Column<int>(type: "int", nullable: false),
                    OutboundMMS = table.Column<int>(type: "int", nullable: false),
                    MonthlyNumber = table.Column<int>(type: "int", nullable: false),
                    Users = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.RateId);
                    table.ForeignKey(
                        name: "FK_Rates_ResellerAdminUsers_ResellerAdminUserId",
                        column: x => x.ResellerAdminUserId,
                        principalTable: "ResellerAdminUsers",
                        principalColumn: "ResellerAdminUserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RedCloudAdmins",
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
                    table.PrimaryKey("PK_RedCloudAdmins", x => x.RedCloudAdminUserId);
                    table.ForeignKey(
                        name: "FK_RedCloudAdmins_ResellerAdminUsers_ResellerAdminUserId",
                        column: x => x.ResellerAdminUserId,
                        principalTable: "ResellerAdminUsers",
                        principalColumn: "ResellerAdminUserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_OrganizationAdminOrgID",
                table: "Campaign",
                column: "OrganizationAdminOrgID");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_ResellerAdminUserId",
                table: "Campaign",
                column: "ResellerAdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Rates_ResellerAdminUserId",
                table: "Rates",
                column: "ResellerAdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RedCloudAdmins_ResellerAdminUserId",
                table: "RedCloudAdmins",
                column: "ResellerAdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResellerAdminUsers_CityId",
                table: "ResellerAdminUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ResellerAdminUsers_CountryId",
                table: "ResellerAdminUsers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ResellerAdminUsers_StateId",
                table: "ResellerAdminUsers",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMapper_RoleId",
                table: "RoleMapper",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMapper_UserId",
                table: "RoleMapper",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId",
                table: "States",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campaign");

            migrationBuilder.DropTable(
                name: "GetRates");

            migrationBuilder.DropTable(
                name: "OrganizationAdminResellerAdminUser");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "RedCloudAdmins");

            migrationBuilder.DropTable(
                name: "RoleMapper");

            migrationBuilder.DropTable(
                name: "OrganizationAdmins");

            migrationBuilder.DropTable(
                name: "ResellerAdminUsers");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
