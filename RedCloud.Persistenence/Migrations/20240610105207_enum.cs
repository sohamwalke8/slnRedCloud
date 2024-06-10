using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class @enum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Numbers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Numbers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Numbers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Numbers");
        }
    }
}
