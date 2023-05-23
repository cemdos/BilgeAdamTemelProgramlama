using HS10Lib;
using HS10Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSqlBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection();
                //Eğer Windows Modundan baglanmak istenirse uygulanacak connectionstring
                //baglanti.ConnectionString = "Data Source=DSKTOP-FH3V2M3\\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True";
                //Eğer SQL Server authetication mode olarak baglantı yapılacaksa connecting asagıdaki gibi olmalıdır.
                baglanti.ConnectionString = ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
                Console.WriteLine(baglanti.State);
                baglanti.Open();
                MessageBox.Show("Baglantı Açıldı");
                Console.WriteLine(baglanti.State);
                baglanti.Close();
                MessageBox.Show("Baglantı Kapatıldı.");
                Console.WriteLine(baglanti.State);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Suan Sunucu Mesgul\n" + ex.Message);
            }

        }

        private void btnSqlKayitAt_Click(object sender, EventArgs e)
        {
            #region Passife alındı cunku cok komut var
            //try
            //{
            //    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FH3V2M3\\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=False;User Id=sa;Password=1234;");
            //    SqlCommand komut = new SqlCommand();
            //    komut.Connection = baglanti;
            //    komut.CommandText = "insert into Bolum(Adi) values('Bolum3')";
            //    baglanti.Open();
            //    komut.ExecuteNonQuery();
            //    MessageBox.Show("Kaydedildi");
            //    baglanti.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Kayıt işleminde sorun olustu");
            //}
            #endregion

            var result = MSSQL.Instance.FizikselKomutCalistir("insert int Bolum(Adi) values('Bolum17')");
        }

        private void btnVeriGuncelle_Click(object sender, EventArgs e)
        {
            #region Pasife aloındı cunku cok komut var
            //try
            //{
            //    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FH3V2M3\\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=False;User Id=sa;Password=1234;");
            //    SqlCommand komut = new SqlCommand();
            //    komut.Connection = baglanti;
            //    komut.CommandText = "update Bolum set Adi = 'Bolum10' where ID=6";
            //    baglanti.Open();
            //    komut.ExecuteNonQuery();
            //    MessageBox.Show("Kaydedildi");
            //    baglanti.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Kayıt işleminde sorun olustu");
            //}
            #endregion

            var result = MSSQL.Instance.FizikselKomutCalistir("update Bolum set Adi = 'Bolum10' where ID = 6");
        }

        private void btnVeriSil_Click(object sender, EventArgs e)
        {
            #region Pasife aloındı cunku cok komut var
            //try
            //{
            //    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FH3V2M3\\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=False;User Id=sa;Password=1234;");
            //    SqlCommand komut = new SqlCommand();
            //    komut.Connection = baglanti;
            //    komut.CommandText = "delete from Bolum where ID=8 and ISNULL(Deleted,0)=0";
            //    baglanti.Open();
            //    int etkilenenSatir = komut.ExecuteNonQuery();
            //    if (etkilenenSatir > 0)
            //        MessageBox.Show("Kaydedildi");
            //    else
            //        MessageBox.Show("Degistirilecek kayıt bulunamadı");
            //    baglanti.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Kayıt işleminde sorun olustu");
            //}
            #endregion
            var result = MSSQL.Instance.FizikselKomutCalistir("delete from Bolum where ID=5 and ISNULL(Deleted,0)=0");
        }

        private void btnVeriCek_Click(object sender, EventArgs e)
        {
            #region Pasife aloındı cunku cok komut var
            //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FH3V2M3\\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=False;User Id=sa;Password=1234;");
            //string sorgu = "select Adi from Bolum where ISNULL(Deleted,0)=0";
            //SqlDataAdapter adaptor = new SqlDataAdapter(sorgu, baglanti);
            //DataTable tablo = new DataTable();
            //adaptor.Fill(tablo);
            //dgvVeriListesi.DataSource = tablo;
            #endregion

            var result = MSSQL.Instance.SelectKomutu<Bolum>("select Adi,ID from Bolum where ISNULL(Deleted,0)=0");
            dgvVeriListesi.DataSource = result.ListModel;
        }
    }
}
