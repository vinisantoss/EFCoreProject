using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data.Context;
using SmartSchool.API.Data.Repository.Interfaces;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly SmartSchoolContextSqlite _smartSchoolContext;

        public Repository(SmartSchoolContextSqlite smartSchoolContext)
        {
            _smartSchoolContext = smartSchoolContext;
        }

        public async Task Add<T>(T entity) where T : class
        {
           await  Task.FromResult(_smartSchoolContext.Add(entity));
        }

        public async Task Delete<T>(T entity) where T : class
        {
            await Task.FromResult(_smartSchoolContext.Remove(entity));
        }

        public async Task<List<Student>> GetAllStudents(bool includeTeacher = false)
        {
            IQueryable<Student> query = _smartSchoolContext.Students;

            if (includeTeacher) 
                query = query.Include(student => student.StudentsDisciplines)
                             .ThenInclude(studentDiscipline => studentDiscipline.Discipline)
                             .ThenInclude(discipline => discipline.Teacher);


            query = query.AsNoTracking().OrderBy(student => student.Id);

            return await query.ToListAsync();
        }

        public async Task<List<Student>> GetAllStudentsByDisciplineId(int disciplineId, bool includeTeacher = false)
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

        public async Task<List<Teacher>> GetAllTeachers(bool includeStudents = false)
        {
            IQueryable<Teacher> query = _smartSchoolContext.Teachers;

            if (includeStudents)
                query = query.Include(teacher => teacher.DisciplineClasses)
                             .ThenInclude(teacher => teacher.StudentsDisciplines)
                             .ThenInclude(teacher => teacher.Student);


            query = query.AsNoTracking().OrderBy(teacher => teacher.TeacherId);

            return await query.ToListAsync();
        }

        public async Task<List<Teacher>> GetAllTeachersByDisciplineId(int disciplineId, bool includeStudents = false)
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

        public async Task<Student> GetStudentById(int studentId, bool includeTeacher = false)
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

        public async Task<Teacher> GetTeacherById(int teacherId,bool includeStudents = false)
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

        public async Task<bool> SaveChanges()
        {
            return await Task.FromResult(_smartSchoolContext.SaveChanges() > 0);
        }

        public async Task Update<T>(T entity) where T : class
        {
            await Task.FromResult(_smartSchoolContext.Update(entity));
        }
    }
}
