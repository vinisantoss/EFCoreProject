using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data.Context
{
    public class SmartSchoolContextSqlServer //: DbContext
    {
        //private readonly IConfiguration _configuration;
        //private const string dbConnection = "Integrated Security=SSPI;Persist Security Info=False;User ID=ABHNTBL6800353;Initial Catalog=SmartSchool;Data Source=localhost";
        //public SmartSchoolContextSqlServer(DbContextOptions<SmartSchoolContextSqlServer> options,
        //    IConfiguration configuration) : base(options)
        //{
        //    _configuration = configuration;
        //}

        //public DbSet<Student> Students { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }
        //public DbSet<Discipline> Disciplines { get; set; }
        //public DbSet<StudentDiscipline> StudentsDisciplines { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:SqlServer"] == null ? dbConnection : _configuration["ConnectionStrings:SqlServer"]);
        //}
    }
}
