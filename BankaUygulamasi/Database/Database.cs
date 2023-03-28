using BankaUygulamasi.Enum;
using BankaUygulamasi.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Database
{
    public class Database
    {
        private static List<Musteri> musteriler;
        private static List<Personel> personeller;

        public static List<Kullanici> Kullanicilar
        {
            get
            {
                var list = new List<Kullanici>();
                list.AddRange(Musteriler);
                list.AddRange(Personeller);
                return list;

            }
        }

        public static List<Hesap> MusteriHesaplari
        {
            get
            {
                var hesaplar = Musteriler.Select(x => x.Hesaplar);
                var list = new List<Hesap>();
                foreach (var item in hesaplar)
                    list.AddRange(item);
                return list;
            }
        }

        public static List<Musteri> Musteriler
        {
            get
            {
                if (musteriler == null)
                    musteriler = VarsayilanMusterileriYukle();
                return musteriler;
            }
        }

        public static List<Personel> Personeller
        {
            get
            {
                if (personeller == null)
                    personeller = VarsayilanPersonelleriYukle();
                return personeller;
            }
        }

        public static Dictionary<int,string> OdemeTipListe
        {
            get
            {
                var liste = new Dictionary<int, string>();
                liste.Add(100,"Şans Oyunları");
                liste.Add(400,"MTV");
                liste.Add(300,"KYK Yut Ödemeleri");
                return liste;
            }
        }

        public static List<Sehir> Sehirler
        {
            get
            {
                var liste = new List<Sehir>();
                #region İl listesi
                liste.Add(new Sehir(1, "ADANA"));
                liste.Add(new Sehir(2, "ADIYAMAN"));
                liste.Add(new Sehir(3, "AFYONKARAHİSAR"));
                liste.Add(new Sehir(4, "AĞRI"));
                liste.Add(new Sehir(5, "AMASYA"));
                liste.Add(new Sehir(6, "ANKARA"));
                liste.Add(new Sehir(7, "ANTALYA"));
                liste.Add(new Sehir(8, "ARTVİN"));
                liste.Add(new Sehir(9, "AYDIN"));
                liste.Add(new Sehir(10, "BALIKESİR"));
                liste.Add(new Sehir(11, "BİLECİK"));
                liste.Add(new Sehir(12, "BİNGÖL"));
                liste.Add(new Sehir(13, "BİTLİS"));
                liste.Add(new Sehir(14, "BOLU"));
                liste.Add(new Sehir(15, "BURDUR"));
                liste.Add(new Sehir(16, "BURSA"));
                liste.Add(new Sehir(17, "ÇANAKKALE"));
                liste.Add(new Sehir(18, "ÇANKIRI"));
                liste.Add(new Sehir(19, "ÇORUM"));
                liste.Add(new Sehir(20, "DENİZLİ"));
                liste.Add(new Sehir(21, "DİYARBAKIR"));
                liste.Add(new Sehir(22, "EDİRNE"));
                liste.Add(new Sehir(23, "ELAZIĞ"));
                liste.Add(new Sehir(24, "ERZİNCAN"));
                liste.Add(new Sehir(25, "ERZURUM"));
                liste.Add(new Sehir(26, "ESKİŞEHİR"));
                liste.Add(new Sehir(27, "GAZİANTEP"));
                liste.Add(new Sehir(28, "GİRESUN"));
                liste.Add(new Sehir(29, "GÜMÜŞHANE"));
                liste.Add(new Sehir(30, "HAKKARİ"));
                liste.Add(new Sehir(31, "HATAY"));
                liste.Add(new Sehir(32, "ISPARTA"));
                liste.Add(new Sehir(33, "MERSİN"));
                liste.Add(new Sehir(34, "İSTANBUL"));
                liste.Add(new Sehir(35, "İZMİR"));
                liste.Add(new Sehir(36, "KARS"));
                liste.Add(new Sehir(37, "KASTAMONU"));
                liste.Add(new Sehir(38, "KAYSERİ"));
                liste.Add(new Sehir(39, "KIRKLARELİ"));
                liste.Add(new Sehir(40, "KIRŞEHİR"));
                liste.Add(new Sehir(41, "KOCAELİ"));
                liste.Add(new Sehir(42, "KONYA"));
                liste.Add(new Sehir(43, "KÜTAHYA"));
                liste.Add(new Sehir(44, "MALATYA"));
                liste.Add(new Sehir(45, "MANİSA"));
                liste.Add(new Sehir(46, "KAHRAMANMARAŞ"));
                liste.Add(new Sehir(47, "MARDİN"));
                liste.Add(new Sehir(48, "MUĞLA"));
                liste.Add(new Sehir(49, "MUŞ"));
                liste.Add(new Sehir(50, "NEVŞEHİR"));
                liste.Add(new Sehir(51, "NİĞDE"));
                liste.Add(new Sehir(52, "ORDU"));
                liste.Add(new Sehir(53, "RİZE"));
                liste.Add(new Sehir(54, "SAKARYA"));
                liste.Add(new Sehir(55, "SAMSUN"));
                liste.Add(new Sehir(56, "SİİRT"));
                liste.Add(new Sehir(57, "SİNOP"));
                liste.Add(new Sehir(58, "SİVAS"));
                liste.Add(new Sehir(59, "TEKİRDAĞ"));
                liste.Add(new Sehir(60, "TOKAT"));
                liste.Add(new Sehir(61, "TRABZON"));
                liste.Add(new Sehir(62, "TUNCELİ"));
                liste.Add(new Sehir(63, "ŞANLIURFA"));
                liste.Add(new Sehir(64, "UŞAK"));
                liste.Add(new Sehir(65, "VAN"));
                liste.Add(new Sehir(66, "YOZGAT"));
                liste.Add(new Sehir(67, "ZONGULDAK"));
                liste.Add(new Sehir(68, "AKSARAY"));
                liste.Add(new Sehir(69, "BAYBURT"));
                liste.Add(new Sehir(70, "KARAMAN"));
                liste.Add(new Sehir(71, "KIRIKKALE"));
                liste.Add(new Sehir(72, "BATMAN"));
                liste.Add(new Sehir(73, "ŞIRNAK"));
                liste.Add(new Sehir(74, "BARTIN"));
                liste.Add(new Sehir(75, "ARDAHAN"));
                liste.Add(new Sehir(76, "IĞDIR"));
                liste.Add(new Sehir(77, "YALOVA"));
                liste.Add(new Sehir(78, "KARABÜK"));
                liste.Add(new Sehir(79, "KİLİS"));
                liste.Add(new Sehir(80, "OSMANİYE"));
                liste.Add(new Sehir(81, "DÜZCE"));
                #endregion
                return liste;
            }
        }

        public static List<Ilce> Ilceler
        {
            get
            {
                var liste = new List<Ilce>();
                #region İl listesi

                liste.Add(new Ilce(1, "ALADAĞ"));
                liste.Add(new Ilce(1, "CEYHAN"));
                liste.Add(new Ilce(1, "ÇUKUROVA"));
                liste.Add(new Ilce(1, "FEKE"));
                liste.Add(new Ilce(1, "İMAMOĞLU"));
                liste.Add(new Ilce(1, "KARAİSALI"));
                liste.Add(new Ilce(1, "KARATAŞ"));
                liste.Add(new Ilce(1, "KOZAN"));
                liste.Add(new Ilce(1, "POZANTI"));
                liste.Add(new Ilce(1, "SAİMBEYLİ"));
                liste.Add(new Ilce(1, "SARIÇAM"));
                liste.Add(new Ilce(1, "SEYHAN"));
                liste.Add(new Ilce(1, "TUFANBEYLİ"));
                liste.Add(new Ilce(1, "YUMURTALIK"));
                liste.Add(new Ilce(1, "YÜREĞİR"));

                liste.Add(new Ilce(34, "ADALAR"));
                liste.Add(new Ilce(34, "ARNAVUTKÖY"));
                liste.Add(new Ilce(34, "ATAŞEHİR"));
                liste.Add(new Ilce(34, "AVCILAR"));
                liste.Add(new Ilce(34, "BAĞCILAR"));
                liste.Add(new Ilce(34, "BAHÇELİEVLER"));
                liste.Add(new Ilce(34, "BAKIRKÖY"));
                liste.Add(new Ilce(34, "BAŞAKŞEHİR"));
                liste.Add(new Ilce(34, "BAYRAMPAŞA"));
                liste.Add(new Ilce(34, "BEŞİKTAŞ"));
                liste.Add(new Ilce(34, "BEYKOZ"));
                liste.Add(new Ilce(34, "BEYLİKDÜZÜ"));
                liste.Add(new Ilce(34, "BEYOĞLU"));
                liste.Add(new Ilce(34, "BÜYÜKÇEKMECE"));
                liste.Add(new Ilce(34, "ÇATALCA"));
                liste.Add(new Ilce(34, "ÇEKMEKÖY"));
                liste.Add(new Ilce(34, "ESENLER"));
                liste.Add(new Ilce(34, "ESENYURT"));
                liste.Add(new Ilce(34, "EYÜPSULTAN"));
                liste.Add(new Ilce(34, "FATİH"));
                liste.Add(new Ilce(34, "GAZİOSMANPAŞA"));
                liste.Add(new Ilce(34, "GÜNGÖREN"));
                liste.Add(new Ilce(34, "KADIKÖY"));
                liste.Add(new Ilce(34, "KAĞITHANE"));
                liste.Add(new Ilce(34, "KARTAL"));
                liste.Add(new Ilce(34, "KÜÇÜKÇEKMECE"));
                liste.Add(new Ilce(34, "MALTEPE"));
                liste.Add(new Ilce(34, "PENDİK"));
                liste.Add(new Ilce(34, "SANCAKTEPE"));
                liste.Add(new Ilce(34, "SARIYER"));
                liste.Add(new Ilce(34, "SİLİVRİ"));
                liste.Add(new Ilce(34, "SULTANBEYLİ"));
                liste.Add(new Ilce(34, "SULTANGAZİ"));
                liste.Add(new Ilce(34, "ŞİLE"));
                liste.Add(new Ilce(34, "ŞİŞLİ"));
                liste.Add(new Ilce(34, "TUZLA"));
                liste.Add(new Ilce(34, "ÜMRANİYE"));
                liste.Add(new Ilce(34, "ÜSKÜDAR"));
                liste.Add(new Ilce(34, "ZEYTİNBURNU"));
                #endregion
                return liste;
            }
        }

        private static List<Musteri> VarsayilanMusterileriYukle()
        {
            var eklenecekMusteriler = new List<Musteri>();
           
            #region 1.Musteri
            var yeniMusteri = new Musteri
            {
                Tc = "12345678901",
                Ad = "Cem",
                Soyad = "DOS",
                Cinsiyeti = Enum.Cinsiyet.Erkek,
                MailAdresi = "dos.cem@gmail.com",
                Rolu = Enum.Rol.Musteri,
                Sifre = "1234",
            };
            yeniMusteri.Hesaplar = new List<Hesap>();
            yeniMusteri.Hesaplar.Add(new Hesap
            {
                HesapNo = Guid.NewGuid(),
                Bakiye = 50,
                HesapTipi = Enum.HesapTipi.Tl
            });
            yeniMusteri.Hesaplar.Add(new Hesap
            {
                HesapNo = Guid.NewGuid(),
                Bakiye = 100,
                HesapTipi = Enum.HesapTipi.Usd
            });
            eklenecekMusteriler.Add(yeniMusteri);
            #endregion

            #region 2.Musteri
            yeniMusteri = new Musteri();
            yeniMusteri.Tc = "23456789012";
            yeniMusteri.Ad = "ahmet";
            yeniMusteri.Soyad = "Yener";
            yeniMusteri.Cinsiyeti = Enum.Cinsiyet.Erkek;
            yeniMusteri.MailAdresi = "ahmet.yener@gmail.com";
            yeniMusteri.Rolu = Enum.Rol.Musteri;
            yeniMusteri.Sifre = "1234";
            yeniMusteri.Hesaplar = new List<Hesap>();
            yeniMusteri.Hesaplar.Add(new Hesap
            {
                HesapNo = Guid.NewGuid(),
                Bakiye = 150,
                HesapTipi = Enum.HesapTipi.Tl
            });
            yeniMusteri.Hesaplar.Add(new Hesap
            {
                HesapNo = Guid.NewGuid(),
                Bakiye = 1000,
                HesapTipi = Enum.HesapTipi.Euro
            });
            eklenecekMusteriler.Add(yeniMusteri);
            #endregion

            return eklenecekMusteriler;

        }
        private static List<Personel> VarsayilanPersonelleriYukle()
        {
            var liste = new List<Personel>();
            liste.Add(new Personel
            {
                Tc = "34567890123",
                Sifre = "1234",
                Ad = "Ali",
                Soyad = "Yılmaz",
                Cinsiyeti = Enum.Cinsiyet.Erkek,
                MailAdresi = "ali@ali.com",
                OlusturmaTarihi = DateTime.Now,
                Departmani = Enum.Departman.Bireysel,
                Rolu = Enum.Rol.Personel,
            });
            return liste;
        }

    }
}
