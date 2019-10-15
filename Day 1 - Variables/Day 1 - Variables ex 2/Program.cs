using System;

namespace Day_1___Variables_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
                //prompt
                Console.Write("Enter your name: ");
                //get input
                string name = Console.ReadLine();
            //prompt
            Console.Write("Enter your city: ");
            //get input
            string city = Console.ReadLine();
            //prompt
            Console.Write("Enter your age: ");
            //get input
            string ageString = Console.ReadLine();
            //prompt
            Console.Write("Enter your pin: ");
            //get input
            string pinString = Console.ReadLine();

            //process - convert age and pin
            byte age = byte.Parse(ageString);
            int birthYear = DateTime.Now.Year - age;

            //output
            Console.WriteLine("Your Name: {0}", name);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Age: " + age + " Birth Year: " + birthYear);
            Console.WriteLine("PIN: " + pinString);
        }
    }
}
