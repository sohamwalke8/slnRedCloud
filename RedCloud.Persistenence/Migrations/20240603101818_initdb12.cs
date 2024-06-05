using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class initdb12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RedCloudAdmin",
                table: "ResellerAdminUsers");

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    RateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rates_ResellerAdminUserId",
                table: "Rates",
                column: "ResellerAdminUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.AddColumn<string>(
                name: "RedCloudAdmin",
                table: "ResellerAdminUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
