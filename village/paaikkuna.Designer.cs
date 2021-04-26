
namespace village
{
    partial class paaikkuna
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnYllapito = new System.Windows.Forms.Button();
            this.btnVaraustenHallinta = new System.Windows.Forms.Button();
            this.btnMokkienHaku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTeeVaraus = new System.Windows.Forms.Button();
            this.btnHaeMokit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHenkilomaara = new System.Windows.Forms.ComboBox();
            this.cbToimintaAlue = new System.Windows.Forms.ComboBox();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 642);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnYllapito);
            this.tabPage1.Controls.Add(this.btnVaraustenHallinta);
            this.tabPage1.Controls.Add(this.btnMokkienHaku);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1132, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Etusivu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnYllapito
            // 
            this.btnYllapito.Location = new System.Drawing.Point(407, 420);
            this.btnYllapito.Margin = new System.Windows.Forms.Padding(2);
            this.btnYllapito.Name = "btnYllapito";
            this.btnYllapito.Size = new System.Drawing.Size(276, 46);
            this.btnYllapito.TabIndex = 3;
            this.btnYllapito.Text = "Ylläpito";
            this.btnYllapito.UseVisualStyleBackColor = true;
            this.btnYllapito.Click += new System.EventHandler(this.btnYllapito_Click);
            // 
            // btnVaraustenHallinta
            // 
            this.btnVaraustenHallinta.Location = new System.Drawing.Point(407, 351);
            this.btnVaraustenHallinta.Margin = new System.Windows.Forms.Padding(2);
            this.btnVaraustenHallinta.Name = "btnVaraustenHallinta";
            this.btnVaraustenHallinta.Size = new System.Drawing.Size(276, 46);
            this.btnVaraustenHallinta.TabIndex = 2;
            this.btnVaraustenHallinta.Text = "Varausten hallinta";
            this.btnVaraustenHallinta.UseVisualStyleBackColor = true;
            // 
            // btnMokkienHaku
            // 
            this.btnMokkienHaku.Location = new System.Drawing.Point(407, 284);
            this.btnMokkienHaku.Margin = new System.Windows.Forms.Padding(2);
            this.btnMokkienHaku.Name = "btnMokkienHaku";
            this.btnMokkienHaku.Size = new System.Drawing.Size(276, 46);
            this.btnMokkienHaku.TabIndex = 1;
            this.btnMokkienHaku.Text = "Mökkien haku";
            this.btnMokkienHaku.UseVisualStyleBackColor = true;
            this.btnMokkienHaku.Click += new System.EventHandler(this.btnMokkienHaku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(281, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Village Newbies";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTeeVaraus);
            this.tabPage2.Controls.Add(this.btnHaeMokit);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbHenkilomaara);
            this.tabPage2.Controls.Add(this.cbToimintaAlue);
            this.tabPage2.Controls.Add(this.dgvMokit);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1132, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mökkien haku";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTeeVaraus
            // 
            this.btnTeeVaraus.Location = new System.Drawing.Point(932, 524);
            this.btnTeeVaraus.Margin = new System.Windows.Forms.Padding(2);
            this.btnTeeVaraus.Name = "btnTeeVaraus";
            this.btnTeeVaraus.Size = new System.Drawing.Size(145, 32);
            this.btnTeeVaraus.TabIndex = 6;
            this.btnTeeVaraus.Text = "Tee varaus";
            this.btnTeeVaraus.UseVisualStyleBackColor = true;
            this.btnTeeVaraus.Click += new System.EventHandler(this.btnTeeVaraus_Click);
            // 
            // btnHaeMokit
            // 
            this.btnHaeMokit.Location = new System.Drawing.Point(66, 269);
            this.btnHaeMokit.Margin = new System.Windows.Forms.Padding(2);
            this.btnHaeMokit.Name = "btnHaeMokit";
            this.btnHaeMokit.Size = new System.Drawing.Size(145, 32);
            this.btnHaeMokit.TabIndex = 5;
            this.btnHaeMokit.Text = "Hae mökit";
            this.btnHaeMokit.UseVisualStyleBackColor = true;
            this.btnHaeMokit.Click += new System.EventHandler(this.btnHaeMokit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Henkilömäärä";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toiminta-alue";
            // 
            // cbHenkilomaara
            // 
            this.cbHenkilomaara.FormattingEnabled = true;
            this.cbHenkilomaara.Location = new System.Drawing.Point(66, 211);
            this.cbHenkilomaara.Margin = new System.Windows.Forms.Padding(2);
            this.cbHenkilomaara.Name = "cbHenkilomaara";
            this.cbHenkilomaara.Size = new System.Drawing.Size(268, 24);
            this.cbHenkilomaara.TabIndex = 2;
            // 
            // cbToimintaAlue
            // 
            this.cbToimintaAlue.FormattingEnabled = true;
            this.cbToimintaAlue.Location = new System.Drawing.Point(66, 141);
            this.cbToimintaAlue.Margin = new System.Windows.Forms.Padding(2);
            this.cbToimintaAlue.Name = "cbToimintaAlue";
            this.cbToimintaAlue.Size = new System.Drawing.Size(268, 24);
            this.cbToimintaAlue.TabIndex = 1;
            // 
            // dgvMokit
            // 
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(481, 91);
            this.dgvMokit.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.RowHeadersWidth = 72;
            this.dgvMokit.RowTemplate.Height = 31;
            this.dgvMokit.Size = new System.Drawing.Size(596, 373);
            this.dgvMokit.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1132, 613);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 658);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "paaikkuna";
            this.Text = "paaikkuna";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnYllapito;
        private System.Windows.Forms.Button btnVaraustenHallinta;
        private System.Windows.Forms.Button btnMokkienHaku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.Button btnTeeVaraus;
        private System.Windows.Forms.Button btnHaeMokit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHenkilomaara;
        private System.Windows.Forms.ComboBox cbToimintaAlue;
    }
}