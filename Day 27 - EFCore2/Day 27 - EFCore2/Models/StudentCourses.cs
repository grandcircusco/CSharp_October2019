using System;
using System.Collections.Generic;

namespace Day_27___EFCore2.Models
{
    public partial class StudentCourses
    {
        public StudentCourses()
        {
            Grades = new HashSet<Grades>();
        }

        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public int? FinalGrade { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<Grades> Grades { get; set; }
    }
}
