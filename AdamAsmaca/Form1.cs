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

            this.Text = $"Hoşgeldiniz {Ortak.AktifKullanici.KullaniciAdi}";

            for (int i = 0; i < Butonlar.Length; i++)
            {
                Butonlar[i].Click += HarfMouseTik;
                Butonlar[i].KeyDown += HarfKlavyeKeyDown;
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
            string metin;
            if (kazanildimi)
            {
                Ortak.AktifKullanici.KazandigiOyunSayisi++;
                metin = "Tebrikler Kazandınız";
            }
            else
            {
                Ortak.AktifKullanici.KaybettigiOyunSayisi++;
                metin = "Oyun Bitti Kaybettiniz";
            }

            var cevap = MessageBox.Show($@"{metin}"
                        +$"Aranan Şehir : {AdamAsmacaMetotlari.SecilenSehir}\n"
                        +$"Puan : {Math.Ceiling(Puan)}\n"
                        +$"Devam Etmek ister misiniz?",
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
                this.Close();

        }

        private void HarfKontrol(Button buton, char basilanHarf)
        {
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
                Puan -= 100f / Resimler.Length;

                if (Hak == 0)
                    MesajVer(false);

            }
        }

        private void HarfMouseTik(object sender, EventArgs e)
        {
            var buton = ((Button)sender);
            char basilanHarf = buton.Text[0];
            //char basilanHarf = (char)((KeyEventArgs)e).KeyValue;
            HarfKontrol(buton, basilanHarf);
        }

        private void HarfKlavyeKeyDown(object sender, EventArgs e)
        {
            Button buton = null;
            Dictionary<Keys, char> turkceTuslar = new Dictionary<Keys, char>();
            turkceTuslar.Add(Keys.Oem4, 'Ğ');
            turkceTuslar.Add(Keys.Oem1, 'Ş');

            char basilanHarf = (char)(((KeyEventArgs)e).KeyData);

            if (basilanHarf < 'A' || basilanHarf > 'Z')
            {
                Keys basilanTus = ((KeyEventArgs)e).KeyCode;
                bool cevrildimi = turkceTuslar.TryGetValue(basilanTus, out basilanHarf);
                if (!cevrildimi)
                {
                    return;
                }
            }

            buton = Butonlar.Where(x => x.Text == basilanHarf.ToString()).FirstOrDefault();

            //foreach (var item in Butonlar)
            //{
            //    if (basilanHarf.ToString() == item.Text)
            //    {
            //        buton = item;
            //        break;
            //    }
            //}

            HarfKontrol(buton, basilanHarf);
        }

        private void FormAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            string cevap = MessageBox.Show("Form kapatılsın mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString();
            if (cevap == "No")
                e.Cancel = true;

            Ortak.AktifKullanici.Puan += (uint)Math.Ceiling(Puan) - 100;
        }

        private void tsmiPuanDurumu_Click(object sender, EventArgs e)
        {
            FormPuanDurumu frm = new FormPuanDurumu();
            frm.ShowDialog();
        }
    }
}
