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
    public partial class laskut : Form
    {
        public laskut()
        {
            InitializeComponent();
            dtpAlku.CustomFormat = " ";
            dtpLoppu.CustomFormat = " ";
            dgvLaskut.DataSource = TaskDB.HaeKaikkiLaskut();
        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {
            dtpLoppu.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {
            dtpAlku.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime alku = DateTime.Parse(dtpAlku.Text);
            DateTime loppu = DateTime.Parse(dtpLoppu.Text);
            dgvLaskut.DataSource = TaskDB.HaeLaskut(alku,loppu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {   //Hakee aikavälin ja toiminta-alueen laskut
                int row = dgvLaskut.SelectedCells[0].RowIndex;
                Lasku l = new Lasku();
                l.varaus.Varaus_id = int.Parse(dgvLaskut.Rows[row].Cells[0].Value.ToString());
                DateTime date = DateTime.Today;
                TaskDB.MuokkaaVahvistus(l, date);
                DateTime alku = DateTime.Parse(dtpAlku.Text);
                DateTime loppu = DateTime.Parse(dtpLoppu.Text);
                dgvLaskut.DataSource = TaskDB.HaeLaskut(alku, loppu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virheellinen syöte" + ex.Message);
            }
        }

        private void btnAvaa_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgvLaskut.SelectedCells[0].RowIndex;
                int varausid = int.Parse(dgvLaskut.Rows[row].Cells[0].Value.ToString());
                int lasku_id = int.Parse(dgvLaskut.Rows[row].Cells[1].Value.ToString());
                avaaLasku uusi = new avaaLasku(varausid,lasku_id);
                uusi.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virheellinen syöte" + ex.Message);
            }
            
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            int row = dgvLaskut.SelectedCells[0].RowIndex;
            int id = int.Parse(dgvLaskut.Rows[row].Cells[0].Value.ToString());
            TaskDB.PoistaLasku(id);
        }
    }
}
