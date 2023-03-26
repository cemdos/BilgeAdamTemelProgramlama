using BankaUygulamasi.Enum;
using BankaUygulamasi.Model;
using System;
using System.Collections.Generic;
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
