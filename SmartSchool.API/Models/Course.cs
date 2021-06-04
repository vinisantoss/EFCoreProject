using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Course
    {
        public Course()
        {

        }

        public Course(int courseId, string name)
        {
            this.CourseId = courseId;
            this.Name = name;
        }

        public int CourseId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Discipline> Disciplines{ get; set; }

    }
}
