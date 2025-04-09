using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContosoPizza.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SetPizza",
                columns: new[] { "Id", "IsGlutenFree", "Name" },
                values: new object[,]
                {
                    { 1, false, "Classic Italian" },
                    { 2, true, "Veggie" },
                    { 3, false, "Hawaiian" },
                    { 4, true, "Extreme Cheese" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SetPizza",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SetPizza",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SetPizza",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SetPizza",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
