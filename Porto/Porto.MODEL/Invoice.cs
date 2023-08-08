using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.MODEL
{
    public class Invoice : BaseModel
    {
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }

        //NavigationProperty
        public virtual ICollection<InvoiceDetail>? InvoiceDetailList { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
