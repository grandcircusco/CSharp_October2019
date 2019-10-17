using System;

namespace ReadIntegerMethodEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = ReadIntegers("How old are you?");

            int year = ReadIntegers("What year were you born?");

            Console.WriteLine($"You were born in {year} and you're {age} years old.");
        }

        public static int ReadIntegers(string message)
        {
            Console.WriteLine(message);
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }
    }
}
