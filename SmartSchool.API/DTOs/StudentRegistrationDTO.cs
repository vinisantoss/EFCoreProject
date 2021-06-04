using System;

namespace SmartSchool.API.DTOs
{
    /// <summary>
    /// Objeto DTO de Aluno para inserção
    /// </summary>
    public class StudentRegistrationDTO
    {
        /// <summary>
        /// Identificador e chave do banco
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Chave do aluno para uso dentro da instituição
        /// </summary>
        public int StudentEnrollment { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
    }
}
