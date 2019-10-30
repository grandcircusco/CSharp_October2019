using System;

namespace BillInheritanceChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill(15.80, 0.06);
            TippableBill tippable = new TippableBill(8.50, 0.06, 2.00);

            bill.Pay();
            tippable.Pay();
        }


    }
}
