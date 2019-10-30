using System;

namespace TryCatchEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ParseString("Give me a number!");

            Console.WriteLine(number);
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
            //return Console.Readline();
        }

        public static int ParseString(string message)
        {
            try
            {
                string input = GetUserInput(message);
                int number = int.Parse(input);
                return number;
            }
            catch
            {
                return ParseString(message);
            }
        }
    }
}
