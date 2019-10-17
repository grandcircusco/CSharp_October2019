using System;

namespace FindMaxEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = FindMax(4, 5);
            Console.WriteLine($"Expected: 5, Result: " + max);
        }

        public static int FindMax(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            return num2;
        }
    }
}
