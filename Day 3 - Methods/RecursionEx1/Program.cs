using System;

namespace RecursionEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                //do the things

                //Do you want to continue?
                keepGoing = GetContinue();
            }
            Console.WriteLine("Ok, bye.");
        }

        public static bool GetContinue()
        {
            //input from user on whether they want to continue (y/n)
            Console.WriteLine("Would you like to continue? y/n");
            //processing - if y, return true, if n, return false, 
            //if neither, call GetContinue() recursively
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    return GetContinue();
            }

        }
    }
}
