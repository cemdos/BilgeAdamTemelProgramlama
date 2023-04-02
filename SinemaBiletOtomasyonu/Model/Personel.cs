using SinemaBiletOtomasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Model
{
    public class Personel:Kullanici
    {
        public Personel()
        {
            Rol = KullaniciRol.Personel;
        }
    }
}
