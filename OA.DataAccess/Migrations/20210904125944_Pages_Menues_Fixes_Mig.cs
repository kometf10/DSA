using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.DataAccess.Migrations
{
    public partial class Pages_Menues_Fixes_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "PageTranslations");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Menues");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Menues");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "PageTranslations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Pages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Menues",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Menues",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "PageTranslations");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Menues");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Menues");

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "PageTranslations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Menues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Menues",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
