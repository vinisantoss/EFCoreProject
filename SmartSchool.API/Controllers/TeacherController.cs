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
    public class TeacherController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public TeacherController(IRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

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

        //api/student/1

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

        //insert
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

        //update
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, TeacherRegistrationDTO model)
        {
            try
            {
                var teacherUpdate =  await _repository.GetTeacherById(id);

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

        //"half" update 
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
