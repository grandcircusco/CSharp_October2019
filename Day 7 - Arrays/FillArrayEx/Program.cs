using System;

namespace FillArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = ParseString("How many countries?");
            string[] countries = new string[arrayLength];


            for(int i = 0; i<countries.Length; i++)
            {
                countries[i] = GetUserInput($"Country {i+1}:");
            }

            ListOutArray(countries);

            int index = ValidateRange("Which country do you want to visit?", 0, countries.Length);
            index--; //index = index - 1;
            Console.WriteLine($"You're visiting {countries[index]}");
        }

        public static int ValidateRange(string message, int min, int max)
        {
            int number = ParseString(message);
            if(number > min && number <= max)
            {
                return number;
            }
            else
            {
                return ValidateRange(message, min, max);
            }

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

        public static void ListOutArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
