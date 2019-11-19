using System;
using System.Collections.Generic;

namespace Day_27___EFCore2.Models
{
    public partial class Student
    {
        public Student()
        {
            Person = new HashSet<Person>();
            StudentCourses = new HashSet<StudentCourses>();
        }

        public double? Gpa { get; set; }
        public int Tuition { get; set; }
        public DateTime? GradDate { get; set; }
        public int Id { get; set; }
        public int? PersonId { get; set; }

        public virtual Person PersonNavigation { get; set; }
        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
