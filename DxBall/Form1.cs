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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X - pbTabla.Size.Width / 2 < 0)
            {
                pbTabla.Location = new Point(0, pbTabla.Location.Y);
            }
            else if (e.X + pbTabla.Size.Width / 2 > this.ClientSize.Width)
            {
                pbTabla.Location = new Point(this.ClientSize.Width - pbTabla.Size.Width, pbTabla.Location.Y);
            }
            else
                pbTabla.Location = new Point(e.X - pbTabla.Size.Width / 2, pbTabla.Location.Y);

        }

        private void timerTopHareket_Tick(object sender, EventArgs e)
        {
            if(pbTop.Location.X <= 0)
            {
                pbTop.Location = new Point(pbTop.Location.X + 10, pbTop.Location.Y);
            }
            else
            {
                pbTop.Location = new Point(pbTop.Location.X - 10, pbTop.Location.Y);
            }

        }
    }
}
