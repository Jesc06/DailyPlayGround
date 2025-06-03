using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Asp.NetCore_MVC_Practice.Migrations
{
    /// <inheritdoc />
    public partial class DbTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentInfo",
                columns: new[] { "Id", "Lastname", "Name", "age" },
                values: new object[,]
                {
                    { 1, "Escarez", "Joshua", 19 },
                    { 2, "Manalo", "Josh", 20 },
                    { 3, "Semilia", "Leodevier", 19 },
                    { 4, "Gaspado", "U Morales", 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentInfo",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
