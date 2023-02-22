using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkFormUygulamam.Komponentlerim
{
    public class Butonum:Button
    {
        public bool BenimOzelligim { get; set; }

        public Butonum()
        {
            BenimOzelligim = true;
            this.BackColor = Color.Green;
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.Size = new Size(200, 100);
            //this.Font = new Font("Arial", 16);
        }
    }
}
