namespace AdamAsmaca
{
    partial class FormPuanDurumu
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
            this.dgvPuanTablosu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuanTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPuanTablosu
            // 
            this.dgvPuanTablosu.AllowUserToAddRows = false;
            this.dgvPuanTablosu.AllowUserToDeleteRows = false;
            this.dgvPuanTablosu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuanTablosu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPuanTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuanTablosu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPuanTablosu.Location = new System.Drawing.Point(0, 0);
            this.dgvPuanTablosu.MultiSelect = false;
            this.dgvPuanTablosu.Name = "dgvPuanTablosu";
            this.dgvPuanTablosu.ReadOnly = true;
            this.dgvPuanTablosu.RowHeadersVisible = false;
            this.dgvPuanTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuanTablosu.Size = new System.Drawing.Size(626, 331);
            this.dgvPuanTablosu.TabIndex = 0;
            // 
            // FormPuanDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 331);
            this.Controls.Add(this.dgvPuanTablosu);
            this.Name = "FormPuanDurumu";
            this.Text = "FormPuanDurumu";
            this.Load += new System.EventHandler(this.FormPuanDurumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuanTablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPuanTablosu;
    }
}