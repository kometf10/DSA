using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.DataAccess.Migrations
{
    public partial class CorpBen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PersonDonators",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorporateBeneficiaryId",
                table: "Donations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CorporateDonators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Beneficiaries",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CorporateBeneficiaries",
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
                    EnName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ActivityId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporateBeneficiaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorporateBeneficiaries_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CorporateBeneficiaries_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    LastModefiedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonationRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    LastModefiedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    donationTypeId = table.Column<int>(nullable: true),
                    IsAccepted = table.Column<bool>(nullable: false),
                    BeneficiaryType = table.Column<string>(nullable: true),
                    BeneficiaryId = table.Column<int>(nullable: true),
                    CorpBeneficiaryId = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationRequests_DonationTypes_donationTypeId",
                        column: x => x.donationTypeId,
                        principalTable: "DonationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donations_CorporateBeneficiaryId",
                table: "Donations",
                column: "CorporateBeneficiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateBeneficiaries_ActivityId",
                table: "CorporateBeneficiaries",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateBeneficiaries_PersonId",
                table: "CorporateBeneficiaries",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationRequests_donationTypeId",
                table: "DonationRequests",
                column: "donationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_CorporateBeneficiaries_CorporateBeneficiaryId",
                table: "Donations",
                column: "CorporateBeneficiaryId",
                principalTable: "CorporateBeneficiaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_CorporateBeneficiaries_CorporateBeneficiaryId",
                table: "Donations");

            migrationBuilder.DropTable(
                name: "CorporateBeneficiaries");

            migrationBuilder.DropTable(
                name: "DonationRequests");

            migrationBuilder.DropTable(
                name: "DonationTypes");

            migrationBuilder.DropIndex(
                name: "IX_Donations_CorporateBeneficiaryId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PersonDonators");

            migrationBuilder.DropColumn(
                name: "CorporateBeneficiaryId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CorporateDonators");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Beneficiaries");
        }
    }
}
