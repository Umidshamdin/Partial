using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello13.Migrations
{
    public partial class Changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Button",
                table: "Subscripts");

            migrationBuilder.DropColumn(
                name: "Main",
                table: "Subscripts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Button",
                table: "Subscripts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Main",
                table: "Subscripts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
