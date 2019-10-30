using System;
using System.Collections.Generic;
using System.Text;

namespace BillInheritanceChallenge
{
    class TippableBill : Bill
    {
        public double Tip { get; set; }

        public TippableBill() { }

        public TippableBill(double subtotal, double taxrate, double tip):base(subtotal, taxrate)
        {
            Tip = tip;
        }

        public override double CalcTotal()
        {
            return base.CalcTotal() + Tip;
        }
    }
}
