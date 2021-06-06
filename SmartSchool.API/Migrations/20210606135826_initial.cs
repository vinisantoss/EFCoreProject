using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentEnrollment = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherEnrollment = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    RequiredId = table.Column<int>(type: "int", nullable: true),
                    RequiredDisciplineId = table.Column<int>(type: "int", nullable: true),
                    CourseHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplines_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplines_Disciplines_RequiredDisciplineId",
                        column: x => x.RequiredDisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Disciplines_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsDisciplines",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsDisciplines", x => new { x.StudentId, x.DisciplineId });
                    table.ForeignKey(
                        name: "FK_StudentsDisciplines_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsDisciplines_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[,]
                {
                    { 1, "Ciência da Computação" },
                    { 2, "Sistema de Informação" },
                    { 3, "Engenharia de Software" },
                    { 4, "Arquitetura de Software" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "Phone", "StartDate", "StudentEnrollment", "Surname" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marta", "33225555", new DateTime(2021, 6, 6, 10, 58, 26, 442, DateTimeKind.Local).AddTicks(9491), 1, "Kent" },
                    { 2, true, new DateTime(2010, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paula", "3354288", new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(2058), 2, "Isabela" },
                    { 3, true, new DateTime(2005, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laura", "55668899", new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(2072), 3, "Antonia" },
                    { 4, true, new DateTime(2003, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luiza", "6565659", new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(2077), 4, "Maria" },
                    { 5, true, new DateTime(1999, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lucas", "565685415", new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(2081), 5, "Machado" },
                    { 6, true, new DateTime(1998, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pedro", "456454545", new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(2089), 6, "Alvares" },
                    { 7, true, new DateTime(2000, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paulo", "9874512", new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(2094), 7, "José" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Active", "EndDate", "Name", "Phone", "StartDate", "Surname", "TeacherEnrollment" },
                values: new object[,]
                {
                    { 1, true, null, "Lauro", null, new DateTime(2021, 6, 6, 10, 58, 26, 382, DateTimeKind.Local).AddTicks(7064), "Oliveira", 1 },
                    { 2, true, null, "Roberto", null, new DateTime(2021, 6, 6, 10, 58, 26, 386, DateTimeKind.Local).AddTicks(3486), "Soares", 2 },
                    { 3, true, null, "Ronaldo", null, new DateTime(2021, 6, 6, 10, 58, 26, 386, DateTimeKind.Local).AddTicks(3508), "Marconi", 3 },
                    { 4, true, null, "Rodrigo", null, new DateTime(2021, 6, 6, 10, 58, 26, 386, DateTimeKind.Local).AddTicks(3511), "Carvalho", 4 },
                    { 5, true, null, "Alexandre", null, new DateTime(2021, 6, 6, 10, 58, 26, 386, DateTimeKind.Local).AddTicks(3512), "Montanha", 5 }
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequiredDisciplineId", "RequiredId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 0, 1, "Matemática", null, null, 1 },
                    { 6, 0, 2, "Matemática", null, null, 1 },
                    { 2, 0, 1, "Física", null, null, 2 },
                    { 7, 0, 3, "Física", null, null, 2 },
                    { 3, 0, 1, "Matemática", null, null, 3 },
                    { 8, 0, 3, "Programação", null, null, 3 },
                    { 11, 0, 4, "Lógica", null, null, 3 },
                    { 4, 0, 2, "Inglês", null, null, 4 },
                    { 9, 0, 3, "Programação", null, null, 4 },
                    { 12, 0, 3, "Lógica", null, null, 4 },
                    { 5, 0, 2, "Programação", null, null, 5 },
                    { 10, 0, 4, "Programação", null, null, 5 },
                    { 13, 0, 1, "Lógica", null, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[,]
                {
                    { 1, 2, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4476) },
                    { 5, 4, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4490) },
                    { 5, 2, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4481) },
                    { 5, 1, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4475) },
                    { 4, 7, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4507) },
                    { 4, 6, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4502) },
                    { 4, 5, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4491) },
                    { 4, 4, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4488) },
                    { 4, 1, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4469) },
                    { 3, 7, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4505) },
                    { 5, 5, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4495) },
                    { 3, 6, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4500) },
                    { 2, 7, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4504) },
                    { 2, 6, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4499) },
                    { 2, 3, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4484) },
                    { 2, 2, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4477) },
                    { 2, 1, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(3672) },
                    { 1, 7, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4503) },
                    { 1, 6, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4497) },
                    { 1, 4, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4487) },
                    { 1, 3, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4482) },
                    { 3, 3, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4485) },
                    { 5, 7, null, null, new DateTime(2021, 6, 6, 10, 58, 26, 443, DateTimeKind.Local).AddTicks(4508) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_CourseId",
                table: "Disciplines",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_RequiredDisciplineId",
                table: "Disciplines",
                column: "RequiredDisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_TeacherId",
                table: "Disciplines",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_CourseId",
                table: "StudentsCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsDisciplines_DisciplineId",
                table: "StudentsDisciplines",
                column: "DisciplineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsCourses");

            migrationBuilder.DropTable(
                name: "StudentsDisciplines");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
