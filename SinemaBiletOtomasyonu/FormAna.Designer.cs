namespace SinemaBiletOtomasyonu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilmAdi = new System.Windows.Forms.ComboBox();
            this.cbSalonAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSeans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStripIslemler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.satınAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKalanSure = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timerFilmBaslamaSuresi = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı ";
            // 
            // cbFilmAdi
            // 
            this.cbFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmAdi.FormattingEnabled = true;
            this.cbFilmAdi.Location = new System.Drawing.Point(85, 15);
            this.cbFilmAdi.Name = "cbFilmAdi";
            this.cbFilmAdi.Size = new System.Drawing.Size(299, 21);
            this.cbFilmAdi.TabIndex = 1;
            this.cbFilmAdi.SelectedIndexChanged += new System.EventHandler(this.cbFilmAdi_SelectedIndexChanged);
            // 
            // cbSalonAdi
            // 
            this.cbSalonAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalonAdi.FormattingEnabled = true;
            this.cbSalonAdi.Location = new System.Drawing.Point(85, 68);
            this.cbSalonAdi.Name = "cbSalonAdi";
            this.cbSalonAdi.Size = new System.Drawing.Size(299, 21);
            this.cbSalonAdi.TabIndex = 3;
            this.cbSalonAdi.SelectedIndexChanged += new System.EventHandler(this.cbSalonAdi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salon Adı";
            // 
            // cbSeans
            // 
            this.cbSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeans.FormattingEnabled = true;
            this.cbSeans.Location = new System.Drawing.Point(85, 93);
            this.cbSeans.Name = "cbSeans";
            this.cbSeans.Size = new System.Drawing.Size(299, 21);
            this.cbSeans.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seans";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(85, 42);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(299, 20);
            this.dtpTarih.TabIndex = 6;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.cbFilmAdi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Koltuk Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStripIslemler
            // 
            this.contextMenuStripIslemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satınAlToolStripMenuItem,
            this.rezerveEtToolStripMenuItem});
            this.contextMenuStripIslemler.Name = "contextMenuStripIslemler";
            this.contextMenuStripIslemler.Size = new System.Drawing.Size(128, 48);
            // 
            // satınAlToolStripMenuItem
            // 
            this.satınAlToolStripMenuItem.Name = "satınAlToolStripMenuItem";
            this.satınAlToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.satınAlToolStripMenuItem.Text = "Satın Al";
            this.satınAlToolStripMenuItem.Click += new System.EventHandler(this.satınAlToolStripMenuItem_Click);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.rezerveEtToolStripMenuItem.Text = "Rezerve Et";
            this.rezerveEtToolStripMenuItem.Click += new System.EventHandler(this.rezerveEtToolStripMenuItem_Click);
            // 
            // btnKalanSure
            // 
            this.btnKalanSure.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKalanSure.FlatAppearance.BorderSize = 5;
            this.btnKalanSure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalanSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKalanSure.Location = new System.Drawing.Point(461, 12);
            this.btnKalanSure.Name = "btnKalanSure";
            this.btnKalanSure.Size = new System.Drawing.Size(222, 77);
            this.btnKalanSure.TabIndex = 11;
            this.btnKalanSure.Text = "0";
            this.btnKalanSure.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Filmin Başlamasına Kalan Süre";
            // 
            // timerFilmBaslamaSuresi
            // 
            this.timerFilmBaslamaSuresi.Interval = 1000;
            this.timerFilmBaslamaSuresi.Tick += new System.EventHandler(this.timerFilmBaslamaSuresi_Tick);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKalanSure);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cbSeans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSalonAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilmAdi);
            this.Controls.Add(this.label1);
            this.Name = "FormAna";
            this.Text = "FormAna";
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.contextMenuStripIslemler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilmAdi;
        private System.Windows.Forms.ComboBox cbSalonAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSeans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIslemler;
        private System.Windows.Forms.ToolStripMenuItem satınAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
        private System.Windows.Forms.Button btnKalanSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerFilmBaslamaSuresi;
    }
}