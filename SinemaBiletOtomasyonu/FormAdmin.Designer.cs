namespace SinemaBiletOtomasyonu
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFilmTuruneGoreMusteriSayisi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmTuruneGoreMusteriSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilmTuruneGoreMusteriSayisi
            // 
            this.dgvFilmTuruneGoreMusteriSayisi.AllowUserToAddRows = false;
            this.dgvFilmTuruneGoreMusteriSayisi.AllowUserToDeleteRows = false;
            this.dgvFilmTuruneGoreMusteriSayisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmTuruneGoreMusteriSayisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilmTuruneGoreMusteriSayisi.Location = new System.Drawing.Point(0, 0);
            this.dgvFilmTuruneGoreMusteriSayisi.Name = "dgvFilmTuruneGoreMusteriSayisi";
            this.dgvFilmTuruneGoreMusteriSayisi.ReadOnly = true;
            this.dgvFilmTuruneGoreMusteriSayisi.Size = new System.Drawing.Size(458, 291);
            this.dgvFilmTuruneGoreMusteriSayisi.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 291);
            this.Controls.Add(this.dgvFilmTuruneGoreMusteriSayisi);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmTuruneGoreMusteriSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilmTuruneGoreMusteriSayisi;
    }
}