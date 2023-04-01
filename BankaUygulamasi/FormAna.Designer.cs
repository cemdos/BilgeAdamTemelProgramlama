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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHesaplar = new System.Windows.Forms.TabPage();
            this.dgvMusteriHesaplari = new System.Windows.Forms.DataGridView();
            this.lblKarsilama = new System.Windows.Forms.Label();
            this.tabOdemeler = new System.Windows.Forms.TabPage();
            this.btnOdemeGonder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.tabParaTransfer = new System.Windows.Forms.TabPage();
            this.radioEURO = new System.Windows.Forms.RadioButton();
            this.radioUSD = new System.Windows.Forms.RadioButton();
            this.radioTL = new System.Windows.Forms.RadioButton();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProfil = new System.Windows.Forms.TabPage();
            this.cbYasadigiIce = new System.Windows.Forms.ComboBox();
            this.cbYasadigiSehir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabRaporlar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPersonel = new System.Windows.Forms.TabPage();
            this.cbHesapTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHesapEkle = new System.Windows.Forms.Button();
            this.dgvHesaplar = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDgvHesaplar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMusteriKaydet = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabHesaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriHesaplari)).BeginInit();
            this.tabOdemeler.SuspendLayout();
            this.tabParaTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            this.tabProfil.SuspendLayout();
            this.tabRaporlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHesaplar)).BeginInit();
            this.contextMenuStripDgvHesaplar.SuspendLayout();
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
            this.tabOdemeler.Controls.Add(this.btnOdemeGonder);
            this.tabOdemeler.Controls.Add(this.label3);
            this.tabOdemeler.Controls.Add(this.cbOdemeTipi);
            this.tabOdemeler.Location = new System.Drawing.Point(4, 22);
            this.tabOdemeler.Name = "tabOdemeler";
            this.tabOdemeler.Padding = new System.Windows.Forms.Padding(3);
            this.tabOdemeler.Size = new System.Drawing.Size(792, 424);
            this.tabOdemeler.TabIndex = 1;
            this.tabOdemeler.Text = "ÖDEMELER";
            this.tabOdemeler.UseVisualStyleBackColor = true;
            // 
            // btnOdemeGonder
            // 
            this.btnOdemeGonder.Location = new System.Drawing.Point(275, 55);
            this.btnOdemeGonder.Name = "btnOdemeGonder";
            this.btnOdemeGonder.Size = new System.Drawing.Size(75, 23);
            this.btnOdemeGonder.TabIndex = 2;
            this.btnOdemeGonder.Text = "Gönder";
            this.btnOdemeGonder.UseVisualStyleBackColor = true;
            this.btnOdemeGonder.Click += new System.EventHandler(this.btnOdemeGonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ödeme Tipi";
            // 
            // cbOdemeTipi
            // 
            this.cbOdemeTipi.FormattingEnabled = true;
            this.cbOdemeTipi.Location = new System.Drawing.Point(100, 18);
            this.cbOdemeTipi.Name = "cbOdemeTipi";
            this.cbOdemeTipi.Size = new System.Drawing.Size(250, 21);
            this.cbOdemeTipi.TabIndex = 0;
            // 
            // tabParaTransfer
            // 
            this.tabParaTransfer.Controls.Add(this.radioEURO);
            this.tabParaTransfer.Controls.Add(this.radioUSD);
            this.tabParaTransfer.Controls.Add(this.radioTL);
            this.tabParaTransfer.Controls.Add(this.btnGonder);
            this.tabParaTransfer.Controls.Add(this.label2);
            this.tabParaTransfer.Controls.Add(this.nudMiktar);
            this.tabParaTransfer.Controls.Add(this.txtHesapNo);
            this.tabParaTransfer.Controls.Add(this.label1);
            this.tabParaTransfer.Location = new System.Drawing.Point(4, 22);
            this.tabParaTransfer.Name = "tabParaTransfer";
            this.tabParaTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabParaTransfer.Size = new System.Drawing.Size(792, 424);
            this.tabParaTransfer.TabIndex = 2;
            this.tabParaTransfer.Text = "PARA TRANSFERİ";
            this.tabParaTransfer.UseVisualStyleBackColor = true;
            // 
            // radioEURO
            // 
            this.radioEURO.AutoSize = true;
            this.radioEURO.Location = new System.Drawing.Point(250, 76);
            this.radioEURO.Name = "radioEURO";
            this.radioEURO.Size = new System.Drawing.Size(56, 17);
            this.radioEURO.TabIndex = 7;
            this.radioEURO.Text = "EURO";
            this.radioEURO.UseVisualStyleBackColor = true;
            // 
            // radioUSD
            // 
            this.radioUSD.AutoSize = true;
            this.radioUSD.Location = new System.Drawing.Point(196, 76);
            this.radioUSD.Name = "radioUSD";
            this.radioUSD.Size = new System.Drawing.Size(48, 17);
            this.radioUSD.TabIndex = 6;
            this.radioUSD.Text = "USD";
            this.radioUSD.UseVisualStyleBackColor = true;
            // 
            // radioTL
            // 
            this.radioTL.AutoSize = true;
            this.radioTL.Checked = true;
            this.radioTL.Location = new System.Drawing.Point(152, 76);
            this.radioTL.Name = "radioTL";
            this.radioTL.Size = new System.Drawing.Size(38, 17);
            this.radioTL.TabIndex = 5;
            this.radioTL.TabStop = true;
            this.radioTL.Text = "TL";
            this.radioTL.UseVisualStyleBackColor = true;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(419, 76);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miktar";
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(141, 50);
            this.nudMiktar.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(353, 20);
            this.nudMiktar.TabIndex = 2;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(141, 24);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(353, 20);
            this.txtHesapNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Hesap No :";
            // 
            // tabProfil
            // 
            this.tabProfil.Controls.Add(this.btnMusteriKaydet);
            this.tabProfil.Controls.Add(this.txtEmail);
            this.tabProfil.Controls.Add(this.label11);
            this.tabProfil.Controls.Add(this.txtSifre);
            this.tabProfil.Controls.Add(this.label10);
            this.tabProfil.Controls.Add(this.rbErkek);
            this.tabProfil.Controls.Add(this.rbKadin);
            this.tabProfil.Controls.Add(this.label9);
            this.tabProfil.Controls.Add(this.txtSoyad);
            this.tabProfil.Controls.Add(this.label8);
            this.tabProfil.Controls.Add(this.txtAd);
            this.tabProfil.Controls.Add(this.label7);
            this.tabProfil.Controls.Add(this.dgvHesaplar);
            this.tabProfil.Controls.Add(this.btnHesapEkle);
            this.tabProfil.Controls.Add(this.label6);
            this.tabProfil.Controls.Add(this.cbHesapTipi);
            this.tabProfil.Controls.Add(this.cbYasadigiIce);
            this.tabProfil.Controls.Add(this.cbYasadigiSehir);
            this.tabProfil.Controls.Add(this.label5);
            this.tabProfil.Controls.Add(this.label4);
            this.tabProfil.Location = new System.Drawing.Point(4, 22);
            this.tabProfil.Name = "tabProfil";
            this.tabProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfil.Size = new System.Drawing.Size(792, 424);
            this.tabProfil.TabIndex = 3;
            this.tabProfil.Text = "PROFİL AYARLARI";
            this.tabProfil.UseVisualStyleBackColor = true;
            // 
            // cbYasadigiIce
            // 
            this.cbYasadigiIce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYasadigiIce.FormattingEnabled = true;
            this.cbYasadigiIce.Location = new System.Drawing.Point(104, 193);
            this.cbYasadigiIce.Name = "cbYasadigiIce";
            this.cbYasadigiIce.Size = new System.Drawing.Size(198, 21);
            this.cbYasadigiIce.TabIndex = 3;
            // 
            // cbYasadigiSehir
            // 
            this.cbYasadigiSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYasadigiSehir.FormattingEnabled = true;
            this.cbYasadigiSehir.Location = new System.Drawing.Point(104, 165);
            this.cbYasadigiSehir.Name = "cbYasadigiSehir";
            this.cbYasadigiSehir.Size = new System.Drawing.Size(198, 21);
            this.cbYasadigiSehir.TabIndex = 2;
            this.cbYasadigiSehir.SelectedIndexChanged += new System.EventHandler(this.cbYasadigiSehir_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yaşadığı İlçe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yaşadığı İl";
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
            // cbHesapTipi
            // 
            this.cbHesapTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHesapTipi.FormattingEnabled = true;
            this.cbHesapTipi.Location = new System.Drawing.Point(494, 21);
            this.cbHesapTipi.Name = "cbHesapTipi";
            this.cbHesapTipi.Size = new System.Drawing.Size(199, 21);
            this.cbHesapTipi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hesap Tipi";
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.Location = new System.Drawing.Point(699, 21);
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.Size = new System.Drawing.Size(75, 23);
            this.btnHesapEkle.TabIndex = 6;
            this.btnHesapEkle.Text = "Hesap Ekle";
            this.btnHesapEkle.UseVisualStyleBackColor = true;
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // dgvHesaplar
            // 
            this.dgvHesaplar.AllowUserToAddRows = false;
            this.dgvHesaplar.AllowUserToDeleteRows = false;
            this.dgvHesaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHesaplar.ContextMenuStrip = this.contextMenuStripDgvHesaplar;
            this.dgvHesaplar.Location = new System.Drawing.Point(433, 62);
            this.dgvHesaplar.Name = "dgvHesaplar";
            this.dgvHesaplar.ReadOnly = true;
            this.dgvHesaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHesaplar.Size = new System.Drawing.Size(341, 328);
            this.dgvHesaplar.TabIndex = 7;
            // 
            // contextMenuStripDgvHesaplar
            // 
            this.contextMenuStripDgvHesaplar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStripDgvHesaplar.Name = "contextMenuStripDgvHesaplar";
            this.contextMenuStripDgvHesaplar.Size = new System.Drawing.Size(128, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.silToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Adı ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(104, 28);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(198, 20);
            this.txtAd.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(104, 54);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(198, 20);
            this.txtSoyad.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cinsiyet";
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Checked = true;
            this.rbKadin.Location = new System.Drawing.Point(104, 86);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 13;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadin";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(162, 86);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 14;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(104, 109);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(198, 20);
            this.txtSifre.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Şifre";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Mail Adresi";
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.Location = new System.Drawing.Point(227, 229);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriKaydet.TabIndex = 19;
            this.btnMusteriKaydet.Text = "Kaydet";
            this.btnMusteriKaydet.UseVisualStyleBackColor = true;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriHesaplari)).EndInit();
            this.tabOdemeler.ResumeLayout(false);
            this.tabOdemeler.PerformLayout();
            this.tabParaTransfer.ResumeLayout(false);
            this.tabParaTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            this.tabProfil.ResumeLayout(false);
            this.tabProfil.PerformLayout();
            this.tabRaporlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHesaplar)).EndInit();
            this.contextMenuStripDgvHesaplar.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioEURO;
        private System.Windows.Forms.RadioButton radioUSD;
        private System.Windows.Forms.RadioButton radioTL;
        private System.Windows.Forms.Button btnOdemeGonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOdemeTipi;
        private System.Windows.Forms.ComboBox cbYasadigiIce;
        private System.Windows.Forms.ComboBox cbYasadigiSehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHesaplar;
        private System.Windows.Forms.Button btnHesapEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHesapTipi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDgvHesaplar;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnMusteriKaydet;
    }
}