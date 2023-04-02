using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Exceptions
{
    public class SalonKapasiteException:Exception
    {
        public override string Message => "Salon kapasitesi 10 - 200 arası değer olmalıdır.";
    }
}
