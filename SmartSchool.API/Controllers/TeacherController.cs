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
    /// Controller de professores
    /// </summary>
    
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Controller com injeção de dependência
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public TeacherController(IRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Método responsável por retornar todos os professores cadastrados
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<Teacher>>(await _repository.GetAllTeachers(true)));
            }
            catch (Exception)
            {
                return BadRequest("Professor não encontrado!");
            }
        }

        /// <summary>
        /// Método responsável
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<TeacherDTO>(await _repository.GetTeacherById(id, false)));
            }
            catch (Exception)
            {
                return BadRequest("Professor não encontrado!");
            }
        }

        /// <summary>
        /// Método responsável por inserir um novo professor
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostAsync(TeacherRegistrationDTO model)
        {
            try
            {
                var teacher = _mapper.Map<Teacher>(model);
                await _repository.Add(teacher);
                await _repository.SaveChanges();
                return Created($"/api/Teacher/{model.TeacherId}", _mapper.Map<TeacherDTO>(teacher));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message} ao inserir professor");
            }
        }

        /// <summary>
        /// Método responsável por atualizar as informações do professor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, TeacherRegistrationDTO model)
        {
            try
            {
                var teacherUpdate = await _repository.GetTeacherById(id);

                if (teacherUpdate == null) return BadRequest("Professor não encontrado!");

                await _repository.Update(_mapper.Map<Teacher>(model));
                await _repository.SaveChanges();
                return Ok("Professor Atualizado!");
            }
            catch (Exception)
            {
                return BadRequest("Professor não encontrado!");
            }
        }

        /// <summary>
        /// Método responsável por atualizar parte das informações de professor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchAsync(int id, TeacherRegistrationDTO model)
        {
            try
            {
                var teacherUpdate = await _repository.GetTeacherById(id);

                if (teacherUpdate == null) return BadRequest("Professor não encontrado!");

                await _repository.Update(_mapper.Map<Teacher>(model));
                await _repository.SaveChanges();
                return Ok("Professor Atualizado!");
            }
            catch (Exception)
            {
                return BadRequest("Professor não encontrado!");
            }
        }

        /// <summary>
        /// Método responsável por deletar um professor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var teacher = await _repository.GetTeacherById(id);
                if (teacher == null) return BadRequest("Professor não encontrado!");

                await _repository.Delete(teacher);
                await _repository.SaveChanges();
                return Ok("Professor deletado!");
            }
            catch (Exception)
            {
                return BadRequest("Professor não encontrado!");
            }
        }
    }
}
