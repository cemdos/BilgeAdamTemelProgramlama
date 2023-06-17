using StokTakip.Model;
using StokTakip.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip.UI.WinForm.AltFormlar
{
    public partial class FormMusteri : Form
    {
        public Musteri musteri { get; set; }
        public FormMusteri()
        {
            InitializeComponent();
        }

        public FormMusteri(Musteri gonderilenMusteri)
        {
            InitializeComponent();
            this.musteri = gonderilenMusteri;
            FormaYukle(gonderilenMusteri);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FormdanCek();
            DialogResult = DialogResult.OK;
            Close();
        }

        void FormaYukle(Musteri musteri)
        {
            this.musteri = musteri;
            txtAdi.Text = musteri.Adi;
            txtSoyadi.Text = musteri.Soyadi;
            rbErkek.Checked = musteri.Cinsiyet == Cinsiyet.Erkek;
            rbKadiin.Checked = musteri.Cinsiyet == Cinsiyet.Kadin;
        }

        void FormdanCek()
        {
            this.musteri.Adi = txtAdi.Text;
            this.musteri.Soyadi = txtSoyadi.Text;
            this.musteri.Cinsiyet = rbKadiin.Checked ? Cinsiyet.Kadin : Cinsiyet.Erkek;
        }

    }
}
