using HS10Lib;
using SinemaBiletOtomasyonu.Model.VirtualModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletOtomasyonu
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            var result = MSSQL.Instance.SelectKomutu<FilmTuruneGoreMusteriSayisi>("exec [dbo].[sp_FilmTuruneGoreMusteriSayisi]");
            if (result.ResponseCode != HS10Lib.Enums.ResponseCodes.Successfull)
                throw new Exception(result.ResponseMessage);
            dgvFilmTuruneGoreMusteriSayisi.DataSource = result.ListModel;
        }
    }
}
