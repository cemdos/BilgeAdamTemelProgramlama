using StokTakip.BLL;
using StokTakip.UI.WinForm.AltFormlar;

namespace StokTakip.UI.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanici = UnitOfWork.Intance.Kullanici.Login(txtKullaniciAdi.Text, txtSifre.Text);
                if (kullanici == null)
                    throw new Exception("Kullanýcý yada þifre hatalý");

                var frm = new FormAna(kullanici);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}