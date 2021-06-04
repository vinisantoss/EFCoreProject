using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data.Context;
using SmartSchool.API.Data.Repository.Interfaces;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly SmartSchoolContextSqlite _smartSchoolContext;
        private readonly IRepository _repository;

        public TeacherController(SmartSchoolContextSqlite smartSchoolContext,
            IRepository repository)
        {
            _smartSchoolContext = smartSchoolContext;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return await Task.FromResult(Ok(_repository.GetAllTeachers(true)));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(BadRequest("Aluno não encontrado!"));
            }
        }

        //api/student/1

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return await Task.FromResult(Ok(_repository.GetTeacherById(id, false)));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(BadRequest("Aluno não encontrado!"));
            }
        }

        //insert
        [HttpPost]
        public async Task<IActionResult> PostAsync(Teacher teacher)
        {
            try
            {
                await _repository.Add(teacher);
                return await Task.FromResult(Ok(await _repository.SaveChanges()));
            }
            catch (Exception)
            {
                return await Task.FromResult(BadRequest("Aluno não encontrado!"));
            }
        }

        //update
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, Teacher teacher)
        {
            try
            {
                var studentUpdate = _repository.GetTeacherById(id);

                if (studentUpdate == null) return await Task.FromResult(BadRequest("Aluno não encontrado!"));

                _smartSchoolContext.Update(teacher);
                _smartSchoolContext.SaveChanges();

                return await Task.FromResult(Ok(teacher));
            }
            catch (Exception)
            {
                return await Task.FromResult(BadRequest("Aluno não encontrado!"));
            }
        }

        //"half" update 
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchAsync(int id, Teacher teacher)
        {
            try
            {
                var studentUpdate = _repository.GetTeacherById(id);

                if (studentUpdate == null) return await Task.FromResult(BadRequest("Aluno não encontrado!"));

                _smartSchoolContext.Update(teacher);
                _smartSchoolContext.SaveChanges();
                return await Task.FromResult(Ok(teacher));
            }
            catch (Exception)
            {
                return await Task.FromResult(BadRequest("Aluno não encontrado!"));
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var student = _repository.GetTeacherById(id);
                if (student == null) return await Task.FromResult(BadRequest("Aluno não encontrado!"));

                _smartSchoolContext.Remove(student);
                _smartSchoolContext.SaveChanges();
                return await Task.FromResult(Ok());
            }
            catch (Exception)
            {
                return await Task.FromResult(BadRequest("Aluno não encontrado!"));
            }
        }
    }
}
