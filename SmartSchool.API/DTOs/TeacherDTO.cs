using System;

namespace SmartSchool.API.DTOs
{
    public class TeacherDTO
    {
        public int TeacherId { get; set; }
        public int TeacherEnrollment { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
    }
}
