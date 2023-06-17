using StokTakip.BLL;
using StokTakip.Model;
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
    public partial class FormAna : Form
    {
        private Kullanici Kullanici { get;}

        public FormAna(Kullanici aktifKullanici)
        {
            Kullanici = aktifKullanici;
            InitializeComponent();
        }

        void RefreshMusteri()
        {
            var musteriListesi = UnitOfWork.Intance.Musteri.GetAll().Select(x => new {
                ID = x.ID,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Cinsiyeti = x.Cinsiyet,
            }).ToList();
            dgvMusteriListesi.DataSource = musteriListesi;
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            RefreshMusteri();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FormMusteri();
                var cevap = frm.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    UnitOfWork.Intance.Musteri.Add(frm.musteri);
                    MessageBox.Show("Müşteri Kaydı Başarılı");
                    RefreshMusteri();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var secilenID = (int)dgvMusteriListesi.SelectedRows[0].Cells["ID"].Value;
                var secilenMusteri = UnitOfWork.Intance.Musteri.Get(secilenID);
                var frm = new FormMusteri(secilenMusteri);
                var cevap = frm.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    UnitOfWork.Intance.Musteri.Update(frm.musteri);
                    MessageBox.Show("Müşteri Düzenleme Başarılı");
                    RefreshMusteri();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var secilenID = (int)dgvMusteriListesi.SelectedRows[0].Cells["ID"].Value;
                var cevap = MessageBox.Show("Silmek istediginize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(cevap == DialogResult.Yes)
                {
                    UnitOfWork.Intance.Musteri.Remove(secilenID);
                    MessageBox.Show("Müşteri Silme Başarılı");
                    RefreshMusteri();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
