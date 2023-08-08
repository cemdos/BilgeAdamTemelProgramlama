using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Porto.MODEL.ViewModel.RequestModel
{
    public class InvoiceRequestModel
    {
        [JsonPropertyName("Customer")]
        public Customer Customer { get; set; }
        [JsonPropertyName("Cart")]
        public List<CartRequestModel> Cart { get; set; }
    }
}
