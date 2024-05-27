using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class reseller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrganizationAdmin",
                columns: table => new
                {
                    OrgID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgAdminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgAdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgAdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgAdminMobNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    OrgURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationAdmin", x => x.OrgID);
                });

            migrationBuilder.CreateTable(
                name: "ReSellerAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResellerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanySupportEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RedCloudAdmin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrgID = table.Column<int>(type: "int", nullable: true),
                    OrganizationAdminsOrgID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReSellerAdmin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReSellerAdmin_OrganizationAdmin_OrganizationAdminsOrgID",
                        column: x => x.OrganizationAdminsOrgID,
                        principalTable: "OrganizationAdmin",
                        principalColumn: "OrgID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReSellerAdmin_OrganizationAdminsOrgID",
                table: "ReSellerAdmin",
                column: "OrganizationAdminsOrgID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReSellerAdmin");

            migrationBuilder.DropTable(
                name: "OrganizationAdmin");
        }
    }
}
