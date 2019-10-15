using System;

namespace Day_1___DateTime
{
    class Program
    {
       static void Main(string[] args)
        {
            //input
            Console.WriteLine("What's your birthday? (mm/dd/yyyy)");
            string userDate = Console.ReadLine();

            //processing - converting userDate into DateTime
            DateTime birthday = DateTime.Parse(userDate);
            Console.ForegroundColor = ConsoleColor.Magenta;

            //output - Birth year
            Console.WriteLine($"You were born on {birthday.Year}");
            Console.ResetColor();
        }
    }
}
