using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace village
{
    public partial class laskutus : Form
    {
        public laskutus()
        {
            InitializeComponent();
            dtpAlku.CustomFormat = " ";
            dtpLoppu.CustomFormat = " ";
        }

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {

            dtpAlku.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {

            dtpLoppu.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }
    }
}
