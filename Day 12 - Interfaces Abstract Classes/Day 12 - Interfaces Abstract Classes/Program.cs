using System;
using System.Collections.Generic;

namespace Day_12___Interfaces_Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant troy = new Elephant(true, "balding", 1.75, 2);
            Turkey bill = new Turkey(true, "feathers");
            //bill.IsMammal = true;
            Console.Write(bill.IsMammal);

            List<Mammal> mammalList = new List<Mammal> { troy, bill };
            foreach(Mammal mammal in mammalList)
            {
                if(mammal is Turkey)
                {
                    Turkey thisTurkey = bill;
                    thisTurkey.FeatherCount = 1000000;
                }
                else
                {
                    Elephant elephant = troy;
                    elephant.BeAMammal();
                }
            }
            Mammal mammal1 = new Turkey(true, "bald");

        }
    }
}