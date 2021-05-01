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
    public partial class paaikkuna : Form
    {
        public paaikkuna()
        {
            InitializeComponent();
            //Alla oleva lisää comboboxiin vaihtoehdot 
            cbToimintaAlue.DataSource = TaskDB.HaeToimintaalue();
            cbToimintaAlue.ValueMember = "toimintaalue_id";
            cbToimintaAlue.DisplayMember = "nimi";
            cbToimintaAlue.SelectedItem = null;
        }

        private void btnTeeVaraus_Click(object sender, EventArgs e)
        {
            //Etsii dgv:stä valitun rivin rivi-indexin ja hakee sen id-numeron muuttujaan ja hakee tietokannasta tiedot mökistä, jolla ko id-numro
            Mokki m = new Mokki();
            int row = dgvMokit.SelectedCells[0].RowIndex;
            int id = int.Parse(dgvMokit.Rows[row].Cells[0].Value.ToString());

            DateTime alku = dtpAlku.Value;
            DateTime loppu = dtpLoppu.Value;
            
            DataTable t = TaskDB.Hae(id);
            string ta = cbToimintaAlue.Text;
            //t siirtää valitun mökin tiedot, ta siirtää toiminta-alueen nimen.
            varaus vr = new varaus(id, t, ta, alku, loppu);
            vr.Show();
        }

        private void btnMokkienHaku_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
           
        }

        private void btnHaeMokit_Click(object sender, EventArgs e)
        {
            //Ottaa talteen toiminta-alueen ja henkilömäärän
            string toimintaalue = cbToimintaAlue.Text;
            int henkilomaara = int.Parse(cbHenkilomaara.Text);
            //Ottaa talteen päivämäärät
            DateTime date1 = DateTime.Parse(dtpAlku.Text);
            DateTime date2 = DateTime.Parse(dtpLoppu.Text);
            TimeSpan haluttuAikavali = date2 - date1;
            dgvMokit.DataSource = TaskDB.HaeMokki(henkilomaara);
            //Käy läpi DataGridViewn !! KESKEN EI TOIMI VIELÄ !! Tähän ajatuksena, että poistaa rivit jos mökki varattuna
            foreach (DataGridViewRow row in dgvMokit.Rows)
            {
                object value = row.Cells[7].Value;
                object value2 = row.Cells[8].Value;
                if (value != DBNull.Value || value2 != DBNull.Value)
                {
                    TimeSpan aikavali = DateTime.Parse(value2.ToString()) - DateTime.Parse(value.ToString());
                    if (haluttuAikavali > aikavali || haluttuAikavali < aikavali)
                    {
                        continue;
                    }
                    else dgvMokit.Rows.Remove(row);
                }
            }
        }

        private void btnYllapito_Click(object sender, EventArgs e)
        {
            yllapito formi = new yllapito();
            formi.Show();
        }
    }
}
