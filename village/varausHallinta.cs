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
                //Varmistaa haluaako käyttäjä poistaa, ottaa talteen varaus_id:n
                int row = dgvNaytavaraukset.SelectedCells[0].RowIndex;
                int id = int.Parse(dgvNaytavaraukset.Rows[row].Cells[0].Value.ToString());
                DateTime vahvistus = DateTime.Parse(dgvNaytavaraukset.Rows[row].Cells[2].Value.ToString()).AddDays(-2);
                //Jos varaus poistetaan yli 2 pv ennen varauksen alkamista, myös lasku poistuu
                if (vahvistus > DateTime.Today)
                {
                    TaskDB.PoistaLasku(id);
                }
                TaskDB.PoistaVaraus(id);

                dgvNaytavaraukset.DataSource = TaskDB.HaeVaraukset();
            }
        }

        private void btnLaskutus_Click(object sender, EventArgs e)
        {
            laskut laskut = new laskut();
            laskut.Show();
            this.Close();
        }
    }
}
