using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser("Grant Chirpus");
            GreetUser("Latin", "Lady Witherell");
        }

        public static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public static void GreetUser(string language, string name)
        {
            switch (language)
            {
                case "French":
                    Console.WriteLine($"Bonjour, {name}!");
                    break;
                case "German":
                    Console.WriteLine($"Guten Tag, {name}!");
                    break;
                case "Spanish":
                    Console.WriteLine($"Hola, {name}!");
                    break;
                case "Latin":
                    Console.WriteLine($"Salve, {name}!");
                        break;
            }
        }
    }
}
