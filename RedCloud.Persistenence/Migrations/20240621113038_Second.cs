using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RateAssignCredit_CreditsType_CreditsTypeTypeId",
                table: "RateAssignCredit");

            migrationBuilder.DropForeignKey(
                name: "FK_RateAssignCredit_OrganizationAdmins_OrganizationAdminOrgID",
                table: "RateAssignCredit");

            migrationBuilder.DropIndex(
                name: "IX_RateAssignCredit_CreditsTypeTypeId",
                table: "RateAssignCredit");

            migrationBuilder.DropIndex(
                name: "IX_RateAssignCredit_OrganizationAdminOrgID",
                table: "RateAssignCredit");

            migrationBuilder.DropColumn(
                name: "CreditsTypeTypeId",
                table: "RateAssignCredit");

            migrationBuilder.DropColumn(
                name: "OrganizationAdminOrgID",
                table: "RateAssignCredit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreditsTypeTypeId",
                table: "RateAssignCredit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationAdminOrgID",
                table: "RateAssignCredit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RateAssignCredit_CreditsTypeTypeId",
                table: "RateAssignCredit",
                column: "CreditsTypeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RateAssignCredit_OrganizationAdminOrgID",
                table: "RateAssignCredit",
                column: "OrganizationAdminOrgID");

            migrationBuilder.AddForeignKey(
                name: "FK_RateAssignCredit_CreditsType_CreditsTypeTypeId",
                table: "RateAssignCredit",
                column: "CreditsTypeTypeId",
                principalTable: "CreditsType",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RateAssignCredit_OrganizationAdmins_OrganizationAdminOrgID",
                table: "RateAssignCredit",
                column: "OrganizationAdminOrgID",
                principalTable: "OrganizationAdmins",
                principalColumn: "OrgID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
