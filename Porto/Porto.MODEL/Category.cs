using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.MODEL
{
    public class Category : BaseModel
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? ParentID { get; set; }
        public string? ImgUrl { get; set; }

        //navigationProperty
        public virtual ICollection<Product>? Products { get; set; }
        public virtual ICollection<Category>?  SubCategories { get; set; }
        public virtual Category? SubCategory { get; set; }
    }
}
