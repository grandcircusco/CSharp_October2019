using System;
using System.Collections.Generic;

namespace AfternoonExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //1. Write a method called FindMin() that takes in a list of integers
        //and returns the lowest number in the list.
        public static int FindMin(List<int> numbers)
        {
            int smallest = numbers[0];
            for(int i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            return smallest;
        }

        //2. Write a method called ReverseString that takes in a string
        //and returns the reverse of that string.
        public static string ReverseString(string element)
        {
            //char[] broken = element.ToCharArray();
            List<char> reformed = new List<char>();
            for(int i = element.Length - 1; i>=0; i--)
            {
                reformed.Add(element[i]);
            }
            return reformed.ToString();
        }

        //3. Write a method called IsDivisibleBy that takes in a List of ints and
        //an int number. Loop through the List parameter. 
        //If the number from the List is divisible by the number parameter,
        //add it to a new list. Return the new list.
        public static List<int> IsDivisibleBy(List<int> numbers, int number)
        {
            List<int> numbers2 = new List<int>();
            foreach(int item in numbers)
            {
                if(item % number == 0)
                {
                    numbers2.Add(item);
                }
            }
            return numbers2;
        }
    }
}
