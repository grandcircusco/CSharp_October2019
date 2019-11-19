using System;
using System.Collections.Generic;

namespace Day_27___EFCore2.Models
{
    public partial class Person
    {
        public Person()
        {
            Instructor = new HashSet<Instructor>();
            StudentNavigation = new HashSet<Student>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? InstructorId { get; set; }

        public virtual Instructor InstructorNavigation { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<Instructor> Instructor { get; set; }
        public virtual ICollection<Student> StudentNavigation { get; set; }
    }
}
