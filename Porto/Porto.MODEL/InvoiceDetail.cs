using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.MODEL
{
    public class InvoiceDetail : BaseModel
    {
        public DateTime InvoiceDate { get; set; }
        public int ID_Product { get; set; }
        public decimal DiscountPercent { get; set; }
        public int ID_Invoice { get; set; }
        public int Quantity { get; set; }


        //NavigationProperty
        public virtual Product? Product { get; set; }
        public virtual Invoice? Invoice { get; set; }
    }
}
