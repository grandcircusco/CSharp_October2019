using System;
using System.Collections.Generic;

namespace FillListEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sportsPlayers = new List<string>();

            bool addPlayers = true;

            while (addPlayers)
            {
                //create a method to add players to the list
                AddToList(sportsPlayers);

                Console.WriteLine("Add more sports people?");
                string input = Console.ReadLine().ToLower();
                if(input == "no")
                {
                    addPlayers = false;
                }
            }

            for(int i = 0; i<sportsPlayers.Count; i++)
            {
                Console.WriteLine($"{sportsPlayers[i]}");
            }
        }
        public static void AddToList(List<string> sportsPeople)
        {
            Console.WriteLine("Give me a sports person!");
            string player = Console.ReadLine();
            sportsPeople.Add(player);
        }
    }
}
