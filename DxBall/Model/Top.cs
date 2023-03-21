using DxBall.Enum;
using DxBall.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DxBall.Model
{
    public class Top : PictureBox
    {
        private Form AktarilacakForm { get; }
        private Tabla tabla { get; }
        private List<Tugla> tuglalar { get; }
        private Timer timerSolSag { get; }
        private Timer timerAsagiYukari { get; }

        public int Hiz { get; set; } = 50;
        public Yon SolSagYonu { get; set; } = Yon.Sol;
        public Yon AsagiYukariYonu { get; set; } = Yon.Yukari;

        public int AtlamaDegeri { get; set; } = 10;

        public Top(Form aktarilacakForm)
        {
            AktarilacakForm = aktarilacakForm;
            tabla = (Tabla)AktarilacakForm.Controls.Find("Tabla", true).FirstOrDefault();
            tuglalar = aktarilacakForm.Controls.Find("Tugla", true).ToList().Select(x => (Tugla)x).ToList();
                
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
            this.Name = "Top";
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

        private bool tablayaCarptimi()
        {
            if (tabla.Bounds.IntersectsWith(this.Bounds))
                return true;
            return false;
        }

        private bool tuglayaCartiMi()
        {
            foreach (var tugla in tuglalar)
            {
                if (tugla.Bounds.IntersectsWith(this.Bounds))
                {
                    AktarilacakForm.Controls.Remove(tugla);
                    return true;
                }
            }
            return false;
        }

        private (bool xIcin, bool yIcin) SiniraUlastiMi()
        {
            if (this.Location.X <= 0) //Sol Duvara carptıysa true dön
                return (true, false);
            else if (this.Location.X >= (AktarilacakForm.ClientSize.Width - this.Size.Width)) //Sag Duvara Carptıysa true dön
                return (true, false);

            if (this.Location.Y <= 0) //Üst duvara carptıysa true dön 
                return (false, true);
            else if (this.Location.Y >= (AktarilacakForm.ClientSize.Height - this.Size.Height))//Alt duvara carptıysa true dön 
                return (false, true);

            return (false, false);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (AsagiYukariYonu)
            {
                case Yon.Yukari:
                    this.Location = new Point(this.Location.X, this.Location.Y - AtlamaDegeri);
                    if (SiniraUlastiMi().yIcin || tuglayaCartiMi())
                        AsagiYukariYonu = Yon.Asagi;
                    break;
                case Yon.Asagi:
                    this.Location = new Point(this.Location.X, this.Location.Y + AtlamaDegeri);
                    if (tablayaCarptimi() || tuglayaCartiMi())
                        AsagiYukariYonu = Yon.Yukari;
                    else if (SiniraUlastiMi().yIcin)
                    {
                        timerAsagiYukari.Enabled = false;
                        timerSolSag.Enabled = false;
                        MessageBox.Show("Oyun Bitti");
                    }
                    break;
                default:
                    this.Location = new Point(this.Location.X, this.Location.Y);
                    break;
            }

            switch (SolSagYonu)
            {
                case Yon.Sag:
                    this.Location = new Point(this.Location.X + AtlamaDegeri, this.Location.Y);
                    if (SiniraUlastiMi().xIcin)
                        SolSagYonu = Yon.Sol;
                    break;
                case Yon.Sol:
                    this.Location = new Point(this.Location.X - AtlamaDegeri, this.Location.Y);
                    if (SiniraUlastiMi().xIcin)
                        SolSagYonu = Yon.Sag;
                    break;
                default:
                    this.Location = new Point(this.Location.X, this.Location.Y);
                    break;
            }
        }
    }
}
