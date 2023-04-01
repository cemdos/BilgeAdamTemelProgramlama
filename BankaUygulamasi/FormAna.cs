using BankaUygulamasi.Controller;
using BankaUygulamasi.Enum;
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
        private MusteriIslemleri musteriIslemleri { get; set; }

        public FormAna()
        {
            InitializeComponent();
            KullaniciYetkilerineGoreGoster();
            OdemeTipiDoldur();
            YasadigiSehirListesiDoldur();
            HesaplTipleriDoldur();
            FormuDoldur();
        }

        private void OdemeTipiDoldur()
        {
            var liste = new List<KeyValuePair<int, string>>();
            liste.Add(new KeyValuePair<int, string>(0, "Seçiniz"));
            liste.AddRange(Database.Database.OdemeTipListe.ToList());
            cbOdemeTipi.DataSource = liste;
        }

        private void YasadigiSehirListesiDoldur()
        {
            cbYasadigiSehir.DataSource = Database.Database.Sehirler;
            cbYasadigiSehir.DisplayMember = "SehirAdi";
            cbYasadigiSehir.ValueMember = "SehirKodu";
        }

        private void HesaplTipleriDoldur()
        {
            var data = System.Enum.GetValues(typeof(HesapTipi));
            cbHesapTipi.DataSource = data;
            dgvHesaplar.DataSource = musteriIslemleri.AktifMusteri.Hesaplar;
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

        private HesapTipi SecilenHesapTipi()
        {
            if (radioTL.Checked)
                return HesapTipi.Tl;
            else if (radioUSD.Checked)
                return HesapTipi.Usd;
            else
                return HesapTipi.Euro;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            var aktifHesap = musteriIslemleri.AktifMusteri.Hesaplar.Find(x => x.HesapTipi == SecilenHesapTipi());
            if (aktifHesap.Bakiye < nudMiktar.Value)
            {
                MessageBox.Show("Bakiye Yetersiz");
                return;
            }

            var gonderilekMusteri = musteriIslemleri.MusteriAra(txtHesapNo.Text).gonderilecekMusteri;
            var Hesap = gonderilekMusteri.Hesaplar.Find(x => x.HesapNo.ToString() == txtHesapNo.Text);
            Hesap.Bakiye += nudMiktar.Value;
            aktifHesap.Bakiye -= nudMiktar.Value;
            MessageBox.Show("Para Gönderme işlemi Başarılı");
        }

        private void btnOdemeGonder_Click(object sender, EventArgs e)
        {
            var secilenOdemeTipi = (KeyValuePair<int, string>)cbOdemeTipi.SelectedItem;
            var aktifHesap = musteriIslemleri.AktifMusteri.Hesaplar.Find(x => x.HesapTipi == HesapTipi.Tl);
            if(aktifHesap.Bakiye< secilenOdemeTipi.Key)
            {
                MessageBox.Show("Bakiyeniz Yetersiz");
                return;
            }

            aktifHesap.Bakiye -= secilenOdemeTipi.Key;
            MessageBox.Show("Ödemeniz Gerçekleşti");
        }

        private void cbYasadigiSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ilceListesi = Database.Database.Ilceler.Where(x => x.SehirKodu == ((Sehir)cbYasadigiSehir.SelectedItem)?.SehirKodu).ToList();
            cbYasadigiIce.DataSource = ilceListesi;
            cbYasadigiIce.DisplayMember = "Ilceadi";
            cbYasadigiIce.ValueMember = "Ilceadi";
        }

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {
            if(musteriIslemleri.MusterideHesapTanimliMi((HesapTipi)cbHesapTipi.SelectedItem))
            {
                MessageBox.Show("Hesap Daha önceden tanımlanmış");
                return;
            }

            musteriIslemleri.AktifMusteri.Hesaplar.Add(new Hesap
            {
                Bakiye = 0,
                HesapNo = Guid.NewGuid(),
                HesapTipi = (HesapTipi)cbHesapTipi.SelectedItem
            });
            dgvHesaplar.DataSource = null;
            dgvHesaplar.DataSource = musteriIslemleri.AktifMusteri.Hesaplar;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var seciliHesapNo = dgvHesaplar.SelectedRows[0].Cells["HesapNo"].Value.ToString();
            var seciliHesap = musteriIslemleri.AktifMusteri.Hesaplar.Find(x => x.HesapNo.ToString() == seciliHesapNo);
            musteriIslemleri.AktifMusteri.Hesaplar.Remove(seciliHesap);
            dgvHesaplar.DataSource = null;
            dgvHesaplar.DataSource = musteriIslemleri.AktifMusteri.Hesaplar;
        }

        private void FormuDoldur()
        {
            txtAd.Text = musteriIslemleri.AktifMusteri.Ad;
            txtSoyad.Text = musteriIslemleri.AktifMusteri.Soyad;
            txtEmail.Text = musteriIslemleri.AktifMusteri.MailAdresi;
            txtSifre.Text = musteriIslemleri.AktifMusteri.Sifre;
            cbYasadigiSehir.SelectedItem = Database.Database.Sehirler.Find(x => x.SehirAdi == musteriIslemleri.AktifMusteri.YasadigiSehir);
            cbYasadigiIce.SelectedItem = Database.Database.Ilceler.Find(x => x.Ilceadi == musteriIslemleri.AktifMusteri.YasadigiIlce);
            rbErkek.Checked = musteriIslemleri.AktifMusteri.Cinsiyeti == Cinsiyet.Erkek;
            rbKadin.Checked = !rbErkek.Checked;
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            musteriIslemleri.AktifMusteri.Ad = txtAd.Text;
            musteriIslemleri.AktifMusteri.Soyad = txtSoyad.Text;
            musteriIslemleri.AktifMusteri.Sifre = txtSifre.Text;
            musteriIslemleri.AktifMusteri.MailAdresi = txtEmail.Text;
            musteriIslemleri.AktifMusteri.Cinsiyeti = rbKadin.Checked ? Cinsiyet.Kadin : Cinsiyet.Erkek;
            musteriIslemleri.AktifMusteri.YasadigiSehir = ((Sehir)cbYasadigiSehir.SelectedItem).SehirAdi;
            musteriIslemleri.AktifMusteri.YasadigiIlce = ((Ilce)cbYasadigiIce.SelectedItem)?.Ilceadi ?? "Tanımsız";
            MessageBox.Show("Değişiklikler Kaydedildi");
        }
    }
}
