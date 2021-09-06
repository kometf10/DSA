using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.DataAccess.Migrations
{
    public partial class Events_Fix_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "EventCategories");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "EventCategories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "EventCategories");

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "EventCategories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
