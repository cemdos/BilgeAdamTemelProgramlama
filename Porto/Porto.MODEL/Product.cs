using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.MODEL
{
    public class Product : BaseModel
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public int? ID_Category { get; set; }
        public string? SKU { get; set; }
        [DefaultValue(0)]
        public float Discount { get; set; }
        [Required]
        public int UnitPriceInStock { get; set; }

        //NavigationProperty
        public virtual Category? Category { get; set; }
    }
}
