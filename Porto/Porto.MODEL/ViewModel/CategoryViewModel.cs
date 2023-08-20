using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Porto.MODEL.ViewModel
{
    public class CategoryViewModel
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }
    }
}
