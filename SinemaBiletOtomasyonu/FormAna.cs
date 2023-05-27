using SinemaBiletOtomasyonu.Business;
using SinemaBiletOtomasyonu.Enum;
using SinemaBiletOtomasyonu.FormModel;
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
        private List<Koltuk> Koltuklar { get; set; }

        private MusteriIsLemleri musteriIslemleri;

        public FormAna(Kullanici kullanici)
        {
            InitializeComponent();
            aktifKullanici = kullanici;
            gosteriServis = new GosterimIslemleri();
            musteriIslemleri = new MusteriIsLemleri(aktifKullanici);

            dtpTarih.MinDate = DateTime.Now;
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            this.Text = $"Hoşgeldin {aktifKullanici.KullaniciAdi}";
            FilmleriDoldur();

            //object a = new Koltuk(20,20);
            //object b = new Koltuk(20, 20);
            //bool cevap = a == b;

        }

        private void FilmleriDoldur()
        {
            cbFilmAdi.DataSource = Database.Instance.Filmler;
            cbFilmAdi.DisplayMember = nameof(Film.Adi);
        }

        private void cbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilmAdi.SelectedItem == null)
                return;

            var secilenFilm = (Film)cbFilmAdi.SelectedItem;
            cbSalonAdi.DataSource = gosteriServis.FilmeGoreSalonGetir(secilenFilm, dtpTarih.Value);
            cbSalonAdi.DisplayMember = nameof(Salon.Adi);
            cbSeans.DataSource = null;
            timerFilmBaslamaSuresi.Enabled = false;
        }

        private void cbSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenFilm = (Film)cbFilmAdi.SelectedItem;
            var secilenSalon = (Salon)cbSalonAdi.SelectedItem;
            cbSeans.DataSource = gosteriServis.SeansGetir(secilenFilm, secilenSalon, dtpTarih.Value);
            timerFilmBaslamaSuresi.Enabled = false;
        }

        private void KoltuklariDiz(Salon salon)
        {
            Koltuklar = new List<Koltuk>();
            int x = 20, y = 160;
            for (int i = 0; i < salon.Kapasite; i++)
            {
                var yeniKoltuk = new Koltuk(x, y);
                yeniKoltuk.ContextMenuStrip = contextMenuStripIslemler;
                yeniKoltuk.KoltukNumarasi = i + 1;
                yeniKoltuk.Durumu = KoltukGetir(i+ 1)?.Durumu ?? KoltukDurum.Bos;
                yeniKoltuk.Enabled = KoltukGetir(i + 1)?.Enabled?? true;
                yeniKoltuk.BackColor = KoltukGetir(i + 1)?.BackColor ?? yeniKoltuk.BackColor;
                Koltuklar.Add(yeniKoltuk);
                x += yeniKoltuk.Width + 5;
                if ((i + 1) % 18 == 0)
                {
                    y += yeniKoltuk.Height + 5;
                    x = 20;
                }
            }
            var silinecekKoltuklar = this.Controls.OfType<Koltuk>().ToList();
            foreach (var item in silinecekKoltuklar)
                this.Controls.Remove(item);

            this.Controls.AddRange(Koltuklar.ToArray());
        }

        private Koltuk KoltukGetir(int KoltukNumarasi)
        {
            var salon = (Salon)cbSalonAdi.SelectedItem;
            var tarih = DateTime.Parse(dtpTarih.Value.ToShortDateString());
            var seans = (Seans)cbSeans.SelectedItem;

            var koltuk = Database.Instance.Biletler.Find(x =>
                                x.Tarih == tarih &&
                                x.Salon == salon &&
                                x.Seans == seans &&
                                x.Koltuk.KoltukNumarasi == KoltukNumarasi)?.Koltuk;
            return koltuk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KoltuklariDiz((Salon)cbSalonAdi.SelectedItem);
            //BiletleriGetir();
            timerFilmBaslamaSuresi.Enabled = true;
        }

        private void satınAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            ContextMenuStrip owner = (ContextMenuStrip)clickedItem.GetCurrentParent();
            Koltuk aktifKoltuk = (Koltuk)owner.SourceControl;

            var yeniBilet = new Bilet();
            yeniBilet.Salon = (Salon)cbSalonAdi.SelectedItem;
            yeniBilet.Tarih = DateTime.Parse(dtpTarih.Value.ToShortDateString());
            yeniBilet.Seans = (Seans)cbSeans.SelectedItem;
            yeniBilet.Koltuk= aktifKoltuk;
            yeniBilet.Film = (Film)cbFilmAdi.SelectedItem;
            yeniBilet.SatinAlanMusteri = musteriIslemleri.aktifMusteri;
            Database.Instance.Biletler.Add(yeniBilet);

            MessageBox.Show("Bilet Satınalındı");
            aktifKoltuk.Durumu = KoltukDurum.SatinAlinmis;
            aktifKoltuk.BackColor = Color.DarkRed;
            aktifKoltuk.Enabled = false;
        }

        //private void BiletleriGetir()
        //{
        //    var ilgiliBiletler = Database.Instance.Biletler.Where(x =>
        //                    x.Film.Adi == ((Film)cbFilmAdi.SelectedItem).Adi &&
        //                    x.Salon.SalonAdi == ((Salon)cbSalonAdi.SelectedItem).SalonAdi &&
        //                    x.Tarih.ToShortDateString() == dtpTarih.Value.ToShortDateString() &&
        //                    x.Seans == ((Seans)cbSeans.SelectedItem)).ToList();
        //    foreach (var item in Koltuklar)
        //    {
        //        if (ilgiliBiletler.Find(x => x.Koltuk.KoltukNumarasi == item.KoltukNumarasi) != null)
        //        {
        //            item.Durumu = KoltukDurum.SatinAlinmis;
        //            item.BackColor = Color.DarkRed;
        //            item.Enabled = false;
        //        }
        //    }
        //}

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            ContextMenuStrip owner = (ContextMenuStrip)clickedItem.GetCurrentParent();
            Koltuk aktifKoltuk = (Koltuk)owner.SourceControl;

            var yeniBilet = new Bilet();
            yeniBilet.Salon = (Salon)cbSalonAdi.SelectedItem;
            yeniBilet.Tarih = DateTime.Parse(dtpTarih.Value.ToShortDateString());
            yeniBilet.Seans = (Seans)cbSeans.SelectedItem;
            yeniBilet.Koltuk = aktifKoltuk;
            yeniBilet.Film = (Film)cbFilmAdi.SelectedItem;
            yeniBilet.SatinAlanMusteri = musteriIslemleri.aktifMusteri;
            Database.Instance.Biletler.Add(yeniBilet);

            MessageBox.Show("Bilet Rezerve Edildi.");
            aktifKoltuk.Durumu = KoltukDurum.Rezerve;
            aktifKoltuk.BackColor = Color.DarkOrange;
            aktifKoltuk.Enabled = false;
        }

        private void timerFilmBaslamaSuresi_Tick(object sender, EventArgs e)
        {
            var tarih = DateTime.Parse(dtpTarih.Value.ToShortDateString()).AddHours((int)cbSeans.SelectedItem);
            double kalanSure = Math.Round((tarih - DateTime.Now).TotalSeconds, 0);
            btnKalanSure.Text = kalanSure.ToString();
        }
    }
}
