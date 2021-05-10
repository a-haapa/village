
namespace village
{
    partial class avaaLasku
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAsiakas = new System.Windows.Forms.DataGridView();
            this.dgvMokki = new System.Windows.Forms.DataGridView();
            this.dgvVaraus = new System.Windows.Forms.DataGridView();
            this.btnTulosta = new System.Windows.Forms.Button();
            this.dgvPalv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lasku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asiakas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mökki";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 550);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Varaus";
            // 
            // dgvAsiakas
            // 
            this.dgvAsiakas.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsiakas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakas.Location = new System.Drawing.Point(37, 159);
            this.dgvAsiakas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAsiakas.Name = "dgvAsiakas";
            this.dgvAsiakas.RowHeadersWidth = 51;
            this.dgvAsiakas.RowTemplate.Height = 24;
            this.dgvAsiakas.Size = new System.Drawing.Size(1046, 148);
            this.dgvAsiakas.TabIndex = 4;
            // 
            // dgvMokki
            // 
            this.dgvMokki.BackgroundColor = System.Drawing.Color.White;
            this.dgvMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokki.Location = new System.Drawing.Point(36, 364);
            this.dgvMokki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMokki.Name = "dgvMokki";
            this.dgvMokki.RowHeadersWidth = 51;
            this.dgvMokki.RowTemplate.Height = 24;
            this.dgvMokki.Size = new System.Drawing.Size(1221, 141);
            this.dgvMokki.TabIndex = 5;
            // 
            // dgvVaraus
            // 
            this.dgvVaraus.BackgroundColor = System.Drawing.Color.White;
            this.dgvVaraus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraus.Location = new System.Drawing.Point(37, 580);
            this.dgvVaraus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVaraus.Name = "dgvVaraus";
            this.dgvVaraus.RowHeadersWidth = 51;
            this.dgvVaraus.RowTemplate.Height = 24;
            this.dgvVaraus.Size = new System.Drawing.Size(781, 154);
            this.dgvVaraus.TabIndex = 6;
            // 
            // btnTulosta
            // 
            this.btnTulosta.Location = new System.Drawing.Point(1075, 42);
            this.btnTulosta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTulosta.Name = "btnTulosta";
            this.btnTulosta.Size = new System.Drawing.Size(200, 60);
            this.btnTulosta.TabIndex = 7;
            this.btnTulosta.Text = "Tulosta";
            this.btnTulosta.UseVisualStyleBackColor = true;
            this.btnTulosta.Click += new System.EventHandler(this.btnTulosta_Click);
            // 
            // dgvPalv
            // 
            this.dgvPalv.BackgroundColor = System.Drawing.Color.White;
            this.dgvPalv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalv.Location = new System.Drawing.Point(852, 580);
            this.dgvPalv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPalv.Name = "dgvPalv";
            this.dgvPalv.RowHeadersWidth = 51;
            this.dgvPalv.RowTemplate.Height = 24;
            this.dgvPalv.Size = new System.Drawing.Size(404, 154);
            this.dgvPalv.TabIndex = 8;
            // 
            // avaaLasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 860);
            this.Controls.Add(this.dgvPalv);
            this.Controls.Add(this.btnTulosta);
            this.Controls.Add(this.dgvVaraus);
            this.Controls.Add(this.dgvMokki);
            this.Controls.Add(this.dgvAsiakas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "avaaLasku";
            this.Text = "avaaLasku";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAsiakas;
        private System.Windows.Forms.DataGridView dgvMokki;
        private System.Windows.Forms.DataGridView dgvVaraus;
        private System.Windows.Forms.Button btnTulosta;
        private System.Windows.Forms.DataGridView dgvPalv;
    }
}