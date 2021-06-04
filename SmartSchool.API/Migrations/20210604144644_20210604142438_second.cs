using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class _20210604142438_second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 4, "Arquitetura de Software" });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 12, 0, 3, "Lógica", null, null, 4 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 13, 0, 1, "Lógica", null, null, 5 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 439, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 1 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 1 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 1 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 2 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 2 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 2 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 3 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 3 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 3 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 4 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 4 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 4 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 5 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 5 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 440, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 427, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 428, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 428, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 428, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 46, 44, 428, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 10,
                column: "CourseId",
                value: 4);

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseHours", "CourseId", "Name", "RequeridDisciplineId", "RequiredId", "TeacherId" },
                values: new object[] { 11, 0, 4, "Lógica", null, null, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 10,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 1 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 1 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 1 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 2 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 2 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 2 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 3 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 3 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 3 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 4 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 4 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 4 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 5 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 5 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 997, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 986, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 988, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 988, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 988, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 11, 24, 36, 988, DateTimeKind.Local).AddTicks(2205));
        }
    }
}
