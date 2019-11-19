using System;
using System.Collections.Generic;

namespace Day_27___EFCore2.Models
{
    public partial class Courses
    {
        public Courses()
        {
            StudentCourses = new HashSet<StudentCourses>();
        }

        public int Id { get; set; }
        public string Language { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? InstructorId { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
