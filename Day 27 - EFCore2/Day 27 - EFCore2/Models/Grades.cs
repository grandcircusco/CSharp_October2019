using System;
using System.Collections.Generic;

namespace Day_27___EFCore2.Models
{
    public partial class Grades
    {
        public DateTime DueDate { get; set; }
        public int? Grade { get; set; }
        public string LabName { get; set; }
        public int Id { get; set; }
        public int? StudentCourseId { get; set; }

        public virtual StudentCourses StudentCourse { get; set; }
    }
}
