using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asp.NetCore_MVC_Practice.Migrations
{
    /// <inheritdoc />
    public partial class Lastname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "StudentInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "StudentInfo");
        }
    }
}
