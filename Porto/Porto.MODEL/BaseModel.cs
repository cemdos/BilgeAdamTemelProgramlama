using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.MODEL
{
    public abstract class BaseModel
    {
        public int ID { get; set; }
        public int? CreUser { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }
        public DateTime? ModDate { get; set; }
        public int? ModUser { get; set; }
        public DateTime? DelDate { get; set; }
        public int? DelUser { get; set; }
        private DateTime? _creDate;

        public DateTime CreDate
        {
            get
            {
                if (_creDate == null)
                    _creDate = DateTime.Now;
                return _creDate.Value;
            }
        }


    }
}
