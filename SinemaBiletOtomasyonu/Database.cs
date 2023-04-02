using SinemaBiletOtomasyonu.Enum;
using SinemaBiletOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu
{
    public class Database
    {
        private static Database instance;

        public static Database Instance
        {
            get {
                if (instance is null)
                    instance = new Database();
                return instance; 
            }
        }

        public List<Musteri> Musteriler { get; private set; }
        public List<Personel> Personeller { get; private set; }
        public List<Film> Filmler { get; set; }
        public List<Salon> Salonlar { get; set; }
        public List<GosterimTablo> GosterimTablolari { get; set; }

        public List<Kullanici> Kullanicilar
        {
            get {
                var list = new List<Kullanici>();
                list.AddRange(Musteriler);
                list.AddRange(Personeller);
                return list; 
            }
        }

        public Database()
        {
            IlkMusterileriYukle();
            IlkPersonelleriYukle();
            IlkFilmleriYukle();
            IlkSalonlariYukle();
            IlkGosterimTablosunuYukle();
        }

        private void IlkMusterileriYukle()
        {
            if (Musteriler is null)
            {
                Musteriler = new List<Musteri>();

                #region 1.Musteri
                {
                    var yeniMusteri = new Musteri();
                    yeniMusteri.KullaniciAdi = "cemdos";
                    yeniMusteri.Sifre = "1234";
                    Musteriler.Add(yeniMusteri);
                }
                #endregion

                #region 2.Musteri
                {
                    var yeniMusteri = new Musteri();
                    yeniMusteri.KullaniciAdi = "evren";
                    yeniMusteri.Sifre = "1234";
                    Musteriler.Add(yeniMusteri);
                }
                #endregion
            }
        }
        private void IlkPersonelleriYukle()
        {
            if (Personeller is null)
            {
                Personeller = new List<Personel>();

                #region 1.Personel
                {
                    var yeniPersonel = new Personel();
                    yeniPersonel.KullaniciAdi = "personel1";
                    yeniPersonel.Sifre = "1234";
                    Personeller.Add(yeniPersonel);
                }
                #endregion

                #region 2.Personel
                {
                    var yeniPersonel = new Personel();
                    yeniPersonel.KullaniciAdi = "personel2";
                    yeniPersonel.Sifre = "1234";
                    Personeller.Add(yeniPersonel);
                }
                #endregion
            }
        }
        private void IlkFilmleriYukle()
        {
            if (Filmler is null)
            {
                Filmler = new List<Film>();

                #region 1.Film
                {
                    var yeniFilm = new Film();
                    yeniFilm.Adi = "Yıldızlar Arası";
                    yeniFilm.Tur = FilmTuru.BilimKurgu;
                    Filmler.Add(yeniFilm);
                }
                #endregion

                #region 2.Film
                {
                    var yeniFilm = new Film();
                    yeniFilm.Adi = "Wall-E";
                    yeniFilm.Tur = FilmTuru.BilimKurgu;
                    Filmler.Add(yeniFilm);
                }
                #endregion
            }
        }
        private void IlkSalonlariYukle()
        {
            if (Salonlar is null)
            {
                Salonlar = new List<Salon>();

                #region 1.Film
                {
                    var yeniSalon = new Salon();
                    yeniSalon.SalonAdi= "Salon 1";
                    yeniSalon.Kapasite = 200;
                    Salonlar.Add(yeniSalon);
                }
                #endregion

                #region 2.Film
                {
                    var yeniSalon = new Salon();
                    yeniSalon.SalonAdi = "Salon 2";
                    yeniSalon.Kapasite = 70;
                    Salonlar.Add(yeniSalon);
                }
                #endregion
            }
        }
        private void IlkGosterimTablosunuYukle()
        {
            if (GosterimTablolari is null)
            {
                GosterimTablolari = new List<GosterimTablo>();

                #region 1.Gosterim
                {
                    var yeniGosterim = new GosterimTablo();
                    yeniGosterim.Salon = Salonlar[0];
                    yeniGosterim.Film = Filmler[0];
                    yeniGosterim.Seans = Seans.Seans_13_15;
                    yeniGosterim.Tarih = new DateTime(2023, 4, 2);
                    GosterimTablolari.Add(yeniGosterim);
                }
                #endregion

                #region 2.Gosterim
                {
                    var yeniGosterim = new GosterimTablo();
                    yeniGosterim.Salon = Salonlar[1];
                    yeniGosterim.Film = Filmler[0];
                    yeniGosterim.Seans = Seans.Seans_19_21;
                    yeniGosterim.Tarih = new DateTime(2023, 4, 2);
                    GosterimTablolari.Add(yeniGosterim);
                }
                #endregion
            }
        }
    }
}
