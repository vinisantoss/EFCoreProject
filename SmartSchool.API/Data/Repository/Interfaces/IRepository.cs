using SmartSchool.API.Helpers;
using SmartSchool.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartSchool.API.Data.Repository.Interfaces
{
    public interface IRepository
    {
        Task AddAsync<T>(T entity) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
        Task<PageList<Student>> GetAllStudentsAsync(PageParameters pageParameters, bool includeTeachers = false);
        Task<IEnumerable<Student>> GetAllStudentsByDisciplineIdAsync(int disciplineId, bool includeTeachers = false);
        Task<Student> GetStudentByIdAsync(int studentId, bool includeTeachers = false);
        Task<IEnumerable<Teacher>> GetAllTeachersAsync(bool includeStudents = false);
        Task<IEnumerable<Teacher>> GetAllTeachersByDisciplineIdAsync(int disciplineId, bool includeStudents = false);
        Task<Teacher> GetTeacherByIdAsync(int studentId, bool includeStudents = false);
    }
}
