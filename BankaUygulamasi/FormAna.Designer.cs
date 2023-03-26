namespace BankaUygulamasi
{
    partial class FormAna
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHesaplar = new System.Windows.Forms.TabPage();
            this.lblKarsilama = new System.Windows.Forms.Label();
            this.tabOdemeler = new System.Windows.Forms.TabPage();
            this.tabParaTransfer = new System.Windows.Forms.TabPage();
            this.tabProfil = new System.Windows.Forms.TabPage();
            this.tabRaporlar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPersonel = new System.Windows.Forms.TabPage();
            this.dgvMusteriHesaplari = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabHesaplar.SuspendLayout();
            this.tabRaporlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriHesaplari)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHesaplar);
            this.tabControl1.Controls.Add(this.tabOdemeler);
            this.tabControl1.Controls.Add(this.tabParaTransfer);
            this.tabControl1.Controls.Add(this.tabProfil);
            this.tabControl1.Controls.Add(this.tabRaporlar);
            this.tabControl1.Controls.Add(this.tabPersonel);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHesaplar
            // 
            this.tabHesaplar.Controls.Add(this.dgvMusteriHesaplari);
            this.tabHesaplar.Controls.Add(this.lblKarsilama);
            this.tabHesaplar.Location = new System.Drawing.Point(4, 22);
            this.tabHesaplar.Name = "tabHesaplar";
            this.tabHesaplar.Padding = new System.Windows.Forms.Padding(3);
            this.tabHesaplar.Size = new System.Drawing.Size(792, 424);
            this.tabHesaplar.TabIndex = 0;
            this.tabHesaplar.Text = "HESAPLAR";
            this.tabHesaplar.UseVisualStyleBackColor = true;
            // 
            // lblKarsilama
            // 
            this.lblKarsilama.AutoSize = true;
            this.lblKarsilama.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarsilama.Location = new System.Drawing.Point(154, 19);
            this.lblKarsilama.Name = "lblKarsilama";
            this.lblKarsilama.Size = new System.Drawing.Size(137, 42);
            this.lblKarsilama.TabIndex = 0;
            this.lblKarsilama.Text = "label1";
            // 
            // tabOdemeler
            // 
            this.tabOdemeler.Location = new System.Drawing.Point(4, 22);
            this.tabOdemeler.Name = "tabOdemeler";
            this.tabOdemeler.Padding = new System.Windows.Forms.Padding(3);
            this.tabOdemeler.Size = new System.Drawing.Size(792, 424);
            this.tabOdemeler.TabIndex = 1;
            this.tabOdemeler.Text = "ÖDEMELER";
            this.tabOdemeler.UseVisualStyleBackColor = true;
            // 
            // tabParaTransfer
            // 
            this.tabParaTransfer.Location = new System.Drawing.Point(4, 22);
            this.tabParaTransfer.Name = "tabParaTransfer";
            this.tabParaTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabParaTransfer.Size = new System.Drawing.Size(792, 424);
            this.tabParaTransfer.TabIndex = 2;
            this.tabParaTransfer.Text = "PARA TRANSFERİ";
            this.tabParaTransfer.UseVisualStyleBackColor = true;
            // 
            // tabProfil
            // 
            this.tabProfil.Location = new System.Drawing.Point(4, 22);
            this.tabProfil.Name = "tabProfil";
            this.tabProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfil.Size = new System.Drawing.Size(792, 424);
            this.tabProfil.TabIndex = 3;
            this.tabProfil.Text = "PROFİL AYARLARI";
            this.tabProfil.UseVisualStyleBackColor = true;
            // 
            // tabRaporlar
            // 
            this.tabRaporlar.Controls.Add(this.button1);
            this.tabRaporlar.Location = new System.Drawing.Point(4, 22);
            this.tabRaporlar.Name = "tabRaporlar";
            this.tabRaporlar.Size = new System.Drawing.Size(792, 424);
            this.tabRaporlar.TabIndex = 4;
            this.tabRaporlar.Text = "RAPORLAR";
            this.tabRaporlar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPersonel
            // 
            this.tabPersonel.Location = new System.Drawing.Point(4, 22);
            this.tabPersonel.Name = "tabPersonel";
            this.tabPersonel.Size = new System.Drawing.Size(792, 424);
            this.tabPersonel.TabIndex = 5;
            this.tabPersonel.Text = "PERSONEL";
            this.tabPersonel.UseVisualStyleBackColor = true;
            // 
            // dgvMusteriHesaplari
            // 
            this.dgvMusteriHesaplari.AllowUserToAddRows = false;
            this.dgvMusteriHesaplari.AllowUserToDeleteRows = false;
            this.dgvMusteriHesaplari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusteriHesaplari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriHesaplari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMusteriHesaplari.Location = new System.Drawing.Point(3, 93);
            this.dgvMusteriHesaplari.Name = "dgvMusteriHesaplari";
            this.dgvMusteriHesaplari.ReadOnly = true;
            this.dgvMusteriHesaplari.Size = new System.Drawing.Size(786, 328);
            this.dgvMusteriHesaplari.TabIndex = 1;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAna";
            this.Text = "FormAna";
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHesaplar.ResumeLayout(false);
            this.tabHesaplar.PerformLayout();
            this.tabRaporlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriHesaplari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHesaplar;
        private System.Windows.Forms.TabPage tabOdemeler;
        private System.Windows.Forms.TabPage tabParaTransfer;
        private System.Windows.Forms.TabPage tabProfil;
        private System.Windows.Forms.TabPage tabRaporlar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPersonel;
        private System.Windows.Forms.Label lblKarsilama;
        private System.Windows.Forms.DataGridView dgvMusteriHesaplari;
    }
}