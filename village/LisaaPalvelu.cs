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
    public partial class VarausMuokkaus : Form
    {
        public VarausMuokkaus(varausL v)
        {
            InitializeComponent();
            lbPalvelut.DataSource = TaskDB.HaePalv(v);
            lbPalvelut.ValueMember = "palvelu_id";
            lbPalvelut.DisplayMember = "nimi";
            lbPalvelut.SelectedItem = null;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            Palvelu p = new Palvelu();
            varausL v = new varausL();
            foreach (var item in lbPalvelut.SelectedItems)
            {
                p.Palvelu_id = int.Parse(lbPalvelut.SelectedValue.ToString());
                v.Lukumaara = 1;
                TaskDB.LisaaVarauksenPalvelu(v, p);
            }
            this.Close();
        }
    }
}
