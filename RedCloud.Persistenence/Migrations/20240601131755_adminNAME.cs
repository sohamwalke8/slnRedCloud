using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class adminNAME : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RedCloudAdmins_ResellerAdminUsers_ResellerAdminUsersResellerAdminUserId",
                table: "RedCloudAdmins");

            migrationBuilder.DropIndex(
                name: "IX_RedCloudAdmins_ResellerAdminUsersResellerAdminUserId",
                table: "RedCloudAdmins");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RedCloudAdmins");

            migrationBuilder.DropColumn(
                name: "ResellerAdminUsersResellerAdminUserId",
                table: "RedCloudAdmins");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RoleMapper",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ResellerAdminUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RedCloudAdmins",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "ResellerAdminUserId",
                table: "RedCloudAdmins",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RedCloudAdmins_ResellerAdminUserId",
                table: "RedCloudAdmins",
                column: "ResellerAdminUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RedCloudAdmins_ResellerAdminUsers_ResellerAdminUserId",
                table: "RedCloudAdmins",
                column: "ResellerAdminUserId",
                principalTable: "ResellerAdminUsers",
                principalColumn: "ResellerAdminUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RedCloudAdmins_ResellerAdminUsers_ResellerAdminUserId",
                table: "RedCloudAdmins");

            migrationBuilder.DropIndex(
                name: "IX_RedCloudAdmins_ResellerAdminUserId",
                table: "RedCloudAdmins");

            migrationBuilder.DropColumn(
                name: "ResellerAdminUserId",
                table: "RedCloudAdmins");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RoleMapper",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ResellerAdminUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RedCloudAdmins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RedCloudAdmins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResellerAdminUsersResellerAdminUserId",
                table: "RedCloudAdmins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RedCloudAdmins_ResellerAdminUsersResellerAdminUserId",
                table: "RedCloudAdmins",
                column: "ResellerAdminUsersResellerAdminUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RedCloudAdmins_ResellerAdminUsers_ResellerAdminUsersResellerAdminUserId",
                table: "RedCloudAdmins",
                column: "ResellerAdminUsersResellerAdminUserId",
                principalTable: "ResellerAdminUsers",
                principalColumn: "ResellerAdminUserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
