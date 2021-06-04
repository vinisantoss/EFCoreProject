using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class _20210604122439_third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Disciplines_RequeridDisciplineId",
                table: "Disciplines");

            migrationBuilder.RenameColumn(
                name: "RequeridDisciplineId",
                table: "Disciplines",
                newName: "RequiredDisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_Disciplines_RequeridDisciplineId",
                table: "Disciplines",
                newName: "IX_Disciplines_RequiredDisciplineId");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 302, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 302, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 302, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 302, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 302, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 302, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 302, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 1 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 1 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 1 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 2 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 2 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 2 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 3 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 3 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 3 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 4 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 4 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 4 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 5 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 5 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 6 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 7 },
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 303, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 293, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 294, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 294, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 294, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2021, 6, 4, 14, 36, 49, 294, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Disciplines_RequiredDisciplineId",
                table: "Disciplines",
                column: "RequiredDisciplineId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Disciplines_RequiredDisciplineId",
                table: "Disciplines");

            migrationBuilder.RenameColumn(
                name: "RequiredDisciplineId",
                table: "Disciplines",
                newName: "RequeridDisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_Disciplines_RequiredDisciplineId",
                table: "Disciplines",
                newName: "IX_Disciplines_RequeridDisciplineId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Disciplines_RequeridDisciplineId",
                table: "Disciplines",
                column: "RequeridDisciplineId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
