using SinemaBiletOtomasyonu.Enum;
using SinemaBiletOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Business
{
    public class GosterimIslemleri
    {
        public List<Salon> FilmeGoreSalonGetir(Film film,DateTime tarih)
        {
            var GosterimListesi = Database.Instance.GosterimTablolari
                                            .Where(x => 
                                                x.Film.Adi == film.Adi && 
                                                x.Tarih.ToShortDateString() == tarih.ToShortDateString()
                                             ).ToList();
            return GosterimListesi.Select(x => (Salon)x.Salon).ToList();
        }
      
        public List<Seans> SeansGetir(Film film,Salon salon, DateTime tarih)
        {
            var SeansListesi = Database.Instance.GosterimTablolari
                                            .Where(x =>
                                                x.Film.Adi == film.Adi &&
                                                x.Salon.Adi == salon.Adi &&
                                                x.Tarih.ToShortDateString() == tarih.ToShortDateString()
                                             ).ToList();
            return SeansListesi.Select(x => (Seans)x.Seans).ToList();
        }
    }
}
