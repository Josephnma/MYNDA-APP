using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Mynda.Persistence.Migrations
{
    public partial class AddedUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Education_Education",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Guarantor_Guarantor",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PhotoProfile_PhotoProfile",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Reviews_Review",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WorkExperience_WorkExperience",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Education",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Guarantor",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PhotoProfile",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Review",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WorkExperience",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Allergies",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ClearenceForm",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Disability",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Guarantor",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LGA",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhotoProfile",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SalaryExpectation",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Skills",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StatesWillingToRelocate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkExperience",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Myndas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    Education = table.Column<int>(type: "integer", nullable: false),
                    Guarantor = table.Column<int>(type: "integer", nullable: false),
                    Review = table.Column<int>(type: "integer", nullable: false),
                    PhotoProfile = table.Column<int>(type: "integer", nullable: false),
                    WorkExperience = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Skills = table.Column<string>(type: "text", nullable: true),
                    LGA = table.Column<string>(type: "text", nullable: true),
                    Allergies = table.Column<string>(type: "text", nullable: true),
                    Disability = table.Column<string>(type: "text", nullable: true),
                    SalaryExpectation = table.Column<string>(type: "text", nullable: true),
                    StatesWillingToRelocate = table.Column<string>(type: "text", nullable: true),
                    ClearenceForm = table.Column<string>(type: "text", nullable: true),
                    Religion = table.Column<string>(type: "text", nullable: true),
                    AboutMe = table.Column<string>(type: "text", nullable: true),
                    Height = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Myndas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Myndas_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Myndas_Education_Education",
                        column: x => x.Education,
                        principalTable: "Education",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Myndas_Guarantor_Guarantor",
                        column: x => x.Guarantor,
                        principalTable: "Guarantor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Myndas_PhotoProfile_PhotoProfile",
                        column: x => x.PhotoProfile,
                        principalTable: "PhotoProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Myndas_Reviews_Review",
                        column: x => x.Review,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Myndas_WorkExperience_WorkExperience",
                        column: x => x.WorkExperience,
                        principalTable: "WorkExperience",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Myndas_Education",
                table: "Myndas",
                column: "Education");

            migrationBuilder.CreateIndex(
                name: "IX_Myndas_Guarantor",
                table: "Myndas",
                column: "Guarantor");

            migrationBuilder.CreateIndex(
                name: "IX_Myndas_PhotoProfile",
                table: "Myndas",
                column: "PhotoProfile");

            migrationBuilder.CreateIndex(
                name: "IX_Myndas_Review",
                table: "Myndas",
                column: "Review");

            migrationBuilder.CreateIndex(
                name: "IX_Myndas_UserId",
                table: "Myndas",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Myndas_WorkExperience",
                table: "Myndas",
                column: "WorkExperience");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Myndas");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Allergies",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClearenceForm",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Disability",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Education",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Guarantor",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LGA",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhotoProfile",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Religion",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Review",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SalaryExpectation",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatesWillingToRelocate",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkExperience",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Education",
                table: "AspNetUsers",
                column: "Education");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Guarantor",
                table: "AspNetUsers",
                column: "Guarantor");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PhotoProfile",
                table: "AspNetUsers",
                column: "PhotoProfile");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Review",
                table: "AspNetUsers",
                column: "Review");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WorkExperience",
                table: "AspNetUsers",
                column: "WorkExperience");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Education_Education",
                table: "AspNetUsers",
                column: "Education",
                principalTable: "Education",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Guarantor_Guarantor",
                table: "AspNetUsers",
                column: "Guarantor",
                principalTable: "Guarantor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PhotoProfile_PhotoProfile",
                table: "AspNetUsers",
                column: "PhotoProfile",
                principalTable: "PhotoProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Reviews_Review",
                table: "AspNetUsers",
                column: "Review",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WorkExperience_WorkExperience",
                table: "AspNetUsers",
                column: "WorkExperience",
                principalTable: "WorkExperience",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
