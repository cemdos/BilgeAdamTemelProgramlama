using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Porto.MODEL.ViewModel.RequestModel
{
    public class CartRequestModel
    {
        [JsonPropertyName("Count")]
        public int Count { get; set; }
        [JsonPropertyName("Product")]
        public Product Product { get; set; }
    }
}
