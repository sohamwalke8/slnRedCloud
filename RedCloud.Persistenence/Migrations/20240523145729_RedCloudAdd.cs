using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class RedCloudAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReSellerAdmins_OrganizationAdmins_OrganizationAdminId",
                table: "ReSellerAdmins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReSellerAdmins",
                table: "ReSellerAdmins");

            migrationBuilder.RenameTable(
                name: "ReSellerAdmins",
                newName: "ResellerAdmin");

            migrationBuilder.RenameIndex(
                name: "IX_ReSellerAdmins_OrganizationAdminId",
                table: "ResellerAdmin",
                newName: "IX_ResellerAdmin_OrganizationAdminId");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "OrganizationAdmins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResellerAdmin",
                table: "ResellerAdmin",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResellerAdmin_OrganizationAdmins_OrganizationAdminId",
                table: "ResellerAdmin",
                column: "OrganizationAdminId",
                principalTable: "OrganizationAdmins",
                principalColumn: "OrgID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResellerAdmin_OrganizationAdmins_OrganizationAdminId",
                table: "ResellerAdmin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResellerAdmin",
                table: "ResellerAdmin");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "OrganizationAdmins");

            migrationBuilder.RenameTable(
                name: "ResellerAdmin",
                newName: "ReSellerAdmins");

            migrationBuilder.RenameIndex(
                name: "IX_ResellerAdmin_OrganizationAdminId",
                table: "ReSellerAdmins",
                newName: "IX_ReSellerAdmins_OrganizationAdminId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReSellerAdmins",
                table: "ReSellerAdmins",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReSellerAdmins_OrganizationAdmins_OrganizationAdminId",
                table: "ReSellerAdmins",
                column: "OrganizationAdminId",
                principalTable: "OrganizationAdmins",
                principalColumn: "OrgID");
        }
    }
}
