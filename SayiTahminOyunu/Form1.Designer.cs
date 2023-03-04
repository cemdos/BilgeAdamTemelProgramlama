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
            this.btnKuponUret.Location = new System.Drawing.Point(111, 11);
            this.btnKuponUret.Name = "btnKuponUret";
            this.btnKuponUret.Size = new System.Drawing.Size(119, 34);
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
            // 
            // nudKuponSayisi
            // 
            this.nudKuponSayisi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudKuponSayisi.Location = new System.Drawing.Point(12, 12);
            this.nudKuponSayisi.Name = "nudKuponSayisi";
            this.nudKuponSayisi.Size = new System.Drawing.Size(93, 33);
            this.nudKuponSayisi.TabIndex = 1;
            // 
            // lbKuponListesi
            // 
            this.lbKuponListesi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKuponListesi.FormattingEnabled = true;
            this.lbKuponListesi.ItemHeight = 14;
            this.lbKuponListesi.Location = new System.Drawing.Point(12, 61);
            this.lbKuponListesi.Name = "lbKuponListesi";
            this.lbKuponListesi.Size = new System.Drawing.Size(218, 368);
            this.lbKuponListesi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKuponListesi);
            this.Controls.Add(this.nudKuponSayisi);
            this.Controls.Add(this.btnKuponUret);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudKuponSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKuponUret;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.NumericUpDown nudKuponSayisi;
        private System.Windows.Forms.ListBox lbKuponListesi;
    }
}

