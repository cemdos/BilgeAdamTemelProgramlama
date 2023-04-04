using SinemaBiletOtomasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletOtomasyonu.FormModel
{
    public class Koltuk:Button
    {
        public KoltukDurum Durumu { get; set; }
        public int KoltukNumarasi { get; set; }

        public Koltuk(int x, int y)
        {
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FlatAppearance.BorderSize = 3;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Location = new System.Drawing.Point(x, y);
            this.Name = "koltuk";
            this.Size = new System.Drawing.Size(40, 40);
            this.UseVisualStyleBackColor = false;
        }
    }
}
