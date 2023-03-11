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
            this.lblSecilenSehir = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
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
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.lblSecilenSehir);
            this.Name = "FormAnasayfa";
            this.Text = "Form Adam Asmaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAnasayfa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecilenSehir;
        private System.Windows.Forms.PictureBox pbResim;
    }
}

