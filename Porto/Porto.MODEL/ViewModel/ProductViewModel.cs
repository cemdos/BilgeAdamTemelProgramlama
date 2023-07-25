﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.MODEL.ViewModel
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }
        public decimal DiscountedPrice => UnitPrice *  (decimal)(1 - Discount);
    }
}
