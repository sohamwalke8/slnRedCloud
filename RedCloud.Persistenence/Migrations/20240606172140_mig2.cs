using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Numbers_OrganizationAdmins_OrganizationAdminID",
                table: "Numbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Numbers_ResellerAdminUsers_ResellerAdminUserId",
                table: "Numbers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationAdmins_States_StateId",
                table: "OrganizationAdmins");

            migrationBuilder.AlterColumn<int>(
                name: "ResellerAdminUserId",
                table: "Numbers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationAdminID",
                table: "Numbers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Numbers_OrganizationAdmins_OrganizationAdminID",
                table: "Numbers",
                column: "OrganizationAdminID",
                principalTable: "OrganizationAdmins",
                principalColumn: "OrgID");

            migrationBuilder.AddForeignKey(
                name: "FK_Numbers_ResellerAdminUsers_ResellerAdminUserId",
                table: "Numbers",
                column: "ResellerAdminUserId",
                principalTable: "ResellerAdminUsers",
                principalColumn: "ResellerAdminUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationAdmins_States_StateId",
                table: "OrganizationAdmins",
                column: "StateId",
                principalTable: "States",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Numbers_OrganizationAdmins_OrganizationAdminID",
                table: "Numbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Numbers_ResellerAdminUsers_ResellerAdminUserId",
                table: "Numbers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationAdmins_States_StateId",
                table: "OrganizationAdmins");

            migrationBuilder.AlterColumn<int>(
                name: "ResellerAdminUserId",
                table: "Numbers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationAdminID",
                table: "Numbers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Numbers_OrganizationAdmins_OrganizationAdminID",
                table: "Numbers",
                column: "OrganizationAdminID",
                principalTable: "OrganizationAdmins",
                principalColumn: "OrgID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Numbers_ResellerAdminUsers_ResellerAdminUserId",
                table: "Numbers",
                column: "ResellerAdminUserId",
                principalTable: "ResellerAdminUsers",
                principalColumn: "ResellerAdminUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationAdmins_States_StateId",
                table: "OrganizationAdmins",
                column: "StateId",
                principalTable: "States",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
