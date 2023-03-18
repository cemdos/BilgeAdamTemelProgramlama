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

        public Form1()
        {
            InitializeComponent();
            tabla = new Tabla(this);
            top = new Top(this);


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            tabla.Konum = e.X;
            //ToDo (Cemdos): Burası nesne icerisine alınacak
        }

    }
}
