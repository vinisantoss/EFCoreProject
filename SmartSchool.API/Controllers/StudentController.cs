using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Data.Context;
using SmartSchool.API.Data.Repository.Interfaces;
using SmartSchool.API.DTOs;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SmartSchoolContextSqlite _smartSchoolContext;
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public StudentController(SmartSchoolContextSqlite smartSchoolContext,
            IRepository repository,
            IMapper mapper)
        {
            _smartSchoolContext = smartSchoolContext;
            _repository = repository;
            _mapper = mapper;
        }

         [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<StudentDTO>>(await _repository.GetAllStudents(true)));
            }
            catch (Exception)
            {
                return  BadRequest("Aluno não encontrado!");
            }
        }

        //api/student/1

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return  Ok(_mapper.Map<StudentDTO>(await _repository.GetStudentById(id, false)));
            }
            catch (Exception)
            {
                return BadRequest("Aluno não encontrado!");
            }
        }

        //insert
        [HttpPost]
        public async Task<IActionResult> PostAsync(StudentRegistrationDTO model)
        {
            try
            {
                var student = _mapper.Map<Student>(model);
                await _repository.Add(student);
                await _repository.SaveChanges();
                return Created($"/api/Student/{model.Id}", _mapper.Map<StudentDTO>(student));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message} ao inserir aluno!");
            }
        }

        //update
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, StudentRegistrationDTO model)
        {
            try
            {
                var studentUpdate = await _repository.GetStudentById(id);
                if(studentUpdate == null) return BadRequest("Aluno não encontrado!");

                await _repository.Update(_mapper.Map<Student>(model));
                await _repository.SaveChanges();
                return Ok("Aluno Atualizado");
            }
            catch (Exception)
            {
                return BadRequest("Aluno não encontrado!");
            }
        }

        //"half" update 
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchAsync(int id, StudentRegistrationDTO model)
        {
            try
            {
                var studentUpdate = await _repository.GetStudentById(id);

                if (studentUpdate == null) return BadRequest("Aluno não encontrado!");

                await _repository.Update(_mapper.Map<Student>(model));
                await _repository.SaveChanges();
                return Ok("Aluno Atualizado!");
            }
            catch (Exception)
            {
                return BadRequest("Aluno não encontrado!");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var student = await _repository.GetStudentById(id);
                if (student == null) return BadRequest("Aluno não encontrado!");

                await _repository.Delete(student);
                await _repository.SaveChanges();
                return Ok("Aluno Deletado");
            }
            catch (Exception)
            {
                return BadRequest("Aluno não encontrado!");
            }
        }
    }
}
