using System;

namespace SmartSchool.API.DTOs
{
    public class StudentRegistrationDTO
    {
        public int Id { get; set; }
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
