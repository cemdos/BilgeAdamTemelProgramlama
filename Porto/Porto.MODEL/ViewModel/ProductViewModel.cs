using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.MODEL.ViewModel
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }
        public string? MasterPic { get; set; }
        public string? SlavePic { get; set; }
        public string? CategoryName { get; set; }
        public decimal DiscountedPrice => UnitPrice *  (decimal)(1 - Discount);
        public int UnitPriceInStock { get; set; }
    }
}
