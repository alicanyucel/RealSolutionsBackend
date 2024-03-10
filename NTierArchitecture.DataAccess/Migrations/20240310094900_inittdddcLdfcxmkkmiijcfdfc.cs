using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTierArchitecture.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class inittdddcLdfcxmkkmiijcfdfc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
