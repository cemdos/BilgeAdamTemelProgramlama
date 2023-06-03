using NorthwindOtomasyon.AltFormlar;
using NorthwindOtomasyon.Model;
using NorthwindOtomasyon.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NORTHWNDEntities db = new NORTHWNDEntities();
            dgvCategory.DataSource = Database.DB.Categories.Select(x=>new CategoryList(){
                KategoriAdi = x.CategoryName,
                Aciklama = x.Description
            }).ToList();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategoriEkle frm = new FormKategoriEkle();
            frm.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var seciliId = (int)dgvCategory.SelectedRows[0].Cells["CategoryID"].Value;
            ////NORTHWNDEntities db = new NORTHWNDEntities();
            Categories silinecekKategori = Database.DB.Categories.Where(x => x.CategoryID == seciliId).FirstOrDefault();
            Database.DB.Categories.Remove(silinecekKategori);
            Database.DB.SaveChanges();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var seciliId = (int)dgvCategory.SelectedRows[0].Cells["CategoryID"].Value;
            //NORTHWNDEntities db = new NORTHWNDEntities();
            Categories duzenlenecekKAtegori = Database.DB.Categories.Where(x => x.CategoryID == seciliId).FirstOrDefault();
            FormKategoriEkle frm = new FormKategoriEkle(duzenlenecekKAtegori);
            frm.ShowDialog();
        }
    }
}
