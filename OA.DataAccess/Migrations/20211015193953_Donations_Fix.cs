using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.DataAccess.Migrations
{
    public partial class Donations_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonationRequests_DonationTypes_donationTypeId",
                table: "DonationRequests");

            migrationBuilder.RenameColumn(
                name: "donationTypeId",
                table: "DonationRequests",
                newName: "DonationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_DonationRequests_donationTypeId",
                table: "DonationRequests",
                newName: "IX_DonationRequests_DonationTypeId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "DonationRequests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsAssigned",
                table: "DonationRequests",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "DonationOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    LastModefiedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DonationRequestId = table.Column<int>(nullable: false),
                    IsAccepted = table.Column<bool>(nullable: false),
                    DonatorType = table.Column<string>(nullable: true),
                    PersonDonatorId = table.Column<int>(nullable: true),
                    CorporateDonatorId = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationOffers_DonationRequests_DonationRequestId",
                        column: x => x.DonationRequestId,
                        principalTable: "DonationRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    LastModefiedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    LastModefiedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OwnerName = table.Column<string>(nullable: true),
                    Papers = table.Column<string>(nullable: true),
                    WorkerCount = table.Column<int>(nullable: false),
                    TimePlan = table.Column<string>(nullable: true),
                    EstimatedCost = table.Column<decimal>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true),
                    SupervisorName = table.Column<string>(nullable: true),
                    SupervisorPhone = table.Column<string>(nullable: true),
                    SupervisorEmail = table.Column<string>(nullable: true),
                    CreatedUserType = table.Column<string>(nullable: true),
                    CreatedUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    LastModefiedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    JobName = table.Column<string>(nullable: true),
                    EmployingInfo = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonationOffers_DonationRequestId",
                table: "DonationOffers",
                column: "DonationRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_PersonId",
                table: "Organizations",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_DonationRequests_DonationTypes_DonationTypeId",
                table: "DonationRequests",
                column: "DonationTypeId",
                principalTable: "DonationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonationRequests_DonationTypes_DonationTypeId",
                table: "DonationRequests");

            migrationBuilder.DropTable(
                name: "DonationOffers");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "DonationRequests");

            migrationBuilder.DropColumn(
                name: "IsAssigned",
                table: "DonationRequests");

            migrationBuilder.RenameColumn(
                name: "DonationTypeId",
                table: "DonationRequests",
                newName: "donationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_DonationRequests_DonationTypeId",
                table: "DonationRequests",
                newName: "IX_DonationRequests_donationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DonationRequests_DonationTypes_donationTypeId",
                table: "DonationRequests",
                column: "donationTypeId",
                principalTable: "DonationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
