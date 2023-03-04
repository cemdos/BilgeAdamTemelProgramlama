using SayiTahminOyunu.Business;
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

        public object[] KuponListesi { get; set; }

        private void btnKuponUret_Click(object sender, EventArgs e)
        {
            KuponListesi = CekilisIslemleri.KuponUret((int)nudKuponSayisi.Value);
            foreach (byte[] item in KuponListesi)
                lbKuponListesi.Items.Add(CekilisIslemleri.KuponYaz(item));
        }
    }
}
