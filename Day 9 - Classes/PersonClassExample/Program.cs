using System;
using System.Collections.Generic;

namespace PersonClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Scott Pilgrim", DateTime.Parse("09/27/1981"), "Male");
            Person person2 = new Person("Princess Zelda", DateTime.Parse("02/21/1987"), "Female");
            Person person3 = new Person("Khabib Nurmagomedov", DateTime.Parse("09/20/98"), "Man/bear");

            List<Person> people = new List<Person> { person1, person2, person3 };
            foreach(Person person in people)
            {
                Console.WriteLine($"{person.Name}, a {person.Gender}, was born on {person.DoB.ToShortDateString()}");
            }

            List<string> stringList = new List<string> { "A", "E", "I" };
            foreach(string s in stringList)
            {

            }
        }
    }
}
