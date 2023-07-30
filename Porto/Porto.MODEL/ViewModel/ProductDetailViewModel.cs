using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.MODEL.ViewModel
{
    public class ProductDetailViewModel
    {
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal UnitPrice { get; set; }
		public string SKU { get; set; }
		public int UnitPriceInStock { get; set; }
		public string CategoryName { get; set; }
		public ICollection<Picture>? Images { get; set; }
	}
}
