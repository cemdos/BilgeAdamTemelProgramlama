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
#if DEBUG
            txtTc.Text = "12345678901";
            txtSifre.Text = "1234";
#endif
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

    #region Konu Anlatımı
    //struct Nokta
    //{
    //    public int x;
    //    public int y;

    //    public Nokta()
    //    {
    //        x = 6;
    //        y = 5;
    //    }

    //    public Nokta Topla(Nokta nokta)
    //    {
    //        Nokta yeniNokta;
    //        yeniNokta.x = x + nokta.x;
    //        yeniNokta.y = y + nokta.y;
    //        return yeniNokta;
    //    }
    //}

    ////sealed class A : Bu sekilde tanımlanırsa sadece nesnesi olusturulabilir kalıtım hicbir sekilde alınamaz
    //abstract class A : //Sadece kalıtım alınabilir nesnesi kesinlikle olusturulamaz
    //{
    //    public abstract int A1 { get; set; }
    //    public virtual void Get()
    //    {
    //        Console.WriteLine("Data cekildi");
    //        Console.WriteLine("Tabloya Yüklendi");
    //    }

    //    public abstract void Yaz();
    //}

    //class b : A
    //{
    //    public override int A1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public override void Get()
    //    {
    //        base.Get();
    //        Console.WriteLine("MErhaba Dünya");
    //    }

    //    public override void Yaz()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public interface IMevzuat
    //{
    //    void Yaz(int a, int b);
    //    string Oku();
    //    string Yaz2(int a, int b);
    //}

    //public class MyClass : IMevzuat
    //{
    //    public string Oku()
    //    {
    //        Console.WriteLine("Oku");
    //        throw new NotImplementedException();
           
    //    }

    //    public void Yaz(int a, int b)
    //    {
    //        Console.WriteLine("Oku2");
    //        throw new NotImplementedException();
    //    }

    //    public string Yaz2(int a, int b)
    //    {
    //        Console.WriteLine("Oku3");
    //        throw new NotImplementedException();
    //    }
    //}

    //public class KurKorumali : IMevzuat
    //{
    //    public string Oku()
    //    {
    //        Console.WriteLine("Ok23235423423");
    //        throw new NotImplementedException();

    //    }

    //    public void Yaz(int a, int b)
    //    {
    //        Console.WriteLine("Oku234234");
    //        throw new NotImplementedException();
    //    }

    //    public string Yaz2(int a, int b)
    //    {
    //        Console.WriteLine("Oku234234");
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion



}
