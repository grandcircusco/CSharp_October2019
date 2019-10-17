using System;

namespace ForLoopDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintOddNumbers(7);
        }

        public static void PrintOddNumbers(int number)
        {
            for(int i = number; i>0; i--)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
