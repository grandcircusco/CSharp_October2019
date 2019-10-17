using System;

namespace IfStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("How old are you?");
            string userInput = Console.ReadLine();

            //processing
            int age = int.Parse(userInput);
            if ((age <= 100) && (age >= 0))
            {
                Console.WriteLine("That seems like an age someone could have.");
            }

        }
    }
}
