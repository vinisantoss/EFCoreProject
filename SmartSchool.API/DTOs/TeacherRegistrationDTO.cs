using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.DTOs
{
    public class TeacherRegistrationDTO
    {
        public int TeacherId { get; set; }
        public int TeacherEnrollment { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
    }
}
