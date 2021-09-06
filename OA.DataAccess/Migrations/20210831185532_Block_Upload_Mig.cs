using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.DataAccess.Migrations
{
    public partial class Block_Upload_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Blocks");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Blocks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Blocks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Blocks");

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Blocks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Blocks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
