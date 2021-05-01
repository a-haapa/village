
namespace village
{
    partial class varausHallinta
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
            this.dgvNaytavaraukset = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaytavaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNaytavaraukset
            // 
            this.dgvNaytavaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaytavaraukset.Location = new System.Drawing.Point(320, 19);
            this.dgvNaytavaraukset.Name = "dgvNaytavaraukset";
            this.dgvNaytavaraukset.RowHeadersWidth = 51;
            this.dgvNaytavaraukset.RowTemplate.Height = 24;
            this.dgvNaytavaraukset.Size = new System.Drawing.Size(522, 492);
            this.dgvNaytavaraukset.TabIndex = 0;
            // 
            // varausHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 523);
            this.Controls.Add(this.dgvNaytavaraukset);
            this.Name = "varausHallinta";
            this.Text = "varauksenpalvelut";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaytavaraukset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNaytavaraukset;
    }
}