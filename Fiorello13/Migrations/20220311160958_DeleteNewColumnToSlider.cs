using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello13.Migrations
{
    public partial class DeleteNewColumnToSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Sliders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
