using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServer.StrategyPatternExample.Migrations
{
    public partial class SeedingExportTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExportTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ExportTypes",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 1, "CSV", true, "CSV " });

            migrationBuilder.InsertData(
                table: "ExportTypes",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 2, "Text", true, "TEXT " });

            migrationBuilder.InsertData(
                table: "ExportTypes",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 3, "JSON", true, "JSON " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExportTypes");
        }
    }
}
