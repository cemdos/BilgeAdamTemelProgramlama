using NorthwindOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindOtomasyon.AltFormlar
{
    public partial class FormKategoriEkle : Form
    {
        public Categories kategori { get; set; }
        public FormKategoriEkle()
        {
            InitializeComponent();
            btnEkle.Text = "Ekle";
        }

        public FormKategoriEkle(Categories duzenlenecekAtegori)
        {
            InitializeComponent();
            kategori = duzenlenecekAtegori;
            txtKategoriAdi.Text = duzenlenecekAtegori.CategoryName;
            txtAciklama.Text = duzenlenecekAtegori.Description;
            btnEkle.Text = "Düzenle";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Her defasında sql'e gidip tüm dbYi modellemesini engellemek icin bunu kaldırıyoruz
            //NORTHWNDEntities db = new NORTHWNDEntities();

            kategori = kategori ?? new Categories(); ;
            kategori.CategoryName = txtKategoriAdi.Text;
            kategori.Description = txtAciklama.Text;
            Database.DB.Categories.AddOrUpdate(kategori);
            Database.DB.SaveChanges();
        }
    }
}
