using SinemaBiletOtomasyonu.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Model
{
    public class Salon
    {
        public string SalonAdi { get; set; }

        private int kapasite;
        public int Kapasite
        {
            get { return kapasite; }
            set {
                if (value < 10 || value > 200)
                    throw new SalonKapasiteException();
                kapasite = value; 
            }
        }
    }
}
