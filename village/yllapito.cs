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
    public partial class yllapito : Form
    {
        public yllapito()
        {
            InitializeComponent();
            dgvToimintaalueet.DataSource = TaskDB.HaeToimintaalue();
            dgvMokkilista.DataSource = TaskDB.HaeMokit();
        }

        private void btnLisaaToimintaAlue_Click(object sender, EventArgs e)
        {
            Toimintaalue t = new Toimintaalue();
            t.Nimi = tbToimintaAlue.Text;
            TaskDB.LisaaToimintaalue(t);
            dgvToimintaalueet.DataSource = TaskDB.HaeToimintaalue();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLisaamokki_Click(object sender, EventArgs e)
        {

        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            paaikkuna formi = new paaikkuna();
            formi.Show();
        }

        private void btnPoistaToimintaAlue_Click(object sender, EventArgs e)
        {
            int row = dgvToimintaalueet.SelectedCells[0].RowIndex;
            int id = int.Parse(dgvToimintaalueet.Rows[row].Cells[0].Value.ToString());
            TaskDB.PoistaToimintaAlue(id);

            dgvToimintaalueet.DataSource = TaskDB.HaeToimintaalue();
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
