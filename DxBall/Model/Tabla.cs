using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DxBall.Model
{
    public class Tabla:PictureBox
    {
        private Form BulunduguForm { get; }

        public int Konum
        {
            get { return this.Location.X; }
            set {
                int xkonumu = value;
                if (xkonumu - this.Size.Width / 2 < 0)
                    this.Location = new Point(0, this.Location.Y);
                else if (xkonumu + this.Size.Width / 2 > BulunduguForm.ClientSize.Width)
                    this.Location = new Point(BulunduguForm.ClientSize.Width - this.Size.Width, this.Location.Y);
                else
                    this.Location = new Point(xkonumu - this.Size.Width / 2, this.Location.Y);
            }
        }

        public Tabla(Form aktarilacakForm)
        {
            BulunduguForm = aktarilacakForm;
            this.Anchor = AnchorStyles.Bottom;
            this.BackColor = Color.Black;
            this.Location = new Point(30, 404);
            this.Size = new Size(106, 19);
            this.TabIndex = 0;
            this.TabStop = false;
            this.Name = "Tabla";
            BulunduguForm.Controls.Add(this);
        }
    }
}
