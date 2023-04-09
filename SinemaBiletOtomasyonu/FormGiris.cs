using SinemaBiletOtomasyonu.Business;
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
    public partial class FormGiris : Form
    {
        private KullaniciIsLemleri kullaniciServis { get; set; }

        public FormGiris()
        {
            InitializeComponent();
            kullaniciServis = new KullaniciIsLemleri();
#if DEBUG
            txtKullaniciAdi.Text = "cemdos";
            txtSifre.Text = "1234";
#endif
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var aktifKullanici = kullaniciServis.Login(txtKullaniciAdi.Text, txtSifre.Text);
                object frm = new Form();
                switch (aktifKullanici.Rol)
                {
                    case Enum.KullaniciRol.Admin:
                        break;
                    case Enum.KullaniciRol.Personel:
                        frm = new FormPersonel();
                        break;
                    case Enum.KullaniciRol.Musteri:
                        frm = new FormAna(aktifKullanici);
                        break;
                }
                this.Hide();
                ((Form)frm).ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
