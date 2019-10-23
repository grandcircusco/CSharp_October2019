using System;

namespace ForLoopsArrayEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = {"dog", "tiger", "wombat", "emu", "cat", "platypus", "kangaroo", "koala bear", "Huntsman Spider" };

            ListOutArray(animals);
        }

        public static void ListOutArray(string[] array)
        {
            for(int i = 0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
