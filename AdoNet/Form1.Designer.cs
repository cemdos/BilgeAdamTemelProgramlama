namespace AdoNet
{
    partial class Form1
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
            this.btnSqlBaglan = new System.Windows.Forms.Button();
            this.btnSqlKayitAt = new System.Windows.Forms.Button();
            this.btnVeriGuncelle = new System.Windows.Forms.Button();
            this.btnVeriSil = new System.Windows.Forms.Button();
            this.btnVeriCek = new System.Windows.Forms.Button();
            this.dgvVeriListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSqlBaglan
            // 
            this.btnSqlBaglan.Location = new System.Drawing.Point(12, 12);
            this.btnSqlBaglan.Name = "btnSqlBaglan";
            this.btnSqlBaglan.Size = new System.Drawing.Size(181, 23);
            this.btnSqlBaglan.TabIndex = 0;
            this.btnSqlBaglan.Text = "Sqle Baglan";
            this.btnSqlBaglan.UseVisualStyleBackColor = true;
            this.btnSqlBaglan.Click += new System.EventHandler(this.btnSqlBaglan_Click);
            // 
            // btnSqlKayitAt
            // 
            this.btnSqlKayitAt.Location = new System.Drawing.Point(12, 41);
            this.btnSqlKayitAt.Name = "btnSqlKayitAt";
            this.btnSqlKayitAt.Size = new System.Drawing.Size(181, 23);
            this.btnSqlKayitAt.TabIndex = 1;
            this.btnSqlKayitAt.Text = "Sql\'e Kayıt At";
            this.btnSqlKayitAt.UseVisualStyleBackColor = true;
            this.btnSqlKayitAt.Click += new System.EventHandler(this.btnSqlKayitAt_Click);
            // 
            // btnVeriGuncelle
            // 
            this.btnVeriGuncelle.Location = new System.Drawing.Point(12, 70);
            this.btnVeriGuncelle.Name = "btnVeriGuncelle";
            this.btnVeriGuncelle.Size = new System.Drawing.Size(181, 23);
            this.btnVeriGuncelle.TabIndex = 2;
            this.btnVeriGuncelle.Text = "Sql Veri Güncelle";
            this.btnVeriGuncelle.UseVisualStyleBackColor = true;
            this.btnVeriGuncelle.Click += new System.EventHandler(this.btnVeriGuncelle_Click);
            // 
            // btnVeriSil
            // 
            this.btnVeriSil.Location = new System.Drawing.Point(12, 100);
            this.btnVeriSil.Name = "btnVeriSil";
            this.btnVeriSil.Size = new System.Drawing.Size(181, 23);
            this.btnVeriSil.TabIndex = 3;
            this.btnVeriSil.Text = "Sql den Veri Sil";
            this.btnVeriSil.UseVisualStyleBackColor = true;
            this.btnVeriSil.Click += new System.EventHandler(this.btnVeriSil_Click);
            // 
            // btnVeriCek
            // 
            this.btnVeriCek.Location = new System.Drawing.Point(12, 129);
            this.btnVeriCek.Name = "btnVeriCek";
            this.btnVeriCek.Size = new System.Drawing.Size(181, 23);
            this.btnVeriCek.TabIndex = 4;
            this.btnVeriCek.Text = "Sql den Veri Cek";
            this.btnVeriCek.UseVisualStyleBackColor = true;
            this.btnVeriCek.Click += new System.EventHandler(this.btnVeriCek_Click);
            // 
            // dgvVeriListesi
            // 
            this.dgvVeriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeriListesi.Location = new System.Drawing.Point(12, 158);
            this.dgvVeriListesi.Name = "dgvVeriListesi";
            this.dgvVeriListesi.Size = new System.Drawing.Size(181, 199);
            this.dgvVeriListesi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 369);
            this.Controls.Add(this.dgvVeriListesi);
            this.Controls.Add(this.btnVeriCek);
            this.Controls.Add(this.btnVeriSil);
            this.Controls.Add(this.btnVeriGuncelle);
            this.Controls.Add(this.btnSqlKayitAt);
            this.Controls.Add(this.btnSqlBaglan);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSqlBaglan;
        private System.Windows.Forms.Button btnSqlKayitAt;
        private System.Windows.Forms.Button btnVeriGuncelle;
        private System.Windows.Forms.Button btnVeriSil;
        private System.Windows.Forms.Button btnVeriCek;
        private System.Windows.Forms.DataGridView dgvVeriListesi;
    }
}

