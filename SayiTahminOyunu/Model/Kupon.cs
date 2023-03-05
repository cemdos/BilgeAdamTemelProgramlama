using SayiTahminOyunu.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.Model
{
    public class Kupon
    {
        public byte[] Veriler { get; set; }
        public byte KacBildi { get; set; }

        public string KuponString
        {
			get { return KuponYaz(Veriler); }
		}

        public static string KuponYaz(byte[] kupon)
        {
            string data = string.Empty;
            for (int i = 0; i < kupon.Length; i++)
                data += kupon[i].ToString().PadLeft(2, '0') + " ";
            return data;
        }

    }
}
