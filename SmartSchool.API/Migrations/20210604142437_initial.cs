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
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentEnrollment = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeacherEnrollment = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    RequiredId = table.Column<int>(type: "INTEGER", nullable: true),
                    RequeridDisciplineId = table.Column<int>(type: "INTEGER", nullable: true),
                    CourseHours = table.Column<int>(type: "INTEGER", nullable: false)
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
                        name: "FK_Disciplines_Disciplines_RequeridDisciplineId",
                        column: x => x.RequeridDisciplineId,
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
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplineId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Grade = table.Column<int>(type: "INTEGER", nullable: true)
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
                values: new object[] { 1, "Ciência da Computação" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 2, "Sistema de Informação" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 3, "Engenharia de Software" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "Phone", "StartDate", "StudentEnrollment", "Surname" },
                values: new object[] { 1, true, new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marta", "33225555", new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(1066), 1, "Kent" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "Phone", "StartDate", "StudentEnrollment", "Surname" },
                values: new object[] { 2, true, new DateTime(2010, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paula", "3354288", new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3758), 2, "Isabela" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "Phone", "StartDate", "StudentEnrollment", "Surname" },
                values: new object[] { 3, true, new DateTime(2005, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laura", "55668899", new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3777), 3, "Antonia" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "Phone", "StartDate", "StudentEnrollment", "Surname" },
                values: new object[] { 4, true, new DateTime(2003, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luiza", "6565659", new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3782), 4, "Maria" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "Phone", "StartDate", "StudentEnrollment", "Surname" },
                values: new object[] { 5, true, new DateTime(1999, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lucas", "565685415", new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3786), 5, "Machado" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "Phone", "StartDate", "StudentEnrollment", "Surname" },
                values: new object[] { 6, true, new DateTime(1998, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pedro", "456454545", new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3795), 6, "Alvares" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "Phone", "StartDate", "StudentEnrollment", "Surname" },
                values: new object[] { 7, true, new DateTime(2000, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paulo", "9874512", new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3799), 7, "José" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Active", "EndDate", "Name", "Phone", "StartDate", "Surname", "TeacherEnrollment" },
                values: new object[] { 1, true, null, "Lauro", null, new DateTime(2021, 6, 4, 11, 24, 36, 986, DateTimeKind.Local).AddTicks(6359), "Oliveira", 1 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Active", "EndDate", "Name", "Phone", "StartDate", "Surname", "TeacherEnrollment" },
                values: new object[] { 2, true, null, "Roberto", null, new DateTime(2021, 6, 4, 11, 24, 36, 988, DateTimeKind.Local).AddTicks(2182), "Soares", 2 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Active", "EndDate", "Name", "Phone", "StartDate", "Surname", "TeacherEnrollment" },
                values: new object[] { 3, true, null, "Ronaldo", null, new DateTime(2021, 6, 4, 11, 24, 36, 988, DateTimeKind.Local).AddTicks(2202), "Marconi", 3 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Active", "EndDate", "Name", "Phone", "StartDate", "Surname", "TeacherEnrollment" },
                values: new object[] { 4, true, null, "Rodrigo", null, new DateTime(2021, 6, 4, 11, 24, 36, 988, DateTimeKind.Local).AddTicks(2204), "Carvalho", 4 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Active", "EndDate", "Name", "Phone", "StartDate", "Surname", "TeacherEnrollment" },
                values: new object[] { 5, true, null, "Alexandre", null, new DateTime(2021, 6, 4, 11, 24, 36, 988, DateTimeKind.Local).AddTicks(2205), "Montanha", 5 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 1, 0, 1, "Matemática", null, null, 1 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 6, 0, 2, "Matemática", null, null, 1 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 2, 0, 1, "Física", null, null, 2 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 7, 0, 3, "Física", null, null, 2 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 3, 0, 1, "Matemática", null, null, 3 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 8, 0, 3, "Programação", null, null, 3 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 4, 0, 2, "Inglês", null, null, 4 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 9, 0, 3, "Programação", null, null, 4 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 5, 0, 2, "Programação", null, null, 5 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 10, 0, 1, "Programação", null, null, 5 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 1, 2, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 5, 4, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 5, 2, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 5, 1, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 4, 7, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 4, 6, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 4, 5, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 4, 4, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 4, 1, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 3, 7, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 5, 5, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 3, 6, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 2, 7, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 2, 6, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 2, 3, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 2, 2, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 2, 1, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 1, 7, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 1, 6, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 1, 4, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 1, 3, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 3, 3, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 5, 7, null, null, new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_CourseId",
                table: "Disciplines",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_RequeridDisciplineId",
                table: "Disciplines",
                column: "RequeridDisciplineId");

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
