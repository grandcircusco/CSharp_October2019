using System;

namespace CalculatorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the GC Calculator");
            //TODO: Write method for retrieving user number
            decimal number1 = GetUserNumber();

            decimal number2;
            bool keepGoing = true;
            while (keepGoing)
            {
                PrintMenu();
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                    case "Addition":
                        //TODO: Write Addition method
                        number2 = GetUserNumber();
                        number1 = AddNumbers(number1, number2);
                        Console.WriteLine($"result: {number1}");
                        break;
                    case "2":
                    case "Subtraction":
                        //TODO: Write Subtraction method

                        break;
                    case "3":
                    case "Multiplication":
                        //TODO: Write Multiplication method

                        break;
                    case "4":
                    case "Division":
                        //TODO: Write Division method

                        break;
                    case "5":
                    case "Percentage":
                        //TODO: Write Percentage method

                        break;
                    case "6":
                    case "Exit":
                        //TODO: Write Exit method
                        keepGoing = false;
                        break;
                }
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Percentage");
            Console.WriteLine("6. Exit");
        }

        //TODO write GetUserNumber method
        public static decimal GetUserNumber()
        {
            string input = Console.ReadLine();
            decimal number = decimal.Parse(input);
            return number;

            //return decimal.Parse(Console.ReadLine());
        }

        public static decimal AddNumbers(decimal number1, decimal number2)
        {
            decimal sum = number1 + number2;
            return sum;
        }
    }
}
