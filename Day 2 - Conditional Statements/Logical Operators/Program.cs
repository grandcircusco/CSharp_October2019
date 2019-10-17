using System;

namespace Logical_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            ////prompt
            Console.WriteLine("Do you know how to use Logical Operators? y/n");
            ////user input
            string userInput = Console.ReadLine();

            //processing
            if (userInput == "y" || userInput == "Y")
            {
                Console.WriteLine("Yay! I'm so glad.");
            }
            else if(userInput == "n" || userInput == "N")
            {
                Console.WriteLine("Okay! Let's learn.");
            }
            else
            {
                Console.WriteLine("Is that a yes or a no?");
            }


            //output
        }
    }
}
