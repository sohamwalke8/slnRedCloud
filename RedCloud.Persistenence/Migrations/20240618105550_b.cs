using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "RateAssignCredit",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "RateAssignCredit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "RateAssignCredit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedBy",
                table: "RateAssignCredit",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "RateAssignCredit",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RateAssignCredit");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "RateAssignCredit");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "RateAssignCredit");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "RateAssignCredit");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "RateAssignCredit");
        }
    }
}
