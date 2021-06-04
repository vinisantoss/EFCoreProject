using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using SmartSchool.API.Data.Context;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data.Repository.Interfaces;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SmartSchoolContextSqlite _smartSchoolContext;
        private readonly IRepository _repository;
        public StudentController(SmartSchoolContextSqlite smartSchoolContext,
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
                return await Task.FromResult(Ok(_repository.GetAllStudents(true)));
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
                return await Task.FromResult(Ok(_repository.GetStudentById(id, false)));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(BadRequest("Aluno não encontrado!"));
            }
        }


        //insert
        [HttpPost]
        public async Task<IActionResult> PostAsync(Student student)
        {
            try
            {
                await _repository.Add(student);
                return await Task.FromResult(Ok(await _repository.SaveChanges()));
            }
            catch (Exception)
            {
                return await Task.FromResult(BadRequest("Aluno não encontrado!"));
            }
        }

        //update
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, Student student)
        {
            try
            {
                var studentUpdate = _repository.GetStudentById(id);

                if(studentUpdate == null) return await Task.FromResult(BadRequest("Aluno não encontrado!"));

                await _repository.Update(student);
                return await Task.FromResult(Ok(await _repository.SaveChanges()));
            }
            catch (Exception)
            {
                return await Task.FromResult(BadRequest("Aluno não encontrado!"));
            }
        }

        //"half" update 
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchAsync(int id, Student student)
        {
            try
            {
                var studentUpdate = _repository.GetStudentById(id);

                if (studentUpdate == null) return await Task.FromResult(BadRequest("Aluno não encontrado!"));

                await _repository.Update(student);
                return await Task.FromResult(Ok(await _repository.SaveChanges()));
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
                var student = _repository.GetStudentById(id);
                if (student == null) return await Task.FromResult(BadRequest("Aluno não encontrado!"));

                await _repository.Delete(student);
                return await Task.FromResult(Ok(await _repository.SaveChanges()));
            }
            catch (Exception)
            {
                return await Task.FromResult(BadRequest("Aluno não encontrado!"));
            }
        }
    }
}
