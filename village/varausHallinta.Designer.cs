
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLaskutus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaytavaraukset)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNaytavaraukset
            // 
            this.dgvNaytavaraukset.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvNaytavaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaytavaraukset.GridColor = System.Drawing.Color.White;
            this.dgvNaytavaraukset.Location = new System.Drawing.Point(16, 52);
            this.dgvNaytavaraukset.Name = "dgvNaytavaraukset";
            this.dgvNaytavaraukset.RowHeadersWidth = 51;
            this.dgvNaytavaraukset.RowTemplate.Height = 24;
            this.dgvNaytavaraukset.Size = new System.Drawing.Size(958, 463);
            this.dgvNaytavaraukset.TabIndex = 0;
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(903, 595);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(145, 40);
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
            this.btnPoista.Size = new System.Drawing.Size(145, 40);
            this.btnPoista.TabIndex = 4;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(34, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLaskutus
            // 
            this.btnLaskutus.Location = new System.Drawing.Point(167, 520);
            this.btnLaskutus.Name = "btnLaskutus";
            this.btnLaskutus.Size = new System.Drawing.Size(145, 40);
            this.btnLaskutus.TabIndex = 6;
            this.btnLaskutus.Text = "Laskutus";
            this.btnLaskutus.UseVisualStyleBackColor = true;
            this.btnLaskutus.Click += new System.EventHandler(this.btnLaskutus_Click);
            // 
            // varausHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1075, 662);
            this.Controls.Add(this.btnLaskutus);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSulje);
            this.Controls.Add(this.dgvNaytavaraukset);
            this.Name = "varausHallinta";
            this.Text = "varauksenpalvelut";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaytavaraukset)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNaytavaraukset;
        private System.Windows.Forms.Button btnSulje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLaskutus;
    }
}