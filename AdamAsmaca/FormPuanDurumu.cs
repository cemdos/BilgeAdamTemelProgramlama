using AdamAsmaca.Isler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class FormPuanDurumu : Form
    {
        public FormPuanDurumu()
        {
            InitializeComponent();
        }

        private void FormPuanDurumu_Load(object sender, EventArgs e)
        {
            dgvPuanTablosu.Columns.Add("Sira", "Sıra");
            dgvPuanTablosu.DataSource = Ortak.Kullanicilar.OrderByDescending(x => x.Puan)
                                                          .ThenByDescending(x => x.KazandigiOyunSayisi)
                                                          .ThenBy(x => x.KaybettigiOyunSayisi).ToList();
            for (int i = 0; i < dgvPuanTablosu.Rows.Count; i++)
                dgvPuanTablosu.Rows[i].Cells[0].Value = i +1;
            dgvPuanTablosu.Columns[2].Visible = false;
        }
    }
}
