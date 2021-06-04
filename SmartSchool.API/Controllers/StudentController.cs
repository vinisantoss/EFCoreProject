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
    /// <summary>
    /// Controller de Estudante
    /// </summary>

    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly SmartSchoolContextSqlite _smartSchoolContext;
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor de controller com injeções de dependência
        /// </summary>
        /// <param name="smartSchoolContext"></param>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>

        public StudentController(SmartSchoolContextSqlite smartSchoolContext,
            IRepository repository,
            IMapper mapper)
        {
            _smartSchoolContext = smartSchoolContext;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Método responsável para retornar todos os alunos cadastrados
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Método responsável por retornar apenas um aluno pelo seu código id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

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

        /// <summary>
        /// Método responsável por inserir novos alunos
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método responsável por atualizar as informações de aluno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método responsável por atualizar parte das informações do aluno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método responsável por deletar o aluno
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
