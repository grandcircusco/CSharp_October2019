using System;
using System.Collections.Generic;

namespace Day_27___EFCoreDbFirst1.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
