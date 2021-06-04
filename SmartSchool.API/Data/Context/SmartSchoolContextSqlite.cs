using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data.Context
{
    public class SmartSchoolContextSqlite : DbContext
    {

        public SmartSchoolContextSqlite(DbContextOptions<SmartSchoolContextSqlite> options) : base(options)//construtor do dbcontext
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        public DbSet<StudentDiscipline> StudentsDisciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        //quando cria o banco ele chama esse carinha e faz o que esta dentro, os relacionamento vem aqui
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentDiscipline>()
                   .HasKey(x => new { x.StudentId, x.DisciplineId });//relacionamento muitos para muitos

            builder.Entity<StudentCourse>()
                   .HasKey(x => new { x.StudentId, x.CourseId });

            builder.Entity<Teacher>()
                .HasData(new List<Teacher>(){ //HasData carga inicial do banco de dados
                    new Teacher(1, "Lauro", "Oliveira",1),
                    new Teacher(2, "Roberto", "Soares", 2),
                    new Teacher(3, "Ronaldo", "Marconi",3),
                    new Teacher(4, "Rodrigo", "Carvalho", 4),
                    new Teacher(5, "Alexandre", "Montanha",5),
                });

            builder.Entity<Course>()
                .HasData(new List<Course> {
                    new Course(1,"Ciência da Computação"),
                    new Course(2,"Sistema de Informação"),
                    new Course(3,"Engenharia de Software"),
                    new Course(4,"Arquitetura de Software")
                });

            builder.Entity<Discipline>()
                .HasData(new List<Discipline>{
                    new Discipline(1, "Matemática", 1, 1),
                    new Discipline(2, "Física", 2,1),
                    new Discipline(3, "Matemática", 3,1),
                    new Discipline(4, "Inglês", 4,2),
                    new Discipline(5, "Programação", 5,2),
                    new Discipline(6, "Matemática", 1, 2),
                    new Discipline(7, "Física", 2,3),
                    new Discipline(8, "Programação", 3,3),
                    new Discipline(9, "Programação", 4,3),
                    new Discipline(10, "Programação", 5,4),
                    new Discipline(11, "Lógica", 3,4),
                    new Discipline(12, "Lógica", 4,3),
                    new Discipline(13, "Lógica", 5,1)
                });

            builder.Entity<Student>()
                .HasData(new List<Student>(){
                    new Student(1, "Marta", "Kent", "33225555",1, DateTime.Parse("06/15/2008")),
                    new Student(2, "Paula", "Isabela", "3354288",2, DateTime.Parse("08/05/2010")),
                    new Student(3, "Laura", "Antonia", "55668899",3, DateTime.Parse("05/02/2005")),
                    new Student(4, "Luiza", "Maria", "6565659",4, DateTime.Parse("02/01/2003")),
                    new Student(5, "Lucas", "Machado", "565685415",5, DateTime.Parse("10/30/1999")),
                    new Student(6, "Pedro", "Alvares", "456454545",6, DateTime.Parse("08/23/1998")),
                    new Student(7, "Paulo", "José", "9874512",7, DateTime.Parse("12/21/2000"))
                });

            builder.Entity<StudentDiscipline>()
                .HasData(new List<StudentDiscipline>() {
                    new StudentDiscipline() {StudentId = 1, DisciplineId = 2 },
                    new StudentDiscipline() {StudentId = 1, DisciplineId = 4 },
                    new StudentDiscipline() {StudentId = 1, DisciplineId = 5 },
                    new StudentDiscipline() {StudentId = 2, DisciplineId = 1 },
                    new StudentDiscipline() {StudentId = 2, DisciplineId = 2 },
                    new StudentDiscipline() {StudentId = 2, DisciplineId = 5 },
                    new StudentDiscipline() {StudentId = 3, DisciplineId = 1 },
                    new StudentDiscipline() {StudentId = 3, DisciplineId = 2 },
                    new StudentDiscipline() {StudentId = 3, DisciplineId = 3 },
                    new StudentDiscipline() {StudentId = 4, DisciplineId = 1 },
                    new StudentDiscipline() {StudentId = 4, DisciplineId = 4 },
                    new StudentDiscipline() {StudentId = 4, DisciplineId = 5 },
                    new StudentDiscipline() {StudentId = 5, DisciplineId = 4 },
                    new StudentDiscipline() {StudentId = 5, DisciplineId = 5 },
                    new StudentDiscipline() {StudentId = 6, DisciplineId = 1 },
                    new StudentDiscipline() {StudentId = 6, DisciplineId = 2 },
                    new StudentDiscipline() {StudentId = 6, DisciplineId = 3 },
                    new StudentDiscipline() {StudentId = 6, DisciplineId = 4 },
                    new StudentDiscipline() {StudentId = 7, DisciplineId = 1 },
                    new StudentDiscipline() {StudentId = 7, DisciplineId = 2 },
                    new StudentDiscipline() {StudentId = 7, DisciplineId = 3 },
                    new StudentDiscipline() {StudentId = 7, DisciplineId = 4 },
                    new StudentDiscipline() {StudentId = 7, DisciplineId = 5 }
                });
        }
    }
}
