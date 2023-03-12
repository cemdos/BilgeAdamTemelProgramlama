using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmaca.Model
{
    public class Kullanici
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public uint Puan { get; set; }
        public ushort KazandigiOyunSayisi { get; set; }
        public ushort KaybettigiOyunSayisi { get; set; }
    }
}
