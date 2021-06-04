using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true)
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
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
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
                    DisciplineId = table.Column<int>(type: "INTEGER", nullable: false)
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
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "Surname" },
                values: new object[] { 1, "Marta", "33225555", "Kent" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "Surname" },
                values: new object[] { 2, "Paula", "3354288", "Isabela" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "Surname" },
                values: new object[] { 3, "Laura", "55668899", "Antonia" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "Surname" },
                values: new object[] { 4, "Luiza", "6565659", "Maria" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "Surname" },
                values: new object[] { 5, "Lucas", "565685415", "Machado" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "Surname" },
                values: new object[] { 6, "Pedro", "456454545", "Alvares" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "Surname" },
                values: new object[] { 7, "Paulo", "9874512", "José" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Name" },
                values: new object[] { 1, "Lauro" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Name" },
                values: new object[] { 2, "Roberto" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Name" },
                values: new object[] { 3, "Ronaldo" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Name" },
                values: new object[] { 4, "Rodrigo" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Name" },
                values: new object[] { 5, "Alexandre" });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 1, "Matemática", 1 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 2, "Física", 2 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 3, "Português", 3 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 4, "Inglês", 4 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 5, "Programação", 5 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 5, 2 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 5, 1 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 4, 7 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 4, 6 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 3, 7 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 3, 6 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 2, 7 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 2, 6 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 1, 7 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 1, 6 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 5, 7 });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_TeacherId",
                table: "Disciplines",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsDisciplines_DisciplineId",
                table: "StudentsDisciplines",
                column: "DisciplineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsDisciplines");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
