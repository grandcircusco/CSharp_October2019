using System;

namespace Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName("Bart", 4);
        }

        public static void PrintName(string userName, int number)
        {
            do
            {
                Console.WriteLine("Hello, " + userName);
                number--;
            }
            while (number > 0);
        }
    }
}
