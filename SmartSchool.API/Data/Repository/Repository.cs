using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data.Context;
using SmartSchool.API.Data.Repository.Interfaces;
using SmartSchool.API.Helpers;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly SmartSchoolContextSqlServer _smartSchoolContext;

        public Repository(SmartSchoolContextSqlServer smartSchoolContext)
        {
            _smartSchoolContext = smartSchoolContext;
        }

        public async Task AddAsync<T>(T entity) where T : class
            => await  _smartSchoolContext.AddAsync(entity);

        public async Task DeleteAsync<T>(T entity) where T : class
            => await Task.FromResult(_smartSchoolContext.Remove(entity));

        public async Task<PageList<Student>> GetAllStudentsAsync(
            PageParameters pageParameters,
            bool includeTeacher = false)
        {
            IQueryable<Student> query = _smartSchoolContext.Students;

            if (includeTeacher) 
                query = query.Include(student => student.StudentsDisciplines)
                             .ThenInclude(studentDiscipline => studentDiscipline.Discipline)
                             .ThenInclude(discipline => discipline.Teacher);


            query = query.AsNoTracking().OrderBy(student => student.Id);

            if (!string.IsNullOrEmpty(pageParameters.Name))
                query = query.Where(student => student.Name
                                                      .ToUpper().Contains(pageParameters.Name.ToUpper()) ||
                                                      student.Surname
                                                      .ToUpper().Contains(pageParameters.Name.ToUpper()));
            if (pageParameters.StudentEnrollment > 0)
                query = query.Where(student => student.StudentEnrollment == pageParameters.StudentEnrollment);

            if(!pageParameters.Active.Equals(null))
                query = query.Where(student => student.Active == !pageParameters.Active.Equals(0));

            return await PageList<Student>.CreateAsync(query, pageParameters.PageNumber, pageParameters.PageSize);
        }

        public async Task<IEnumerable<Student>> GetAllStudentsByDisciplineIdAsync(int disciplineId, bool includeTeacher = false)
        {
            IQueryable<Student> query = _smartSchoolContext.Students;

            if (includeTeacher)
                query = query.Include(student => student.StudentsDisciplines)
                             .ThenInclude(studentDiscipline => studentDiscipline.Discipline)
                             .ThenInclude(discipline => discipline.Teacher);


            query = query.AsNoTracking()
                         .OrderBy(student => student.Id)
                         .Where(student => student.StudentsDisciplines.Any(studentDiscipline => studentDiscipline.DisciplineId == disciplineId));

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachersAsync(bool includeStudents = false)
        {
            IQueryable<Teacher> query = _smartSchoolContext.Teachers;

            if (includeStudents)
                query = query.Include(teacher => teacher.DisciplineClasses)
                             .ThenInclude(teacher => teacher.StudentsDisciplines)
                             .ThenInclude(teacher => teacher.Student);


            query = query.AsNoTracking().OrderBy(teacher => teacher.TeacherId);

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachersByDisciplineIdAsync(int disciplineId, bool includeStudents = false)
        {
            IQueryable<Teacher> query = _smartSchoolContext.Teachers;

            if (includeStudents)
                query = query.Include(teacher => teacher.DisciplineClasses)
                             .ThenInclude(discipline => discipline.StudentsDisciplines)
                             .ThenInclude(studentDiscipline => studentDiscipline.Student);


            query = query.AsNoTracking()
                         .OrderBy(teacher => teacher.TeacherId)
                         .Where(teacher => teacher.DisciplineClasses.Any(disciplineClasses => disciplineClasses.StudentsDisciplines.Any(discipline => discipline.DisciplineId == disciplineId)));

            return await query.ToListAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int studentId, bool includeTeacher = false)
        {
            IQueryable<Student> query = _smartSchoolContext.Students;

            if (includeTeacher)
                query = query.Include(student => student.StudentsDisciplines)
                             .ThenInclude(studentDiscipline => studentDiscipline.Discipline)
                             .ThenInclude(discipline => discipline.Teacher);


            query = query.AsNoTracking()
                         .OrderBy(student => student.Id)
                         .Where(student => student.Id == studentId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Teacher> GetTeacherByIdAsync(int teacherId,bool includeStudents = false)
        {
            IQueryable<Teacher> query = _smartSchoolContext.Teachers;

            if (includeStudents)
                query = query.Include(teacher => teacher.DisciplineClasses)
                             .ThenInclude(discipline => discipline.StudentsDisciplines)
                             .ThenInclude(studentsDiscipline => studentsDiscipline.Student);


            query = query.AsNoTracking()
                         .OrderBy(teacher => teacher.TeacherId)
                         .Where(teacher => teacher.TeacherId == teacherId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
            => await _smartSchoolContext.SaveChangesAsync() > 0;

        public async Task UpdateAsync<T>(T entity) where T : class
        {
            await Task.FromResult(_smartSchoolContext.Update(entity));
        }
    }
}
