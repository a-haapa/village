
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
            this.btnAvaa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).BeginInit();
            this.SuspendLayout();
            // 
            // Laskutus
            // 
            this.Laskutus.AutoSize = true;
            this.Laskutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laskutus.Location = new System.Drawing.Point(37, 34);
            this.Laskutus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Laskutus.Name = "Laskutus";
            this.Laskutus.Size = new System.Drawing.Size(88, 30);
            this.Laskutus.TabIndex = 0;
            this.Laskutus.Text = "Laskut";
            // 
            // Aikaväli
            // 
            this.Aikaväli.AutoSize = true;
            this.Aikaväli.Location = new System.Drawing.Point(38, 111);
            this.Aikaväli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Aikaväli.Name = "Aikaväli";
            this.Aikaväli.Size = new System.Drawing.Size(80, 25);
            this.Aikaväli.TabIndex = 1;
            this.Aikaväli.Text = "Aikaväli";
            // 
            // dtpAlku
            // 
            this.dtpAlku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlku.Location = new System.Drawing.Point(41, 141);
            this.dtpAlku.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(150, 29);
            this.dtpAlku.TabIndex = 2;
            this.dtpAlku.ValueChanged += new System.EventHandler(this.dtpAlku_ValueChanged);
            // 
            // dtpLoppu
            // 
            this.dtpLoppu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoppu.Location = new System.Drawing.Point(283, 141);
            this.dtpLoppu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpLoppu.Name = "dtpLoppu";
            this.dtpLoppu.Size = new System.Drawing.Size(143, 29);
            this.dtpLoppu.TabIndex = 3;
            this.dtpLoppu.ValueChanged += new System.EventHandler(this.dtpLoppu_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hae laskut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(921, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Maksettu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(1129, 838);
            this.btnSulje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(200, 60);
            this.btnSulje.TabIndex = 7;
            this.btnSulje.Text = "Sulje";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // dgvLaskut
            // 
            this.dgvLaskut.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaskut.Location = new System.Drawing.Point(41, 201);
            this.dgvLaskut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.RowHeadersWidth = 51;
            this.dgvLaskut.RowTemplate.Height = 24;
            this.dgvLaskut.Size = new System.Drawing.Size(1288, 489);
            this.dgvLaskut.TabIndex = 8;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(1129, 133);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(200, 60);
            this.btnPoista.TabIndex = 9;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnAvaa
            // 
            this.btnAvaa.Location = new System.Drawing.Point(41, 698);
            this.btnAvaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvaa.Name = "btnAvaa";
            this.btnAvaa.Size = new System.Drawing.Size(200, 60);
            this.btnAvaa.TabIndex = 10;
            this.btnAvaa.Text = "Avaa lasku";
            this.btnAvaa.UseVisualStyleBackColor = true;
            this.btnAvaa.Click += new System.EventHandler(this.btnAvaa_Click);
            // 
            // laskut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 948);
            this.Controls.Add(this.btnAvaa);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnAvaa;
    }
}