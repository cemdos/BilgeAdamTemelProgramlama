using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.MODEL
{
    public class Picture : BaseModel
    {
        public string? ImageUrl { get; set; }
        public int? ID_Product { get; set; }

        //NavigationProperty
        public virtual Product? Product { get; set; }
    }
}
