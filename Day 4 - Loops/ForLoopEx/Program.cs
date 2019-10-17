using System;

namespace ForLoopEx
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName("Keanu Reeves", 47);
        }

        public static void PrintName(string userName, int number)
        {
            for(int i = 0; i<number; i++)
            {
                Console.WriteLine("Hello, " + userName);
            }
        }
    }
}
