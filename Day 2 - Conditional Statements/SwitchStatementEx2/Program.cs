using System;

namespace SwitchStatementEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ordering = true;
            while (ordering)
            {
                Console.WriteLine("Welcome to the GC Burger Shop");
                Console.WriteLine("1. Cheeseburger");
                Console.WriteLine("2. Deluxe Cheeseburger");
                Console.WriteLine("3. Royale with Cheese");
                Console.WriteLine("4. Checkout");

                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "1":
                    case "cheeseburger":
                        Console.WriteLine("Yum.");
                        break;
                    case "2":
                    case "deluxe cheeseburger":
                        Console.WriteLine("Yum. Burger was too big");
                        break;
                    case "3":
                    case "royale with cheese":
                        Console.WriteLine("French burger, oui?");
                        break;
                    case "4":
                    case "checkout":
                        Console.WriteLine("K.Bai!");
                        ordering = false;
                        break;
                    default:
                        Console.WriteLine("You didn't choose a real thing.");
                        break;
                }
            }
            Console.WriteLine("Thank you for ordering. Goodbye.");
        }
    }
}
