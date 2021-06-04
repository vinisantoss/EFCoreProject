using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.DTOs
{
    /// <summary>
    /// Objeto DTO de Professor para inserção
    /// </summary>
    public class TeacherRegistrationDTO
    {
        /// <summary>
        /// Identificador e chave do banco
        /// </summary>
        public int TeacherId { get; set; }
        /// <summary>
        /// Chave do professor, para uso dentro da instituição
        /// </summary>
        public int TeacherEnrollment { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
    }
}
