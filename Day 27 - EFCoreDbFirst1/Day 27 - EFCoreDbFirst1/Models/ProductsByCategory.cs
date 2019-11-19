using System;
using System.Collections.Generic;

namespace Day_27___EFCoreDbFirst1.Models
{
    public partial class ProductsByCategory
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
