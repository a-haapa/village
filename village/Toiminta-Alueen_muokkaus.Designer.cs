
namespace village
{
    partial class Toiminta_Alueen_muokkaus
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMuokkaaToimintaAlue = new System.Windows.Forms.Button();
            this.btnPoistuToimAlue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btnMuokkaaToimintaAlue
            // 
            this.btnMuokkaaToimintaAlue.Location = new System.Drawing.Point(68, 106);
            this.btnMuokkaaToimintaAlue.Name = "btnMuokkaaToimintaAlue";
            this.btnMuokkaaToimintaAlue.Size = new System.Drawing.Size(84, 34);
            this.btnMuokkaaToimintaAlue.TabIndex = 1;
            this.btnMuokkaaToimintaAlue.Text = "Tallenna";
            this.btnMuokkaaToimintaAlue.UseVisualStyleBackColor = true;
            // 
            // btnPoistuToimAlue
            // 
            this.btnPoistuToimAlue.Location = new System.Drawing.Point(185, 106);
            this.btnPoistuToimAlue.Name = "btnPoistuToimAlue";
            this.btnPoistuToimAlue.Size = new System.Drawing.Size(80, 34);
            this.btnPoistuToimAlue.TabIndex = 2;
            this.btnPoistuToimAlue.Text = "Poistu";
            this.btnPoistuToimAlue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toiminta-Alueen muokkaus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nimi";
            // 
            // Toiminta_Alueen_muokkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 181);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPoistuToimAlue);
            this.Controls.Add(this.btnMuokkaaToimintaAlue);
            this.Controls.Add(this.textBox1);
            this.Name = "Toiminta_Alueen_muokkaus";
            this.Text = "Toiminta_Alueen_muokkaus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMuokkaaToimintaAlue;
        private System.Windows.Forms.Button btnPoistuToimAlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}