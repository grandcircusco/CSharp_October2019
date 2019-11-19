using System;
using System.Collections.Generic;

namespace Day_27___EFCore2.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Courses = new HashSet<Courses>();
            PersonNavigation = new HashSet<Person>();
        }

        public int? PersonId { get; set; }
        public DateTime HireDate { get; set; }
        public int Pay { get; set; }
        public int Id { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
        public virtual ICollection<Person> PersonNavigation { get; set; }
    }
}
