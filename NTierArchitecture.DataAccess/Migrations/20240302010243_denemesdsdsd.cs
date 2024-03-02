using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTierArchitecture.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class denemesdsdsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Roles");
        }
    }
}
