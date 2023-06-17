namespace StokTakip.UI.WinForm.AltFormlar
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
            this.tabMusteri = new System.Windows.Forms.TabPage();
            this.dgvMusteriListesi = new System.Windows.Forms.DataGridView();
            this.cmsMusteri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabUrun = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListesi)).BeginInit();
            this.cmsMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMusteri);
            this.tabControl1.Controls.Add(this.tabUrun);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMusteri
            // 
            this.tabMusteri.Controls.Add(this.dgvMusteriListesi);
            this.tabMusteri.Location = new System.Drawing.Point(4, 24);
            this.tabMusteri.Name = "tabMusteri";
            this.tabMusteri.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusteri.Size = new System.Drawing.Size(957, 549);
            this.tabMusteri.TabIndex = 0;
            this.tabMusteri.Text = "Müşteri Listesi";
            this.tabMusteri.UseVisualStyleBackColor = true;
            // 
            // dgvMusteriListesi
            // 
            this.dgvMusteriListesi.AllowUserToAddRows = false;
            this.dgvMusteriListesi.AllowUserToDeleteRows = false;
            this.dgvMusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriListesi.ContextMenuStrip = this.cmsMusteri;
            this.dgvMusteriListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteriListesi.Location = new System.Drawing.Point(3, 3);
            this.dgvMusteriListesi.MultiSelect = false;
            this.dgvMusteriListesi.Name = "dgvMusteriListesi";
            this.dgvMusteriListesi.ReadOnly = true;
            this.dgvMusteriListesi.RowTemplate.Height = 25;
            this.dgvMusteriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriListesi.Size = new System.Drawing.Size(951, 543);
            this.dgvMusteriListesi.TabIndex = 0;
            // 
            // cmsMusteri
            // 
            this.cmsMusteri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.cmsMusteri.Name = "cmsMusteri";
            this.cmsMusteri.Size = new System.Drawing.Size(181, 92);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tabUrun
            // 
            this.tabUrun.Location = new System.Drawing.Point(4, 24);
            this.tabUrun.Name = "tabUrun";
            this.tabUrun.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrun.Size = new System.Drawing.Size(957, 549);
            this.tabUrun.TabIndex = 1;
            this.tabUrun.Text = "Ürün Listesi";
            this.tabUrun.UseVisualStyleBackColor = true;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAna";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMusteri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListesi)).EndInit();
            this.cmsMusteri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabMusteri;
        private DataGridView dgvMusteriListesi;
        private TabPage tabUrun;
        private ContextMenuStrip cmsMusteri;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}