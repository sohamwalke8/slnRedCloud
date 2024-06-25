using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class rateassigncredit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditsType",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditsType", x => x.TypeId);
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
                    Users = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RateAssignCredit", x => x.RateAssignCreditId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditsType");

            migrationBuilder.DropTable(
                name: "RateAssignCredit");
        }
    }
}
