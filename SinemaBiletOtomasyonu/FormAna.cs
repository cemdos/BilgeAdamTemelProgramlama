using SinemaBiletOtomasyonu.Business;
using SinemaBiletOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletOtomasyonu
{
    public partial class FormAna : Form
    {
        private Kullanici aktifKullanici { get; }
        private GosterimIslemleri gosteriServis { get; }

        public FormAna(Kullanici kullanici)
        {
            InitializeComponent();
            aktifKullanici = kullanici;
            gosteriServis = new GosterimIslemleri();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            this.Text = $"Hoşgeldin {aktifKullanici.KullaniciAdi}";
            FilmleriDoldur();
        }

        private void FilmleriDoldur()
        {
            cbFilmAdi.DataSource = Database.Instance.Filmler;
            cbFilmAdi.DisplayMember = nameof(Film.Adi);
        }

        private void cbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenFilm = (Film)cbFilmAdi.SelectedItem;
            cbSalonAdi.DataSource = gosteriServis.FilmeGoreSalonGetir(secilenFilm, dtpTarih.Value);
            cbSalonAdi.DisplayMember = nameof(Salon.SalonAdi);
            cbSeans.DataSource = null;
        }

        private void cbSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenFilm = (Film)cbFilmAdi.SelectedItem;
            var secilenSalon = (Salon)cbSalonAdi.SelectedItem;
            cbSeans.DataSource = gosteriServis.SeansGetir(secilenFilm,secilenSalon, dtpTarih.Value);
        }
    }
}
