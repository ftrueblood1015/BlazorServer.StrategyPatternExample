using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServer.StrategyPatternExample.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 1, "6 foot 3 inches", true, "Billy " });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 2, "6 foot 2 inches", true, "Fred " });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 3, "Blonde", true, "Bob " });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 4, "Bernet", true, "Jen " });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 5, "Skinny", true, "Penny " });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 6, "Pudgey", true, "Wilma " });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 7, "Nerd", true, "Todd " });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 8, "Jock", true, "Chad " });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 9, "Engineer", true, "Ellen " });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 10, "Poet", true, "Lou " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
