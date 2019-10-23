using System;
using System.Collections.Generic;

namespace Day_8___Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Tim");
            dictionary.Add(2, "Fred");
            dictionary.Add(3, "Tim");

            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}. {kvp.Value}");
            }

            Console.WriteLine(dictionary[1]);
        }
    }
}
