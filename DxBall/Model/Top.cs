using DxBall.Enum;
using DxBall.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DxBall.Model
{
    public class Top : PictureBox
    {
        private Form AktarilacakForm { get; }
        private Timer timerSolSag { get; }
        private Timer timerAsagiYukari { get; }

        public int Hiz { get; set; } = 50;
        public Yon SolSagYonu { get; set; } = Yon.Sol;
        public Yon AsagiYukariYonu { get; set; } = Yon.Yukari;

        public int AtlamaDegeri { get; set; } = 10;

        public Top(Form aktarilacakForm)
        {
            AktarilacakForm = aktarilacakForm;
            TopunVarsayilanAyari();
            timerSolSag = new Timer();
            timerAsagiYukari = new Timer();

            timeriAyarla(timerSolSag);
            timeriAyarla(timerAsagiYukari);
        }

        private void TopunVarsayilanAyari()
        {
            this.Image = Properties.Resources.top;
            this.Location = new System.Drawing.Point(361, 144);
            this.Size = new System.Drawing.Size(20, 20);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TabIndex = 1;
            this.TabStop = false;
            AktarilacakForm.Controls.Add(this);
        }

        private void timeriAyarla(Timer timer)
        {
            timer.Interval = Hiz;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
        }

        private bool SiniraUlastiMi()
        {
            if (this.Location.X <= 0)
                return true;
            else if (this.Location.X >= (AktarilacakForm.ClientSize.Width - this.Size.Width))
                return true;
            if (this.Location.Y <= 0)
                return true;
            else if (this.Location.Y >= (AktarilacakForm.ClientSize.Height - this.Size.Height))
                return true;
            return false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (AsagiYukariYonu)
            {
                case Yon.Yukari:
                    this.Location = new Point(this.Location.X, this.Location.Y - AtlamaDegeri);
                    if (SiniraUlastiMi())
                        AsagiYukariYonu = Yon.Asagi;
                    break;
                case Yon.Asagi:
                    this.Location = new Point(this.Location.X, this.Location.Y + AtlamaDegeri);
                    if (SiniraUlastiMi())
                        AsagiYukariYonu = Yon.Yukari;
                    break;
                default:
                    this.Location = new Point(this.Location.X, this.Location.Y);
                    break;
            }

            switch (SolSagYonu)
            {
                case Yon.Sag:
                    this.Location = new Point(this.Location.X + AtlamaDegeri, this.Location.Y);
                    if (SiniraUlastiMi())
                        SolSagYonu = Yon.Sol;
                    break;
                case Yon.Sol:
                    this.Location = new Point(this.Location.X - AtlamaDegeri, this.Location.Y);
                    if (SiniraUlastiMi())
                        SolSagYonu = Yon.Sag;
                    break;
                default:
                    this.Location = new Point(this.Location.X, this.Location.Y);
                    break;
            }
        }
    }
}
