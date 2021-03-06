
namespace village
{
    partial class raportointi
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
            this.dtpAlku = new System.Windows.Forms.DateTimePicker();
            this.dtpLoppu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHaeRaportti = new System.Windows.Forms.Button();
            this.cbToimialueet = new System.Windows.Forms.ComboBox();
            this.btnSulje = new System.Windows.Forms.Button();
            this.dgvRaportti = new System.Windows.Forms.DataGridView();
            this.lbPaivat = new System.Windows.Forms.Label();
            this.lbTaytto = new System.Windows.Forms.Label();
            this.dgvPalvRapsa = new System.Windows.Forms.DataGridView();
            this.lbMaara = new System.Windows.Forms.Label();
            this.btnPdf1 = new System.Windows.Forms.Button();
            this.btnpdf2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaportti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvRapsa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpAlku
            // 
            this.dtpAlku.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpAlku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlku.Location = new System.Drawing.Point(28, 84);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(166, 22);
            this.dtpAlku.TabIndex = 0;
            this.dtpAlku.ValueChanged += new System.EventHandler(this.dtpAlku_ValueChanged);
            // 
            // dtpLoppu
            // 
            this.dtpLoppu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoppu.Location = new System.Drawing.Point(238, 84);
            this.dtpLoppu.Name = "dtpLoppu";
            this.dtpLoppu.Size = new System.Drawing.Size(169, 22);
            this.dtpLoppu.TabIndex = 1;
            this.dtpLoppu.ValueChanged += new System.EventHandler(this.dtpLoppu_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raportit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aikaväli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Toimialue";
            // 
            // btnHaeRaportti
            // 
            this.btnHaeRaportti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaeRaportti.ForeColor = System.Drawing.Color.Black;
            this.btnHaeRaportti.Location = new System.Drawing.Point(615, 72);
            this.btnHaeRaportti.Name = "btnHaeRaportti";
            this.btnHaeRaportti.Size = new System.Drawing.Size(145, 40);
            this.btnHaeRaportti.TabIndex = 6;
            this.btnHaeRaportti.Text = "Hae raportti";
            this.btnHaeRaportti.UseVisualStyleBackColor = true;
            this.btnHaeRaportti.Click += new System.EventHandler(this.btnHaeRaportti_Click);
            // 
            // cbToimialueet
            // 
            this.cbToimialueet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbToimialueet.FormattingEnabled = true;
            this.cbToimialueet.Location = new System.Drawing.Point(450, 82);
            this.cbToimialueet.Name = "cbToimialueet";
            this.cbToimialueet.Size = new System.Drawing.Size(121, 24);
            this.cbToimialueet.TabIndex = 7;
            // 
            // btnSulje
            // 
            this.btnSulje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSulje.ForeColor = System.Drawing.Color.Black;
            this.btnSulje.Location = new System.Drawing.Point(1155, 616);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(145, 40);
            this.btnSulje.TabIndex = 8;
            this.btnSulje.Text = "Sulje";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // dgvRaportti
            // 
            this.dgvRaportti.BackgroundColor = System.Drawing.Color.White;
            this.dgvRaportti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRaportti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaportti.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRaportti.Location = new System.Drawing.Point(28, 131);
            this.dgvRaportti.Name = "dgvRaportti";
            this.dgvRaportti.RowHeadersWidth = 51;
            this.dgvRaportti.RowTemplate.Height = 24;
            this.dgvRaportti.Size = new System.Drawing.Size(631, 432);
            this.dgvRaportti.TabIndex = 9;
            // 
            // lbPaivat
            // 
            this.lbPaivat.AutoSize = true;
            this.lbPaivat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaivat.Location = new System.Drawing.Point(37, 566);
            this.lbPaivat.Name = "lbPaivat";
            this.lbPaivat.Size = new System.Drawing.Size(60, 24);
            this.lbPaivat.TabIndex = 10;
            this.lbPaivat.Text = "label5";
            this.lbPaivat.Visible = false;
            // 
            // lbTaytto
            // 
            this.lbTaytto.AutoSize = true;
            this.lbTaytto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaytto.Location = new System.Drawing.Point(38, 602);
            this.lbTaytto.Name = "lbTaytto";
            this.lbTaytto.Size = new System.Drawing.Size(60, 24);
            this.lbTaytto.TabIndex = 11;
            this.lbTaytto.Text = "label5";
            this.lbTaytto.Visible = false;
            // 
            // dgvPalvRapsa
            // 
            this.dgvPalvRapsa.BackgroundColor = System.Drawing.Color.White;
            this.dgvPalvRapsa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPalvRapsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvRapsa.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPalvRapsa.Location = new System.Drawing.Point(665, 131);
            this.dgvPalvRapsa.Name = "dgvPalvRapsa";
            this.dgvPalvRapsa.RowHeadersWidth = 51;
            this.dgvPalvRapsa.RowTemplate.Height = 24;
            this.dgvPalvRapsa.Size = new System.Drawing.Size(692, 431);
            this.dgvPalvRapsa.TabIndex = 12;
            // 
            // lbMaara
            // 
            this.lbMaara.AutoSize = true;
            this.lbMaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaara.Location = new System.Drawing.Point(692, 566);
            this.lbMaara.Name = "lbMaara";
            this.lbMaara.Size = new System.Drawing.Size(60, 24);
            this.lbMaara.TabIndex = 13;
            this.lbMaara.Text = "label5";
            this.lbMaara.Visible = false;
            this.lbMaara.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnPdf1
            // 
            this.btnPdf1.Location = new System.Drawing.Point(289, 569);
            this.btnPdf1.Name = "btnPdf1";
            this.btnPdf1.Size = new System.Drawing.Size(118, 33);
            this.btnPdf1.TabIndex = 14;
            this.btnPdf1.Text = "PDF";
            this.btnPdf1.UseVisualStyleBackColor = true;
            this.btnPdf1.Click += new System.EventHandler(this.btnPdf1_Click);
            // 
            // btnpdf2
            // 
            this.btnpdf2.Location = new System.Drawing.Point(985, 569);
            this.btnpdf2.Name = "btnpdf2";
            this.btnpdf2.Size = new System.Drawing.Size(118, 33);
            this.btnpdf2.TabIndex = 15;
            this.btnpdf2.Text = "PDF";
            this.btnpdf2.UseVisualStyleBackColor = true;
            this.btnpdf2.Click += new System.EventHandler(this.btnpdf2_Click);
            // 
            // raportointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1369, 683);
            this.Controls.Add(this.btnpdf2);
            this.Controls.Add(this.btnPdf1);
            this.Controls.Add(this.lbMaara);
            this.Controls.Add(this.dgvPalvRapsa);
            this.Controls.Add(this.lbTaytto);
            this.Controls.Add(this.lbPaivat);
            this.Controls.Add(this.dgvRaportti);
            this.Controls.Add(this.btnSulje);
            this.Controls.Add(this.cbToimialueet);
            this.Controls.Add(this.btnHaeRaportti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLoppu);
            this.Controls.Add(this.dtpAlku);
            this.Name = "raportointi";
            this.Text = "raportointi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaportti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvRapsa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpAlku;
        private System.Windows.Forms.DateTimePicker dtpLoppu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHaeRaportti;
        private System.Windows.Forms.ComboBox cbToimialueet;
        private System.Windows.Forms.Button btnSulje;
        private System.Windows.Forms.DataGridView dgvRaportti;
        private System.Windows.Forms.Label lbPaivat;
        private System.Windows.Forms.Label lbTaytto;
        private System.Windows.Forms.DataGridView dgvPalvRapsa;
        private System.Windows.Forms.Label lbMaara;
        private System.Windows.Forms.Button btnPdf1;
        private System.Windows.Forms.Button btnpdf2;
    }
}