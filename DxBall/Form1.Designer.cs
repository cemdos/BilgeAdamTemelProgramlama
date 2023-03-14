namespace DxBall
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
            this.pbTabla = new System.Windows.Forms.PictureBox();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.timerTopHareket = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTabla
            // 
            this.pbTabla.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbTabla.BackColor = System.Drawing.Color.Black;
            this.pbTabla.Location = new System.Drawing.Point(30, 404);
            this.pbTabla.Name = "pbTabla";
            this.pbTabla.Size = new System.Drawing.Size(106, 19);
            this.pbTabla.TabIndex = 0;
            this.pbTabla.TabStop = false;
            // 
            // pbTop
            // 
            this.pbTop.Image = ((System.Drawing.Image)(resources.GetObject("pbTop.Image")));
            this.pbTop.Location = new System.Drawing.Point(361, 144);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(20, 20);
            this.pbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTop.TabIndex = 1;
            this.pbTop.TabStop = false;
            // 
            // timerTopHareket
            // 
            this.timerTopHareket.Enabled = true;
            this.timerTopHareket.Interval = 50;
            this.timerTopHareket.Tick += new System.EventHandler(this.timerTopHareket_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbTop);
            this.Controls.Add(this.pbTabla);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTabla;
        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.Timer timerTopHareket;
    }
}

