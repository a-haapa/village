
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
            this.btnSulje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaytavaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNaytavaraukset
            // 
            this.dgvNaytavaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaytavaraukset.Location = new System.Drawing.Point(16, 52);
            this.dgvNaytavaraukset.Name = "dgvNaytavaraukset";
            this.dgvNaytavaraukset.RowHeadersWidth = 51;
            this.dgvNaytavaraukset.RowTemplate.Height = 24;
            this.dgvNaytavaraukset.Size = new System.Drawing.Size(967, 443);
            this.dgvNaytavaraukset.TabIndex = 0;
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(742, 520);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(157, 40);
            this.btnSulje.TabIndex = 1;
            this.btnSulje.Text = "Sulje";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Varaukset";
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(16, 520);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(153, 40);
            this.btnPoista.TabIndex = 4;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // varausHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 662);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSulje);
            this.Controls.Add(this.dgvNaytavaraukset);
            this.Name = "varausHallinta";
            this.Text = "varauksenpalvelut";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaytavaraukset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNaytavaraukset;
        private System.Windows.Forms.Button btnSulje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPoista;
    }
}