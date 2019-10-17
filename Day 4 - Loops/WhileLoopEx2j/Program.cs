using System;

namespace WhileLoopEx2j
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName("Grant Chirpus", 4);
        }
        
        public static void PrintName(string userName, int number)
        {
            while (number != 0)
            {
                Console.WriteLine($"Hello, {userName}");
                number--;
            }
        }
    }
}
