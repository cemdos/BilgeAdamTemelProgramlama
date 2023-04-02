using SinemaBiletOtomasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Model
{
    public class Film
    {
        public string Adi { get; set; }
        public string Yonetmen { get; set; }
        public int CekilmeYili { get; set; }
        public FilmTuru Tur { get; set; }
    }
}
