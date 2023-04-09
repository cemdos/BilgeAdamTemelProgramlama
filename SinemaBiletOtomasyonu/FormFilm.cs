using SinemaBiletOtomasyonu.Enum;
using SinemaBiletOtomasyonu.Model;
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
    public partial class FormFilm : Form
    {
        public FormFilm()
        {
            InitializeComponent();
        }

        private void FormFilm_Load(object sender, EventArgs e)
        {
            cbTur.DataSource = System.Enum.GetValues(typeof(FilmTuru));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var yeniFilm = new Film();
            yeniFilm.Yonetmen = txtYonetmen.Text;
            yeniFilm.CekilmeYili = (int)nudYi.Value;
            yeniFilm.Adi = txtFilmAdi.Text;
            yeniFilm.Tur = (FilmTuru)cbTur.SelectedItem;
            Database.Instance.Filmler.Add(yeniFilm);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
