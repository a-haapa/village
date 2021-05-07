
namespace village
{
    partial class laskutus
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLaskut = new System.Windows.Forms.DataGridView();
            this.btnMerkitse = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnSulje = new System.Windows.Forms.Button();
            this.dtpAlku = new System.Windows.Forms.DateTimePicker();
            this.dtpLoppu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLaskut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laskutus";
            // 
            // dgvLaskut
            // 
            this.dgvLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaskut.Location = new System.Drawing.Point(13, 106);
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.RowHeadersWidth = 51;
            this.dgvLaskut.RowTemplate.Height = 24;
            this.dgvLaskut.Size = new System.Drawing.Size(849, 466);
            this.dgvLaskut.TabIndex = 1;
            // 
            // btnMerkitse
            // 
            this.btnMerkitse.Location = new System.Drawing.Point(13, 578);
            this.btnMerkitse.Name = "btnMerkitse";
            this.btnMerkitse.Size = new System.Drawing.Size(120, 41);
            this.btnMerkitse.TabIndex = 2;
            this.btnMerkitse.Text = "Maksettu";
            this.btnMerkitse.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(139, 578);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(112, 41);
            this.btnPoista.TabIndex = 3;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(750, 578);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(112, 41);
            this.btnSulje.TabIndex = 4;
            this.btnSulje.Text = "Sulje";
            this.btnSulje.UseVisualStyleBackColor = true;
            // 
            // dtpAlku
            // 
            this.dtpAlku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlku.Location = new System.Drawing.Point(26, 78);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(134, 22);
            this.dtpAlku.TabIndex = 5;
            this.dtpAlku.ValueChanged += new System.EventHandler(this.dtpAlku_ValueChanged);
            // 
            // dtpLoppu
            // 
            this.dtpLoppu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoppu.Location = new System.Drawing.Point(212, 78);
            this.dtpLoppu.Name = "dtpLoppu";
            this.dtpLoppu.Size = new System.Drawing.Size(135, 22);
            this.dtpLoppu.TabIndex = 6;
            this.dtpLoppu.ValueChanged += new System.EventHandler(this.dtpLoppu_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // btnLaskut
            // 
            this.btnLaskut.Location = new System.Drawing.Point(377, 59);
            this.btnLaskut.Name = "btnLaskut";
            this.btnLaskut.Size = new System.Drawing.Size(126, 41);
            this.btnLaskut.TabIndex = 8;
            this.btnLaskut.Text = "Hae laskut";
            this.btnLaskut.UseVisualStyleBackColor = true;
            // 
            // laskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 643);
            this.Controls.Add(this.btnLaskut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpLoppu);
            this.Controls.Add(this.dtpAlku);
            this.Controls.Add(this.btnSulje);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnMerkitse);
            this.Controls.Add(this.dgvLaskut);
            this.Controls.Add(this.label1);
            this.Name = "laskutus";
            this.Text = "laskutus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLaskut;
        private System.Windows.Forms.Button btnMerkitse;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnSulje;
        private System.Windows.Forms.DateTimePicker dtpAlku;
        private System.Windows.Forms.DateTimePicker dtpLoppu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLaskut;
    }
}