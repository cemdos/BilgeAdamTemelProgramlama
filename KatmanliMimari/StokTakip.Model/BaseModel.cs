using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Model
{
    public abstract class BaseModel
    {
        public int ID { get; set; }
        
        [DefaultValue(false)]
        public bool Deleted { get; set; }

        public DateTime? DelDate { get; set; }

        public int? DelUser { get; set; }

        public DateTime? ModDate { get; set; }

        public int? ModUser { get; set; }

        public int? CreUser { get; set; }

        public DateTime CreDate
        {
            get
            {
                return this.creDate.HasValue
                   ? this.creDate.Value
                   : DateTime.Now;
            }

            set { this.creDate = value; }
        }

        private DateTime? creDate = null;
    }
}
