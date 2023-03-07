using SayiTahminOyunu.Business;
using SayiTahminOyunu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Kupon> KuponListesi { get; set; }
        public Kupon CekilisSonucu { get; set; }

        private void btnKuponUret_Click(object sender, EventArgs e)
        {
            pbZaman.Maximum = (int)nudKuponSayisi.Value;
            lbKuponListesi.Items.Clear();
            KuponListesi = CekilisIslemleri.KuponUret((int)nudKuponSayisi.Value);
            //foreach (byte[] item in KuponListesi)
            for (int i = 0; i < KuponListesi.Count; i++)
            {
                lbKuponListesi.Items.Add($"{i + 1} - {KuponListesi[i].KuponString}");
                pbZaman.Value = i + 1;
            }

        }

        private void btnCekilisYap_Click(object sender, EventArgs e)
        {
            if (!FormKontrol())
                return;

            CekilisYap();
        }

        string FullTrim(string text)
        {
            while (text.Contains(string.Empty.PadLeft(2, ' ')))
            {
                text = text.Replace(string.Empty.PadLeft(2, ' '), " ");
            }
            return text;
        }

        bool FormKontrol()
        {
            string deger = masktxtSizinKupon.Text.Trim();
            if (string.IsNullOrEmpty(deger))
            {
                MessageBox.Show("Kuponunuz boş geçilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (FullTrim(deger).Count(x => x == ' ') != 5)
            {
                MessageBox.Show("6 Sayı girmeniz gerekmektedir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(KuponListesi == null || KuponListesi.Count == 0)
            {
                MessageBox.Show("Kupon listesi oluşturmadan çekiliş yapılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var sayilar = FullTrim(deger).Split(' ');
            foreach (var item in sayilar)
            {
                if(sayilar.Count(x => x.PadLeft(2,'0') == item.PadLeft(2,'0')) > 1)
                {
                    MessageBox.Show("Kupon içerisinde tekrar eden sayılar mevcut kontrol ediniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }          
            }
            #region 1. Yöntem
            Kupon benimKupon = new Kupon();
            benimKupon.Veriler = sayilar.Select(x => byte.Parse(x)).ToArray();
            Array.Sort(benimKupon.Veriler);
            KuponListesi.Add(benimKupon);
            #endregion
            #region 2. Yöntem
            //KuponListesi.Add(new Kupon()
            //{
            //    Veriler = sayilar.Select(x => byte.Parse(x)).ToArray()
            //});
            #endregion

            return true;
        }

        void CekilisYap()
        {
            pbZaman.Value = 0;
            CekilisSonucu = CekilisIslemleri.KuponUret(1)[0];
            lblCekilisSonucu.Text = "Çekiliş Sonucu\n" + CekilisSonucu.KuponString;
            var cekilisSonucDurum = CekilisIslemleri.CekilisSonucuHesapla(KuponListesi, CekilisSonucu);
            lbl0Bilen.Text = $"0 Bilen Sayısı : {cekilisSonucDurum[0]}";
            lbl1Bilen.Text = $"1 Bilen Sayısı : {cekilisSonucDurum[1]}";
            lbl2Bilen.Text = $"2 Bilen Sayısı : {cekilisSonucDurum[2]}";
            lbl3Bilen.Text = $"3 Bilen Sayısı : {cekilisSonucDurum[3]}";
            lbl4Bilen.Text = $"4 Bilen Sayısı : {cekilisSonucDurum[4]}";
            lbl5Bilen.Text = $"5 Bilen Sayısı : {cekilisSonucDurum[5]}";
            lbl6Bilen.Text = $"6 Bilen Sayısı : {cekilisSonucDurum[6]}";

            GrafigiYukle(cekilisSonucDurum);

            lbKuponListesi.Items.Clear();
            var siraliBilenler = KuponListesi.OrderByDescending(x => x.KacBildi).ToArray();
            for (int i = 0; i < siraliBilenler.Length; i++)
            {
                lbKuponListesi.Items.Add($"{i + 1} - {siraliBilenler[i].KuponString} - {siraliBilenler[i].KacBildi} tane bildi");
                pbZaman.Value = i + 1;
            }

            lblSizinKuponSonuc.Text = $"Sizin Kuponunuzun Sonucu\n{KuponListesi.Last().KacBildi} tane bildiniz";
        }

        void GrafigiYukle(int[] cekilisSonucu)
        {
            chartPie.Series[0].Points.Clear();
            for (int i = 0; i < cekilisSonucu.Length; i++)
                chartPie.Series[0].Points.AddXY(i, cekilisSonucu[i]);
        }
    }
}
