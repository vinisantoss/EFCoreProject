using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Teacher
    {
        public Teacher()
        {

        }

        public Teacher(int teacherId, string name, string surname, string phone, int teacherEnrollment)
        {
            this.TeacherId = teacherId;
            this.Name = name;
            this.Surname = surname;
            this.Phone = phone;
            this.TeacherEnrollment = teacherEnrollment;
        }

        public int TeacherId { get; set; }
        public int TeacherEnrollment { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
        public IEnumerable<Discipline> DisciplineClasses { get; set; }
    }
}
