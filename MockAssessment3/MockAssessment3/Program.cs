
using System;

namespace MockAssessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Town Detroit = new Town();
            Console.WriteLine("1 Farmer, 3 Slackers: "+ Detroit.SurviveTheWinter());

            Detroit.Villagers.Add(new Farmer());
            Console.WriteLine("2 Farmers, 3 Slackers: " + Detroit.SurviveTheWinter());

            Detroit.Villagers.Add(new Farmer());
            Console.WriteLine("3 Farmers, 3 Slackers: " + Detroit.SurviveTheWinter());

            Detroit.Villagers.Add(new Farmer());
            Detroit.Villagers.Add(new Farmer());
            Detroit.Villagers.Add(new Farmer());
            Detroit.Villagers.Add(new Farmer());
            Detroit.Villagers.Add(new Farmer());
            Detroit.Villagers.Add(new Farmer());

            Console.WriteLine($"{Detroit.Villagers.Count - 3} Farmers, 3 Slackers: " + Detroit.SurviveTheWinter());
        }
    }
}
