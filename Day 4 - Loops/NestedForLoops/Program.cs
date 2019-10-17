using System;

namespace NestedForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMultiplicationTable(3);
        }

        public static void PrintMultiplicationTable(int number)
        {
            for(int i = 1; i<=number; i++)
            {
                for(int j = 1; j<=number; j++)
                {
                    Console.Write($"\t{i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
