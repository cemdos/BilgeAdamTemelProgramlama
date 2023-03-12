using AdamAsmaca.Isler;
using AdamAsmaca.Model;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            #if DEBUG
                txtKullaniciAdi.Text = "cemdos";
                txtSifre.Text = "1234";
            #endif
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanici aktifKullanici = Ortak.Kullanicilar.Find(x => x.KullaniciAdi == txtKullaniciAdi.Text &&
                                                                    x.Sifre == txtSifre.Text);
            if (aktifKullanici == null)
            {
                MessageBox.Show("KullanıcıAdı yad şifre hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ortak.AktifKullanici = aktifKullanici;
            FormAnasayfa frm = new FormAnasayfa();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
