using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day_24___Core_Day_2._1.Models
{
    public class Student
    {
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string LastName { get; set; }
        
        [Range(typeof(DateTime), "1/1/1900", "11/14/2001", ErrorMessage = "Age not valid." )]
        public DateTime DOB { get; set; }
        public double GPA { get; set; }


    }
}
