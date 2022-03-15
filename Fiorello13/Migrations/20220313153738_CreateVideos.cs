using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello13.Migrations
{
    public partial class CreateVideos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Gifts");

            migrationBuilder.CreateTable(
                name: "Gift_Videos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gift_Videos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gift_Videos");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Gifts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
