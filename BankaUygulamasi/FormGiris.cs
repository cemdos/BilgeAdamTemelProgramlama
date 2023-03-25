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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var data = KullaniciIslemleri.GirisYap(txtTc.Text, txtSifre.Text);
            if (data == null)
            {
                MessageBox.Show("Kullanıcı Adı yada Şifre yanlış");
                return;
            }

            FormAna frm = new FormAna();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
