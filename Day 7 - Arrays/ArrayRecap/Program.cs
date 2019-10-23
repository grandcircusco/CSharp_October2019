using System;

namespace ArrayRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = {"dog", "cat", "bear", "unicorn", "manbearpig" };

            bool found = FindElement(animals, "cat");
            if (found != true) //found == false //if(found)
            {
                animals[0] = "cat";
            }


        }

        public static bool FindElement(string[] array, string element)
        {
            foreach(string word in array)
            {
                if(word == element)
                {
                    return true;
                }
            }
            return false;
        } 
    }
}
