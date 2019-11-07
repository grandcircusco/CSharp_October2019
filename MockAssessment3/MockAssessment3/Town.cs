using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    class Town
    {
        public List<Villager> Villagers { get; set; }

        public Town() 
        {
            Villagers = new List<Villager>();
            Villagers.Add(new Farmer());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());

        }

        public int Harvest()
        {
            int totalHarvest = 0;
            foreach (Villager villager in Villagers)
            {
                totalHarvest += villager.Farm();
            }
            return totalHarvest;
        }

        public int CalcFoodConsumption()
        {
            int totalHunger = 0;

            foreach (Villager villager in Villagers)
            {
                totalHunger += villager.Hunger;
            }
            return totalHunger;
        }
        public bool SurviveTheWinter()
        {
            
            int totalHarvest = Harvest();
            int totalFoodEaten = CalcFoodConsumption();
            if(totalFoodEaten <= totalHarvest)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
