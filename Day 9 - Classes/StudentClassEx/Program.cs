using System;
using System.Collections.Generic;

namespace StudentClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Course october2019CSharp = 
                new Course("C#.Net Oct 2019", DateTime.Parse("10/14/2019"), DateTime.Parse("12/20/2019"));

            //october2019CSharp.Name = "C#.Net Oct 2019"
            //....Instructor = "";
            //....StartDate = "10/14/2019";
            //....StudentList = null;

            october2019CSharp.Instructor = "Anna B.";

            List<Student> studentList = new List<Student>
            {
                new Student("Gus", "Gus", "Gus@Gusgus.gus"),
                new Student("Kenny", "McCormack", "kenny@sp.gov"),
                new Student("Franklin", "Reynolds", "frankrey@ias.co"),
                new Student("Sparky", "Anderson", "sanderson@tigers.co")
            };

            october2019CSharp.StudentList = studentList;

            foreach(Student student in october2019CSharp.StudentList)
            {
                Console.WriteLine(student.FirstName);
            }
        }
    }
}
