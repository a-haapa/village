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
    public partial class varausHallinta : Form
    {
        public varausHallinta()
        {
            InitializeComponent();
            dgvNaytavaraukset.DataSource = TaskDB.HaeVaraukset();
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa varauksen?", "  ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int row = dgvNaytavaraukset.SelectedCells[0].RowIndex;
                int id = int.Parse(dgvNaytavaraukset.Rows[row].Cells[0].Value.ToString());
                TaskDB.PoistaVaraus(id);

                dgvNaytavaraukset.DataSource = TaskDB.HaeVaraukset();
            }
        }

        private void btnLaskutus_Click(object sender, EventArgs e)
        {
            
        }
    }
}
