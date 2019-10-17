using System;

namespace If_Statement_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Username: ");
            string userName = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            //processing
            if(userName == "GrantChirpus")
            {
                if (password == "Hello1234")
                {
                    Console.WriteLine($"Hello, {userName}!");
                }
                else
                {
                    Console.WriteLine($"Incorrect Password");
                }
            }
            else
            {
                Console.WriteLine("No user found.");
            }

            //output

        }
    }
}
