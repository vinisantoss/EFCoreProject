using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Student
    {
        public Student()
        {

        }

        public Student(int id, string name, string surname, string phone, int studentEnrollment, DateTime birthDate)
        {
            this.Id = id;
            this.StudentEnrollment = studentEnrollment;
            this.Name = name;
            this.Surname = surname;
            this.Phone = phone;
            this.BirthDate = birthDate;
        }

        public int Id { get; set; }
        public int StudentEnrollment { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
        public IEnumerable<StudentDiscipline> StudentsDisciplines { get; set; }

    }
}
