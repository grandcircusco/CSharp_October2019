using System;

namespace Day_1___Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //input - two numbers from the user
            //prompt user
            Console.WriteLine("Give me a number, please.");
            //receive input
            string userNumber1 = Console.ReadLine();
            //prompt user
            Console.WriteLine("Give me a second number.");
            //receive input
            string userNumber2 = Console.ReadLine();

            //process input - add the numbers together
            //parse string input into numbers
            int number1 = int.Parse(userNumber1);
            int number2 = int.Parse(userNumber2);
            //add the numbers together
            int sum = number1 + number2;

            //output - display the total
            Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
        }
    }
}
