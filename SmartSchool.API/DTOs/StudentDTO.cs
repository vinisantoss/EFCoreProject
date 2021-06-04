using System;

namespace SmartSchool.API.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public int StudentEnrollment { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool Active { get; set; } = true;
        public int Age { get; internal set; }
    }
}
