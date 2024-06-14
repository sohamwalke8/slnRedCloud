using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class RateAssignCredit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreditsType_RateAssignCredit_RateAssignCreditId",
                table: "CreditsType");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationAdmins_RateAssignCredit_RateAssignCreditId",
                table: "OrganizationAdmins");

            migrationBuilder.DropTable(
                name: "RateAssignCredit");

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
    }
}
