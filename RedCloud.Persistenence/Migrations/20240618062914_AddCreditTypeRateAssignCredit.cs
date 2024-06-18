using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class AddCreditTypeRateAssignCredit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignmentTypes",
                columns: table => new
                {
                    AssignmentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentTypes", x => x.AssignmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Carrier",
                columns: table => new
                {
                    CarrierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrierName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrier", x => x.CarrierId);
                });

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
                name: "RateAssignCredit",
                columns: table => new
                {
                    RateAssignCreditId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgID = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    InboundSMS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutboundSMS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InboundMMS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutboundMMS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthlyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Users = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RateAssignCredit", x => x.RateAssignCreditId);
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
                name: "Type",
                columns: table => new
                {
                    TypesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypesName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.TypesId);
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
                name: "CreditsType",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RateAssignCreditId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditsType", x => x.TypeId);
                    table.ForeignKey(
                        name: "FK_CreditsType_RateAssignCredit_RateAssignCreditId",
                        column: x => x.RateAssignCreditId,
                        principalTable: "RateAssignCredit",
                        principalColumn: "RateAssignCreditId");
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
                    RateAssignCreditId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_OrganizationAdmins_RateAssignCredit_RateAssignCreditId",
                        column: x => x.RateAssignCreditId,
                        principalTable: "RateAssignCredit",
                        principalColumn: "RateAssignCreditId");
                    table.ForeignKey(
                        name: "FK_OrganizationAdmins_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "OrganizationUsers",
                columns: table => new
                {
                    OrganizationUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationUserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationUserLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationUserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationUserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrganizationAdminId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationUsers", x => x.OrganizationUserId);
                    table.ForeignKey(
                        name: "FK_OrganizationUsers_OrganizationAdmins_OrganizationAdminId",
                        column: x => x.OrganizationAdminId,
                        principalTable: "OrganizationAdmins",
                        principalColumn: "OrgID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationResellerMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationAdminId = table.Column<int>(type: "int", nullable: false),
                    ResellerAdminUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationResellerMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationResellerMapping_OrganizationAdmins_OrganizationAdminId",
                        column: x => x.OrganizationAdminId,
                        principalTable: "OrganizationAdmins",
                        principalColumn: "OrgID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrganizationResellerMapping_ResellerAdminUsers_ResellerAdminUserId",
                        column: x => x.ResellerAdminUserId,
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

            migrationBuilder.CreateTable(
                name: "ResellerUsers",
                columns: table => new
                {
                    ResellerUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResellerAdminUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResellerUsers", x => x.ResellerUserId);
                    table.ForeignKey(
                        name: "FK_ResellerUsers_ResellerAdminUsers_ResellerAdminUserId",
                        column: x => x.ResellerAdminUserId,
                        principalTable: "ResellerAdminUsers",
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

            migrationBuilder.CreateTable(
                name: "Numbers",
                columns: table => new
                {
                    NumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationAdminID = table.Column<int>(type: "int", nullable: true),
                    ResellerAdminUserId = table.Column<int>(type: "int", nullable: true),
                    TypesId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    AssignmentTypeId = table.Column<int>(type: "int", nullable: true),
                    CarrierId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    LATA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateCenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numbers", x => x.NumberId);
                    table.ForeignKey(
                        name: "FK_Numbers_AssignmentTypes_AssignmentTypeId",
                        column: x => x.AssignmentTypeId,
                        principalTable: "AssignmentTypes",
                        principalColumn: "AssignmentTypeId");
                    table.ForeignKey(
                        name: "FK_Numbers_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignId");
                    table.ForeignKey(
                        name: "FK_Numbers_Carrier_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Carrier",
                        principalColumn: "CarrierId");
                    table.ForeignKey(
                        name: "FK_Numbers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "FK_Numbers_OrganizationAdmins_OrganizationAdminID",
                        column: x => x.OrganizationAdminID,
                        principalTable: "OrganizationAdmins",
                        principalColumn: "OrgID");
                    table.ForeignKey(
                        name: "FK_Numbers_ResellerAdminUsers_ResellerAdminUserId",
                        column: x => x.ResellerAdminUserId,
                        principalTable: "ResellerAdminUsers",
                        principalColumn: "ResellerAdminUserId");
                    table.ForeignKey(
                        name: "FK_Numbers_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId");
                    table.ForeignKey(
                        name: "FK_Numbers_Type_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Type",
                        principalColumn: "TypesId");
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
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditsType_RateAssignCreditId",
                table: "CreditsType",
                column: "RateAssignCreditId");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_AssignmentTypeId",
                table: "Numbers",
                column: "AssignmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_CampaignId",
                table: "Numbers",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_CarrierId",
                table: "Numbers",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_CountryId",
                table: "Numbers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_OrganizationAdminID",
                table: "Numbers",
                column: "OrganizationAdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_ResellerAdminUserId",
                table: "Numbers",
                column: "ResellerAdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_StateId",
                table: "Numbers",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_TypesId",
                table: "Numbers",
                column: "TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmins_CityId",
                table: "OrganizationAdmins",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmins_CountryId",
                table: "OrganizationAdmins",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmins_RateAssignCreditId",
                table: "OrganizationAdmins",
                column: "RateAssignCreditId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmins_StateId",
                table: "OrganizationAdmins",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationResellerMapping_OrganizationAdminId",
                table: "OrganizationResellerMapping",
                column: "OrganizationAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationResellerMapping_ResellerAdminUserId",
                table: "OrganizationResellerMapping",
                column: "ResellerAdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationUsers_OrganizationAdminId",
                table: "OrganizationUsers",
                column: "OrganizationAdminId");

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
                name: "IX_ResellerUsers_ResellerAdminUserId",
                table: "ResellerUsers",
                column: "ResellerAdminUserId");

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
                name: "CreditsType");

            migrationBuilder.DropTable(
                name: "GetRates");

            migrationBuilder.DropTable(
                name: "Numbers");

            migrationBuilder.DropTable(
                name: "OrganizationResellerMapping");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "RedCloudAdmins");

            migrationBuilder.DropTable(
                name: "RoleMapper");

            migrationBuilder.DropTable(
                name: "AssignmentTypes");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Carrier");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "OrganizationUsers");

            migrationBuilder.DropTable(
                name: "ResellerUsers");

            migrationBuilder.DropTable(
                name: "OrganizationAdmins");

            migrationBuilder.DropTable(
                name: "ResellerAdminUsers");

            migrationBuilder.DropTable(
                name: "RateAssignCredit");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
