namespace SinemaBiletOtomasyonu
{
    partial class FormPersonel
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
            this.tabControlIslemler = new System.Windows.Forms.TabControl();
            this.tabPageFilm = new System.Windows.Forms.TabPage();
            this.tabPageSalon = new System.Windows.Forms.TabPage();
            this.tabPageGosterim = new System.Windows.Forms.TabPage();
            this.dgvFilm = new System.Windows.Forms.DataGridView();
            this.contextMenuStripFilm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlIslemler.SuspendLayout();
            this.tabPageFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).BeginInit();
            this.contextMenuStripFilm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlIslemler
            // 
            this.tabControlIslemler.Controls.Add(this.tabPageFilm);
            this.tabControlIslemler.Controls.Add(this.tabPageSalon);
            this.tabControlIslemler.Controls.Add(this.tabPageGosterim);
            this.tabControlIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlIslemler.Location = new System.Drawing.Point(0, 0);
            this.tabControlIslemler.Name = "tabControlIslemler";
            this.tabControlIslemler.SelectedIndex = 0;
            this.tabControlIslemler.Size = new System.Drawing.Size(800, 450);
            this.tabControlIslemler.TabIndex = 0;
            // 
            // tabPageFilm
            // 
            this.tabPageFilm.Controls.Add(this.dgvFilm);
            this.tabPageFilm.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilm.Name = "tabPageFilm";
            this.tabPageFilm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilm.Size = new System.Drawing.Size(792, 424);
            this.tabPageFilm.TabIndex = 0;
            this.tabPageFilm.Text = "FILM";
            this.tabPageFilm.UseVisualStyleBackColor = true;
            // 
            // tabPageSalon
            // 
            this.tabPageSalon.Location = new System.Drawing.Point(4, 22);
            this.tabPageSalon.Name = "tabPageSalon";
            this.tabPageSalon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSalon.Size = new System.Drawing.Size(792, 424);
            this.tabPageSalon.TabIndex = 1;
            this.tabPageSalon.Text = "SALON";
            this.tabPageSalon.UseVisualStyleBackColor = true;
            // 
            // tabPageGosterim
            // 
            this.tabPageGosterim.Location = new System.Drawing.Point(4, 22);
            this.tabPageGosterim.Name = "tabPageGosterim";
            this.tabPageGosterim.Size = new System.Drawing.Size(792, 424);
            this.tabPageGosterim.TabIndex = 2;
            this.tabPageGosterim.Text = "GÖSTERIM";
            this.tabPageGosterim.UseVisualStyleBackColor = true;
            // 
            // dgvFilm
            // 
            this.dgvFilm.AllowUserToAddRows = false;
            this.dgvFilm.AllowUserToDeleteRows = false;
            this.dgvFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilm.ContextMenuStrip = this.contextMenuStripFilm;
            this.dgvFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilm.Location = new System.Drawing.Point(3, 3);
            this.dgvFilm.Name = "dgvFilm";
            this.dgvFilm.ReadOnly = true;
            this.dgvFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilm.Size = new System.Drawing.Size(786, 418);
            this.dgvFilm.TabIndex = 0;
            // 
            // contextMenuStripFilm
            // 
            this.contextMenuStripFilm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStripFilm.Name = "contextMenuStripFilm";
            this.contextMenuStripFilm.Size = new System.Drawing.Size(117, 70);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlIslemler);
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            this.tabControlIslemler.ResumeLayout(false);
            this.tabPageFilm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).EndInit();
            this.contextMenuStripFilm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlIslemler;
        private System.Windows.Forms.TabPage tabPageFilm;
        private System.Windows.Forms.TabPage tabPageSalon;
        private System.Windows.Forms.DataGridView dgvFilm;
        private System.Windows.Forms.TabPage tabPageGosterim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFilm;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}