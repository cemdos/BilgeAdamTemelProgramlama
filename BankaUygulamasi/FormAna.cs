using BankaUygulamasi.Controller;
using BankaUygulamasi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaUygulamasi
{
    public partial class FormAna : Form
    {
        private MusteriIslemleri musteriIslemleri { get; set;}

        public FormAna()
        {
            InitializeComponent();
            KullaniciYetkilerineGoreGoster();
        }

        private void KullaniciYetkilerineGoreGoster()
        {
            switch (KullaniciIslemleri.AktifKullanici.Rolu)
            {
                case Enum.Rol.Musteri:
                    tabPersonel.Dispose();
                    tabRaporlar.Dispose();
                    MusteriIslemleri();
                    break;
                case Enum.Rol.Personel:
                    tabRaporlar.Dispose();
                    tabHesaplar.Dispose();
                    tabOdemeler.Dispose();
                    tabParaTransfer.Dispose();
                    break;
                case Enum.Rol.Yonetici:
                    tabHesaplar.Dispose();
                    tabOdemeler.Dispose();
                    tabParaTransfer.Dispose();
                    tabPersonel.Dispose();
                    break;
            }
        }

        private void MusteriIslemleri()
        {
            musteriIslemleri = new MusteriIslemleri(KullaniciIslemleri.AktifKullanici);
            var AktifMusteri = musteriIslemleri.AktifMusteri;
            dgvMusteriHesaplari.DataSource = AktifMusteri.Hesaplar;
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            lblKarsilama.Text = $"Hoşgeldiniz {KullaniciIslemleri.AktifKullanici.Ad} {KullaniciIslemleri.AktifKullanici.Soyad}";
        }
    }
}
