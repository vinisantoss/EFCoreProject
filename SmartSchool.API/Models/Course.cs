using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Course
    {
        public Course()
        {

        }

        public Course(int courseId, string name, IEnumerable<Discipline> disciplines)
        {
            this.CourseId = courseId;
            this.Name = name;
            this.Disciplines = disciplines;
        }

        public int CourseId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Discipline> Disciplines{ get; set; }

    }
}
