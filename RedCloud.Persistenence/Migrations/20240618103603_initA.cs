using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class initA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreditsType_RateAssignCredit_RateAssignCreditId",
                table: "CreditsType");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationAdmins_RateAssignCredit_RateAssignCreditId",
                table: "OrganizationAdmins");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationAdmins_RateAssignCreditId",
                table: "OrganizationAdmins");

            migrationBuilder.DropIndex(
                name: "IX_CreditsType_RateAssignCreditId",
                table: "CreditsType");

            migrationBuilder.DropColumn(
                name: "RateAssignCreditId",
                table: "OrganizationAdmins");

            migrationBuilder.DropColumn(
                name: "RateAssignCreditId",
                table: "CreditsType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RateAssignCreditId",
                table: "OrganizationAdmins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RateAssignCreditId",
                table: "CreditsType",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAdmins_RateAssignCreditId",
                table: "OrganizationAdmins",
                column: "RateAssignCreditId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditsType_RateAssignCreditId",
                table: "CreditsType",
                column: "RateAssignCreditId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreditsType_RateAssignCredit_RateAssignCreditId",
                table: "CreditsType",
                column: "RateAssignCreditId",
                principalTable: "RateAssignCredit",
                principalColumn: "RateAssignCreditId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationAdmins_RateAssignCredit_RateAssignCreditId",
                table: "OrganizationAdmins",
                column: "RateAssignCreditId",
                principalTable: "RateAssignCredit",
                principalColumn: "RateAssignCreditId");
        }
    }
}
