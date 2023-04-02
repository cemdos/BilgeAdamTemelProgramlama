using SinemaBiletOtomasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Model
{
    public class GosterimTablo
    {
        public Film Film { get; set; }
        public Salon Salon { get; set; }
        public Seans Seans { get; set; }
        public DateTime Tarih { get; set; }
    }
}
