
namespace village
{
    partial class laskut
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
            this.Laskutus = new System.Windows.Forms.Label();
            this.Aikaväli = new System.Windows.Forms.Label();
            this.dtpAlku = new System.Windows.Forms.DateTimePicker();
            this.dtpLoppu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSulje = new System.Windows.Forms.Button();
            this.dgvLaskut = new System.Windows.Forms.DataGridView();
            this.btnPoista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).BeginInit();
            this.SuspendLayout();
            // 
            // Laskutus
            // 
            this.Laskutus.AutoSize = true;
            this.Laskutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laskutus.Location = new System.Drawing.Point(27, 23);
            this.Laskutus.Name = "Laskutus";
            this.Laskutus.Size = new System.Drawing.Size(63, 24);
            this.Laskutus.TabIndex = 0;
            this.Laskutus.Text = "Laskut";
            // 
            // Aikaväli
            // 
            this.Aikaväli.AutoSize = true;
            this.Aikaväli.Location = new System.Drawing.Point(28, 74);
            this.Aikaväli.Name = "Aikaväli";
            this.Aikaväli.Size = new System.Drawing.Size(56, 17);
            this.Aikaväli.TabIndex = 1;
            this.Aikaväli.Text = "Aikaväli";
            // 
            // dtpAlku
            // 
            this.dtpAlku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlku.Location = new System.Drawing.Point(30, 94);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(110, 22);
            this.dtpAlku.TabIndex = 2;
            this.dtpAlku.ValueChanged += new System.EventHandler(this.dtpAlku_ValueChanged);
            // 
            // dtpLoppu
            // 
            this.dtpLoppu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoppu.Location = new System.Drawing.Point(206, 94);
            this.dtpLoppu.Name = "dtpLoppu";
            this.dtpLoppu.Size = new System.Drawing.Size(105, 22);
            this.dtpLoppu.TabIndex = 3;
            this.dtpLoppu.ValueChanged += new System.EventHandler(this.dtpLoppu_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hae laskut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Maksettu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(666, 475);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(113, 33);
            this.btnSulje.TabIndex = 7;
            this.btnSulje.Text = "Sulje";
            this.btnSulje.UseVisualStyleBackColor = true;
            // 
            // dgvLaskut
            // 
            this.dgvLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaskut.Location = new System.Drawing.Point(30, 134);
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.RowHeadersWidth = 51;
            this.dgvLaskut.RowTemplate.Height = 24;
            this.dgvLaskut.Size = new System.Drawing.Size(749, 326);
            this.dgvLaskut.TabIndex = 8;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(614, 83);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(101, 33);
            this.btnPoista.TabIndex = 9;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // laskut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 632);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.dgvLaskut);
            this.Controls.Add(this.btnSulje);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpLoppu);
            this.Controls.Add(this.dtpAlku);
            this.Controls.Add(this.Aikaväli);
            this.Controls.Add(this.Laskutus);
            this.Name = "laskut";
            this.Text = "laskut";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Laskutus;
        private System.Windows.Forms.Label Aikaväli;
        private System.Windows.Forms.DateTimePicker dtpAlku;
        private System.Windows.Forms.DateTimePicker dtpLoppu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSulje;
        private System.Windows.Forms.DataGridView dgvLaskut;
        private System.Windows.Forms.Button btnPoista;
    }
}