using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "AdminUsers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "mobileNumber",
                table: "AdminUsers",
                newName: "MobileNumber");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "AdminUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "AdminUsers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "AdminUsers",
                newName: "Email");

            migrationBuilder.CreateTable(
                name: "OrganizationAdmins",
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
                    OrgURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationAdmins", x => x.OrgID);
                });

            migrationBuilder.CreateTable(
                name: "ReSellerAdmins",
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
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrganizationAdminId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReSellerAdmins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReSellerAdmins_OrganizationAdmins_OrganizationAdminId",
                        column: x => x.OrganizationAdminId,
                        principalTable: "OrganizationAdmins",
                        principalColumn: "OrgID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReSellerAdmins_OrganizationAdminId",
                table: "ReSellerAdmins",
                column: "OrganizationAdminId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReSellerAdmins");

            migrationBuilder.DropTable(
                name: "OrganizationAdmins");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "AdminUsers",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "AdminUsers",
                newName: "mobileNumber");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AdminUsers",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AdminUsers",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "AdminUsers",
                newName: "email");
        }
    }
}
