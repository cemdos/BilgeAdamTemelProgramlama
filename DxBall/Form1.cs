using DxBall.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DxBall
{
    public partial class Form1 : Form
    {
        private Tabla tabla { get; set; }
        private Top top { get; set; }
        private List<Tugla> tuglalar { get; set; }

        public Form1()
        {
            InitializeComponent();
            tabla = new Tabla(this);
            tuglalar = Tugla.TuglaGetir(50, this);
            foreach (var tugla in tuglalar)
                this.Controls.Add(tugla);
            top = new Top(this);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            tabla.Konum = e.X;
            //ToDo (Cemdos): Burası nesne icerisine alınacak
        }

    }
}
