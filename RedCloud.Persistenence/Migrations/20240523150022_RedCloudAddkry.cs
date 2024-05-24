using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    /// <inheritdoc />
    public partial class RedCloudAddkry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RedCloudAdmin",
                table: "ResellerAdmin",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RedCloudAdmin",
                table: "ResellerAdmin");
        }
    }
}
