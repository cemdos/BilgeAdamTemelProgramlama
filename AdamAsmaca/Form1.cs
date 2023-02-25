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
        public FormAnasayfa()
        {
            InitializeComponent();

            AdamAsmacaMetotlari.RastgeleSehirSec();
            var butonlar = AdamAsmacaMetotlari.GetirHarfButonlari();
            for (int i = 0; i < butonlar.Length; i++)
                butonlar[i].Click += HarfeBasildiginda;
            this.Controls.AddRange(butonlar);

            lblSecilenSehir.Text = AdamAsmacaMetotlari.ArayaboslukEkle(AdamAsmacaMetotlari.EkranMetni);
        }

        private void HarfeBasildiginda(object sender, EventArgs e)
        {
            var buton = ((Button)sender);
            char basilanHarf = buton.Text[0];
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
            }
            else
            {
                buton.BackColor = Color.DarkRed;
                buton.ForeColor = Color.White;
            }

        }

    }
}
