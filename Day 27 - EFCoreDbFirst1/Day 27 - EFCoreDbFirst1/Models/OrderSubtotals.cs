using System;
using System.Collections.Generic;

namespace Day_27___EFCoreDbFirst1.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
