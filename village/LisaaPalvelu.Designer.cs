
namespace village
{
    partial class VarausMuokkaus
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
            this.lbPalvelut = new System.Windows.Forms.ListBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPalvelut
            // 
            this.lbPalvelut.FormattingEnabled = true;
            this.lbPalvelut.ItemHeight = 16;
            this.lbPalvelut.Location = new System.Drawing.Point(34, 40);
            this.lbPalvelut.Name = "lbPalvelut";
            this.lbPalvelut.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPalvelut.Size = new System.Drawing.Size(182, 212);
            this.lbPalvelut.TabIndex = 0;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(34, 270);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(115, 41);
            this.btnLisaa.TabIndex = 1;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // VarausMuokkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(361, 419);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.lbPalvelut);
            this.Name = "VarausMuokkaus";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPalvelut;
        private System.Windows.Forms.Button btnLisaa;
    }
}

