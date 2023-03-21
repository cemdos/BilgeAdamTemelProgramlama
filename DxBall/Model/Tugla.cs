using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DxBall.Model
{
    public class Tugla : Button
    {
        private Form AktarilacakForm { get; }

        public Tugla() { }

        public Tugla(Form aktarilacakForm)
        {
            AktarilacakForm = aktarilacakForm;
        }

        private static Tugla tuglaOlustur()
        {
            Tugla tugla = new Tugla();
            tugla.BackColor = System.Drawing.Color.Red;
            tugla.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            tugla.FlatAppearance.BorderSize = 3;
            tugla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            tugla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            tugla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tugla.Location = new System.Drawing.Point(12, 12);
            tugla.Size = new System.Drawing.Size(60, 20);
            tugla.Name = "Tugla";
            tugla.TabIndex = 0;
            tugla.UseVisualStyleBackColor = false;
            return tugla;
        }



        public static List<Tugla> TuglaGetir(int tuglaSayisi, Form aktarilacakForm)
        {
            Random rnd = new Random();
            var tuglalar = new List<Tugla>();
            int xKoord = 12;
            int yKoord = 12;
            for (int i = 0; i < tuglaSayisi; i++)
            {
                Tugla yeniTugla = tuglaOlustur();
                yeniTugla.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                if (aktarilacakForm.ClientSize.Width < xKoord + yeniTugla.Width)
                {
                    yKoord += yeniTugla.Height + 2;
                    xKoord = 12;
                }
                yeniTugla.Location = new Point(xKoord, yKoord);
                xKoord += yeniTugla.Width + 2;
                tuglalar.Add(yeniTugla);

            }
            return tuglalar;
        }

    }
}
