namespace AdamAsmaca
{
    partial class FormAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnasayfa));
            this.lblSecilenSehir = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.durumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPuanDurumu = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSecilenSehir
            // 
            this.lblSecilenSehir.AutoSize = true;
            this.lblSecilenSehir.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenSehir.Location = new System.Drawing.Point(32, 31);
            this.lblSecilenSehir.Name = "lblSecilenSehir";
            this.lblSecilenSehir.Size = new System.Drawing.Size(95, 29);
            this.lblSecilenSehir.TabIndex = 0;
            this.lblSecilenSehir.Text = "label1";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(433, 0);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(367, 450);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 1;
            this.pbResim.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durumToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // durumToolStripMenuItem
            // 
            this.durumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPuanDurumu});
            this.durumToolStripMenuItem.Name = "durumToolStripMenuItem";
            this.durumToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.durumToolStripMenuItem.Text = "Durum";
            // 
            // tsmiPuanDurumu
            // 
            this.tsmiPuanDurumu.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPuanDurumu.Image")));
            this.tsmiPuanDurumu.Name = "tsmiPuanDurumu";
            this.tsmiPuanDurumu.Size = new System.Drawing.Size(180, 22);
            this.tsmiPuanDurumu.Text = "Puan durumu";
            this.tsmiPuanDurumu.Click += new System.EventHandler(this.tsmiPuanDurumu_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.lblSecilenSehir);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAnasayfa";
            this.Text = "Form Adam Asmaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAnasayfa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecilenSehir;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem durumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPuanDurumu;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

