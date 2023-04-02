using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Exceptions
{
    internal class KullaniciBulunamadiException:Exception
    {
        public override string Message => "Kullanıcı Bulunamadı";
    }
}
