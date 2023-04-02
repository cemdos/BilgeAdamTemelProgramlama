using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Model
{
    public class Musteri:Kullanici
    {
        public Musteri()
        {
            Rol = Enum.KullaniciRol.Musteri;
        }
    }
}
