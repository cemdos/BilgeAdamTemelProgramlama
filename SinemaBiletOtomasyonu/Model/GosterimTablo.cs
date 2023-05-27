using HS10Lib;
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
        public int ID { get; set; }
        public int ID_Film { get; set; }
        public int ID_Salon { get; set; }
        public Seans Seans { get; set; }
        public DateTime Tarih { get; set; }

        public Film Film
        {
            get
            {
                var film = Database.Instance.Filmler.Find(x => x.ID == ID_Film);
                return film;
            }
        }
        public Salon Salon
        {
            get
            {
                var salon = Database.Instance.Salonlar.Find(x => x.ID == ID_Salon);
                return salon;
            }
        }
    }
}
