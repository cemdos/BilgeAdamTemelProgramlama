using BankaUygulamasi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
			get {
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
            var yeniMusteri = new Musteri
            {
                Tc = "12345678901",
                Ad = "Cem",
                Soyad = "DOS",
                Cinsiyeti = Enum.Cinsiyet.Erkek,
                MailAdresi = "dos.cem@gmail.com",
                Rolu = Enum.Rol.Musteri,
                Sifre = "1234"
            };
            eklenecekMusteriler.Add(yeniMusteri);

            eklenecekMusteriler.Add(new Musteri
            {
                Tc = "23456789012",
                Ad = "ahmet",
                Soyad = "Yener",
                Cinsiyeti = Enum.Cinsiyet.Erkek,
                MailAdresi = "ahmet.yener@gmail.com",
                Rolu = Enum.Rol.Musteri,
                Sifre = "1234"
            });
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
                Rolu= Enum.Rol.Personel,
            });
            return liste;
        }

    }
}
