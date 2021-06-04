using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class StudentCourse
    {
        public StudentCourse(int studentId, int courseId)
        {
            this.StudentId = studentId;
            this.CourseId = courseId;
        }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
