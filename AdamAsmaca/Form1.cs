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
    public partial class FormAnasayfa : Form
    {
        public Bitmap[] Resimler { get; }
        public int Hak { get; set; } = 7;
        public Button[] Butonlar { get; } = AdamAsmacaMetotlari.GetirHarfButonlari();
        public float Puan { get; set; } = 100;

        public FormAnasayfa()
        {
            InitializeComponent();

            for (int i = 0; i < Butonlar.Length; i++)
            {
                Butonlar[i].Click += HarfeBasildiginda;
                Butonlar[i].KeyDown += HarfeBasildiginda;
            }


            this.Controls.AddRange(Butonlar);

            YeniOyun();
            Resimler = new Bitmap[]
            {
                Properties.Resources._7,
                Properties.Resources._6, Properties.Resources._5,
                Properties.Resources._4, Properties.Resources._3,
                Properties.Resources._2, Properties.Resources._1,
            };
        }

        void YeniOyun()
        {
            AdamAsmacaMetotlari.RastgeleSehirSec();
            for (int i = 0; i < Butonlar.Length; i++)
            {
                Butonlar[i].BackColor = Color.White;
                Butonlar[i].ForeColor = Color.Black;
                Butonlar[i].Enabled = true;
            }

            lblSecilenSehir.Text = AdamAsmacaMetotlari.ArayaboslukEkle(AdamAsmacaMetotlari.EkranMetni);
            pbResim.Image = null;
            Hak = 7;
        }

        void MesajVer(bool kazanildimi)
        {
            string metin = kazanildimi ? "Tebrikler Kazandınız" : "Oyun Bitti Kaybettiniz";
            var cevap = MessageBox.Show($@"{metin} 
Aranan Şehir : {AdamAsmacaMetotlari.SecilenSehir}
Puan : {Math.Ceiling(Puan)} 
Devam Etmek ister misiniz?",
                        "Oyun Durumu",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1
                        );
            if (cevap == DialogResult.Yes)
            {
                Puan += 100; 
                YeniOyun();
            }
            else
                Application.Exit();
        }

        private void HarfeBasildiginda(object sender, EventArgs e)
        {
            var buton = ((Button)sender);
            //char basilanHarf = buton.Text[0];
            char basilanHarf = (char)((KeyEventArgs)e).KeyValue;

            string secilenSehir = AdamAsmacaMetotlari.SecilenSehir;
            string ekranMetni = AdamAsmacaMetotlari.EkranMetni;

            buton.Enabled = false;

            if (secilenSehir.Contains(basilanHarf.ToString()))
            {
                var dizi = secilenSehir.ToCharArray();
                var diziEkran = ekranMetni.ToCharArray();
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (dizi[i] == basilanHarf)
                        diziEkran[i] = basilanHarf;
                }
                AdamAsmacaMetotlari.EkranMetni = new string(diziEkran);
                lblSecilenSehir.Text = AdamAsmacaMetotlari.ArayaboslukEkle(new string(diziEkran));

                buton.BackColor = Color.DarkGreen;
                buton.ForeColor = Color.White;

                if (!AdamAsmacaMetotlari.EkranMetni.Contains("_") && Hak > 0)
                    MesajVer(true);
            }
            else
            {
                buton.BackColor = Color.DarkRed;
                buton.ForeColor = Color.White;
                Hak--;
                pbResim.Image = Resimler[Hak];
                Puan -= 100f/Resimler.Length;

                if (Hak == 0)
                    MesajVer(false);

            }
        }
    }
}
