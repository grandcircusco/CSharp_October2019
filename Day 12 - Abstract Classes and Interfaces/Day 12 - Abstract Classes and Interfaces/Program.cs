using System;

namespace Day_12___Abstract_Classes_and_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant troy = new Elephant(true, "balding", 1.75, 2);
            Turkey bill = new Turkey();
            bill.IsMammal() = true;
            Console.WriteLine(bill.IsMammal);
        }
    }
}
