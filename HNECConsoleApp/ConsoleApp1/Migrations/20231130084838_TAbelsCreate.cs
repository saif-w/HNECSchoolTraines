using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class TAbelsCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Credit = table.Column<int>(type: "int", nullable: false),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CoursesId);
                });

            migrationBuilder.CreateTable(
                name: "Enrollaments",
                columns: table => new
                {
                    EnrollamentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudintsId = table.Column<int>(type: "int", nullable: true),
                    CoursesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollaments", x => x.EnrollamentId);
                    table.ForeignKey(
                        name: "FK_Enrollaments_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "CoursesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollaments_Studints_StudintsId",
                        column: x => x.StudintsId,
                        principalTable: "Studints",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Instructers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstMiddelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoursesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructers_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "CoursesId");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budjet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstructersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Instructers_InstructersId",
                        column: x => x.InstructersId,
                        principalTable: "Instructers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    InstructersId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.InstructersId);
                    table.ForeignKey(
                        name: "FK_Offices_Instructers_InstructersId",
                        column: x => x.InstructersId,
                        principalTable: "Instructers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentsId",
                table: "Courses",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructersId",
                table: "Departments",
                column: "InstructersId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollaments_CoursesId",
                table: "Enrollaments",
                column: "CoursesId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollaments_StudintsId",
                table: "Enrollaments",
                column: "StudintsId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructers_CoursesId",
                table: "Instructers",
                column: "CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentsId",
                table: "Courses",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentsId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Enrollaments");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Studints");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructers");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
