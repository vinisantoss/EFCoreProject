using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Discipline
    {

        public Discipline()
        {

        }

        public Discipline(int id, string name, int teacherId, int courseId)
        {
            this.Id = id;
            this.Name = name;
            this.TeacherId = teacherId;
            this.CourseId = courseId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int? RequiredId { get; set; } = null;
        public Discipline RequiredDiscipline { get; set; }
        public int CourseHours { get; set; }
        public IEnumerable<StudentDiscipline> StudentsDisciplines { get; set; }

    }
}
