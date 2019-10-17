using System;

namespace CountNumbersMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int CountAllTheNumbers(int number)
        {
            int sum = 0;
            for(int i = number; i > 0; i--)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
