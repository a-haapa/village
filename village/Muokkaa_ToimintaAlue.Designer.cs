namespace village
{
    partial class Muokkaa_ToimintaAlue
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
            this.btnTallennaToimintaMuokkaus = new System.Windows.Forms.Button();
            this.btnPoistuToimintaMuokkaus = new System.Windows.Forms.Button();
            this.tbToimintaAlueenMuok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTallennaToimintaMuokkaus
            // 
            this.btnTallennaToimintaMuokkaus.Location = new System.Drawing.Point(82, 152);
            this.btnTallennaToimintaMuokkaus.Margin = new System.Windows.Forms.Padding(4);
            this.btnTallennaToimintaMuokkaus.Name = "btnTallennaToimintaMuokkaus";
            this.btnTallennaToimintaMuokkaus.Size = new System.Drawing.Size(100, 28);
            this.btnTallennaToimintaMuokkaus.TabIndex = 0;
            this.btnTallennaToimintaMuokkaus.Text = "Tallenna";
            this.btnTallennaToimintaMuokkaus.UseVisualStyleBackColor = true;
            this.btnTallennaToimintaMuokkaus.Click += new System.EventHandler(this.btnTallennaToimintaMuokkaus_Click);
            // 
            // btnPoistuToimintaMuokkaus
            // 
            this.btnPoistuToimintaMuokkaus.Location = new System.Drawing.Point(215, 152);
            this.btnPoistuToimintaMuokkaus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoistuToimintaMuokkaus.Name = "btnPoistuToimintaMuokkaus";
            this.btnPoistuToimintaMuokkaus.Size = new System.Drawing.Size(100, 28);
            this.btnPoistuToimintaMuokkaus.TabIndex = 1;
            this.btnPoistuToimintaMuokkaus.Text = "Poistu";
            this.btnPoistuToimintaMuokkaus.UseVisualStyleBackColor = true;
            this.btnPoistuToimintaMuokkaus.Click += new System.EventHandler(this.btnPoistuToimintaMuokkaus_Click);
            // 
            // tbToimintaAlueenMuok
            // 
            this.tbToimintaAlueenMuok.Location = new System.Drawing.Point(147, 108);
            this.tbToimintaAlueenMuok.Margin = new System.Windows.Forms.Padding(4);
            this.tbToimintaAlueenMuok.Name = "tbToimintaAlueenMuok";
            this.tbToimintaAlueenMuok.Size = new System.Drawing.Size(132, 22);
            this.tbToimintaAlueenMuok.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toiminta-alueen muokkaus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(147, 61);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(132, 22);
            this.tbID.TabIndex = 6;
            // 
            // Muokkaa_ToimintaAlue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 268);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbToimintaAlueenMuok);
            this.Controls.Add(this.btnPoistuToimintaMuokkaus);
            this.Controls.Add(this.btnTallennaToimintaMuokkaus);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Muokkaa_ToimintaAlue";
            this.Text = "Muokkaa_ToimintaAlue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTallennaToimintaMuokkaus;
        private System.Windows.Forms.Button btnPoistuToimintaMuokkaus;
        private System.Windows.Forms.TextBox tbToimintaAlueenMuok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
    }
}