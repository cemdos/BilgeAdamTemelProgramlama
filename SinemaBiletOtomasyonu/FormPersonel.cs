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
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
            dgvFilm.DataSource = Database.Instance.Filmler;
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormFilm();
            var cevap = frm.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                dgvFilm.DataSource = null;
                dgvFilm.DataSource = Database.Instance.Filmler;
            }
        }
    }
}
