using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data.Repository.Interfaces
{
    public interface IRepository
    {
        Task Add<T>(T entity) where T : class;
        Task Update<T>(T entity) where T : class;
        Task Delete<T>(T entity) where T : class;
        Task<bool> SaveChanges();

        Task<List<Student>> GetAllStudents(bool includeTeachers = false);
        Task<List<Student>> GetAllStudentsByDisciplineId(int disciplineId, bool includeTeachers = false);
        Task<Student> GetStudentById(int studentId, bool includeTeachers = false);

        Task<List<Teacher>> GetAllTeachers(bool includeStudents = false);
        Task<List<Teacher>> GetAllTeachersByDisciplineId(int disciplineId, bool includeStudents = false);
        Task<Teacher> GetTeacherById(int studentId, bool includeStudents = false);


    }
}
