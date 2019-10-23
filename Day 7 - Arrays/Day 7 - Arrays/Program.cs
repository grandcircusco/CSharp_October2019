using System;

namespace Day_7___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[7];

            array1[0] = 55;

            Console.WriteLine($"array1[0]: {array1[0]}");
            Console.WriteLine($"array1[6]: {array1[6]}");

            //Console.WriteLine($"array1[7]: {array1[7]}");
            //^Results in an IndexOutOfRangeException 

            Console.WriteLine(array1); //will not print out the elements of the array

            foreach(int number in array1)
            {
                Console.WriteLine(number);

            }

        }
    }
}
