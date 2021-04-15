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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvTaulukko.DataSource = TaskDB.ReadFromAsiakas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
