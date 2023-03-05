namespace SayiTahminOyunu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKuponUret = new System.Windows.Forms.Button();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.nudKuponSayisi = new System.Windows.Forms.NumericUpDown();
            this.lbKuponListesi = new System.Windows.Forms.ListBox();
            this.pbZaman = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.masktxtSizinKupon = new System.Windows.Forms.MaskedTextBox();
            this.btnCekilisYap = new System.Windows.Forms.Button();
            this.lbl6Bilen = new System.Windows.Forms.Label();
            this.lbl5Bilen = new System.Windows.Forms.Label();
            this.lbl3Bilen = new System.Windows.Forms.Label();
            this.lbl4Bilen = new System.Windows.Forms.Label();
            this.lbl1Bilen = new System.Windows.Forms.Label();
            this.lbl2Bilen = new System.Windows.Forms.Label();
            this.lbl0Bilen = new System.Windows.Forms.Label();
            this.lblCekilisSonucu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKuponSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKuponUret
            // 
            this.btnKuponUret.BackColor = System.Drawing.SystemColors.Control;
            this.btnKuponUret.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKuponUret.FlatAppearance.BorderSize = 2;
            this.btnKuponUret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKuponUret.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKuponUret.ForeColor = System.Drawing.Color.Black;
            this.btnKuponUret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKuponUret.ImageIndex = 0;
            this.btnKuponUret.ImageList = this.imageListIcons;
            this.btnKuponUret.Location = new System.Drawing.Point(145, 13);
            this.btnKuponUret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKuponUret.Name = "btnKuponUret";
            this.btnKuponUret.Size = new System.Drawing.Size(123, 37);
            this.btnKuponUret.TabIndex = 0;
            this.btnKuponUret.Text = "Kupon Üret";
            this.btnKuponUret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKuponUret.UseVisualStyleBackColor = false;
            this.btnKuponUret.Click += new System.EventHandler(this.btnKuponUret_Click);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "generate.png");
            this.imageListIcons.Images.SetKeyName(1, "repeat.png");
            // 
            // nudKuponSayisi
            // 
            this.nudKuponSayisi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudKuponSayisi.Location = new System.Drawing.Point(13, 14);
            this.nudKuponSayisi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudKuponSayisi.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudKuponSayisi.Name = "nudKuponSayisi";
            this.nudKuponSayisi.Size = new System.Drawing.Size(124, 33);
            this.nudKuponSayisi.TabIndex = 1;
            // 
            // lbKuponListesi
            // 
            this.lbKuponListesi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKuponListesi.FormattingEnabled = true;
            this.lbKuponListesi.ItemHeight = 14;
            this.lbKuponListesi.Location = new System.Drawing.Point(13, 67);
            this.lbKuponListesi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbKuponListesi.Name = "lbKuponListesi";
            this.lbKuponListesi.Size = new System.Drawing.Size(255, 368);
            this.lbKuponListesi.TabIndex = 2;
            // 
            // pbZaman
            // 
            this.pbZaman.Location = new System.Drawing.Point(13, 432);
            this.pbZaman.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbZaman.Name = "pbZaman";
            this.pbZaman.Size = new System.Drawing.Size(255, 25);
            this.pbZaman.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(291, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sizin Kuponunuz";
            // 
            // masktxtSizinKupon
            // 
            this.masktxtSizinKupon.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masktxtSizinKupon.Location = new System.Drawing.Point(295, 28);
            this.masktxtSizinKupon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.masktxtSizinKupon.Mask = "00 00 00 00 00 00";
            this.masktxtSizinKupon.Name = "masktxtSizinKupon";
            this.masktxtSizinKupon.Size = new System.Drawing.Size(265, 22);
            this.masktxtSizinKupon.TabIndex = 5;
            // 
            // btnCekilisYap
            // 
            this.btnCekilisYap.BackColor = System.Drawing.SystemColors.Control;
            this.btnCekilisYap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCekilisYap.FlatAppearance.BorderSize = 2;
            this.btnCekilisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCekilisYap.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCekilisYap.ForeColor = System.Drawing.Color.Black;
            this.btnCekilisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCekilisYap.ImageIndex = 1;
            this.btnCekilisYap.ImageList = this.imageListIcons;
            this.btnCekilisYap.Location = new System.Drawing.Point(603, 13);
            this.btnCekilisYap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCekilisYap.Name = "btnCekilisYap";
            this.btnCekilisYap.Size = new System.Drawing.Size(130, 37);
            this.btnCekilisYap.TabIndex = 6;
            this.btnCekilisYap.Text = "Çekiliş Yap";
            this.btnCekilisYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCekilisYap.UseVisualStyleBackColor = false;
            this.btnCekilisYap.Click += new System.EventHandler(this.btnCekilisYap_Click);
            // 
            // lbl6Bilen
            // 
            this.lbl6Bilen.AutoSize = true;
            this.lbl6Bilen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl6Bilen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl6Bilen.Location = new System.Drawing.Point(291, 259);
            this.lbl6Bilen.Name = "lbl6Bilen";
            this.lbl6Bilen.Size = new System.Drawing.Size(119, 14);
            this.lbl6Bilen.TabIndex = 7;
            this.lbl6Bilen.Text = "6 Bilen Sayısı : 0";
            // 
            // lbl5Bilen
            // 
            this.lbl5Bilen.AutoSize = true;
            this.lbl5Bilen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl5Bilen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl5Bilen.Location = new System.Drawing.Point(291, 227);
            this.lbl5Bilen.Name = "lbl5Bilen";
            this.lbl5Bilen.Size = new System.Drawing.Size(119, 14);
            this.lbl5Bilen.TabIndex = 8;
            this.lbl5Bilen.Text = "5 Bilen Sayısı : 0";
            // 
            // lbl3Bilen
            // 
            this.lbl3Bilen.AutoSize = true;
            this.lbl3Bilen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3Bilen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl3Bilen.Location = new System.Drawing.Point(291, 163);
            this.lbl3Bilen.Name = "lbl3Bilen";
            this.lbl3Bilen.Size = new System.Drawing.Size(119, 14);
            this.lbl3Bilen.TabIndex = 10;
            this.lbl3Bilen.Text = "3 Bilen Sayısı : 0";
            // 
            // lbl4Bilen
            // 
            this.lbl4Bilen.AutoSize = true;
            this.lbl4Bilen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl4Bilen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl4Bilen.Location = new System.Drawing.Point(291, 195);
            this.lbl4Bilen.Name = "lbl4Bilen";
            this.lbl4Bilen.Size = new System.Drawing.Size(119, 14);
            this.lbl4Bilen.TabIndex = 9;
            this.lbl4Bilen.Text = "4 Bilen Sayısı : 0";
            // 
            // lbl1Bilen
            // 
            this.lbl1Bilen.AutoSize = true;
            this.lbl1Bilen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1Bilen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl1Bilen.Location = new System.Drawing.Point(291, 99);
            this.lbl1Bilen.Name = "lbl1Bilen";
            this.lbl1Bilen.Size = new System.Drawing.Size(119, 14);
            this.lbl1Bilen.TabIndex = 12;
            this.lbl1Bilen.Text = "1 Bilen Sayısı : 0";
            // 
            // lbl2Bilen
            // 
            this.lbl2Bilen.AutoSize = true;
            this.lbl2Bilen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2Bilen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl2Bilen.Location = new System.Drawing.Point(291, 131);
            this.lbl2Bilen.Name = "lbl2Bilen";
            this.lbl2Bilen.Size = new System.Drawing.Size(119, 14);
            this.lbl2Bilen.TabIndex = 11;
            this.lbl2Bilen.Text = "2 Bilen Sayısı : 0";
            // 
            // lbl0Bilen
            // 
            this.lbl0Bilen.AutoSize = true;
            this.lbl0Bilen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl0Bilen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl0Bilen.Location = new System.Drawing.Point(291, 67);
            this.lbl0Bilen.Name = "lbl0Bilen";
            this.lbl0Bilen.Size = new System.Drawing.Size(119, 14);
            this.lbl0Bilen.TabIndex = 13;
            this.lbl0Bilen.Text = "0 Bilen Sayısı : 0";
            // 
            // lblCekilisSonucu
            // 
            this.lblCekilisSonucu.AutoSize = true;
            this.lblCekilisSonucu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekilisSonucu.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCekilisSonucu.Location = new System.Drawing.Point(598, 58);
            this.lblCekilisSonucu.Name = "lblCekilisSonucu";
            this.lblCekilisSonucu.Size = new System.Drawing.Size(169, 23);
            this.lblCekilisSonucu.TabIndex = 14;
            this.lblCekilisSonucu.Text = "Çekiliş Sonucu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 460);
            this.Controls.Add(this.lblCekilisSonucu);
            this.Controls.Add(this.lbl0Bilen);
            this.Controls.Add(this.lbl1Bilen);
            this.Controls.Add(this.lbl2Bilen);
            this.Controls.Add(this.lbl3Bilen);
            this.Controls.Add(this.lbl4Bilen);
            this.Controls.Add(this.lbl5Bilen);
            this.Controls.Add(this.lbl6Bilen);
            this.Controls.Add(this.btnCekilisYap);
            this.Controls.Add(this.masktxtSizinKupon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbZaman);
            this.Controls.Add(this.lbKuponListesi);
            this.Controls.Add(this.nudKuponSayisi);
            this.Controls.Add(this.btnKuponUret);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudKuponSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKuponUret;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.NumericUpDown nudKuponSayisi;
        private System.Windows.Forms.ListBox lbKuponListesi;
        private System.Windows.Forms.ProgressBar pbZaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox masktxtSizinKupon;
        private System.Windows.Forms.Button btnCekilisYap;
        private System.Windows.Forms.Label lbl6Bilen;
        private System.Windows.Forms.Label lbl5Bilen;
        private System.Windows.Forms.Label lbl3Bilen;
        private System.Windows.Forms.Label lbl4Bilen;
        private System.Windows.Forms.Label lbl1Bilen;
        private System.Windows.Forms.Label lbl2Bilen;
        private System.Windows.Forms.Label lbl0Bilen;
        private System.Windows.Forms.Label lblCekilisSonucu;
    }
}

