using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
            dgvPalvelut.DataSource = TaskDB.HaePalvelut();
            cbAlue.DataSource = TaskDB.HaeToimintaalue();
            //Alla olevat lisää comboboxeihin vaihtoehdot 
            cbAlue.ValueMember = "toimintaalue_id";
            cbAlue.DisplayMember = "nimi";
            cbAlue.SelectedItem = null;
            cbPalvToimintaAlue.DataSource = TaskDB.HaeToimintaalue();
            cbPalvToimintaAlue.ValueMember = "toimintaalue_id";
            cbPalvToimintaAlue.DisplayMember = "nimi";
            cbPalvToimintaAlue.SelectedItem = null;

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
            try
            {
                //Syötetään mökin tiedot olioon.
                Mokki m = new Mokki();
                m.Mokkinimi = tbNimi.Text;
                m.MokinToimintaalue.Nimi = cbAlue.Text;
                m.MokinToimintaalue.Toimintaalue_id = int.Parse(cbAlue.SelectedValue.ToString());
                m.Katuosoite = tbOsoite.Text;
                m.Postinro = tbPostinro.Text;
                m.Henkilomaara = int.Parse(tbHenkilomaara.Text);
                m.Kuvaus = tbKuvaus.Text;
                m.Varustelu = tbVarustelu.Text;
                m.Mokinhinta = double.Parse(tbHinta.Text);
                m.Mokinalv = 10;
                //Lisätään tietokantaan
                TaskDB.LisaaMokki(m);
                //Tyhjennetään tekstiboxit
                tbNimi.Clear();
                cbAlue.SelectedItem = null;
                tbHenkilomaara.Clear();
                tbKuvaus.Clear();
                tbOsoite.Clear();
                tbPostinro.Clear();
                tbVarustelu.Clear();
                tbHinta.Clear();
                //Haetaan mökit eli päivitetään muutokset DataGridView-taulukkoon
                dgvMokkilista.DataSource = TaskDB.HaeMokit();
            }
            catch
            {
                throw;
            }
            
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPoistaToimintaAlue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa toiminta-alueen?", "  ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int row = dgvToimintaalueet.SelectedCells[0].RowIndex;
                int id = int.Parse(dgvToimintaalueet.Rows[row].Cells[0].Value.ToString());
                TaskDB.PoistaToimintaAlue(id);

                dgvToimintaalueet.DataSource = TaskDB.HaeToimintaalue();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        public void btnMuokkaa_Click(object sender, EventArgs e)
        {
            try
            {
                // ottaa tiedot dgv:stä olioon
                Toimintaalue to = new Toimintaalue();
                int row = dgvToimintaalueet.SelectedCells[0].RowIndex;
                to.Toimintaalue_id = int.Parse(dgvToimintaalueet.Rows[row].Cells[0].Value.ToString());
                to.Nimi = (string)dgvToimintaalueet.Rows[row].Cells[1].Value;
                //avaa uuden formin ja siirtää olion sinne
                Muokkaa_ToimintaAlue formi = new Muokkaa_ToimintaAlue(to);
                this.Close();
                formi.Show();
            }
            catch
            {
                throw;
            }
            
        }

        private void btnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa palvelun?", "  ", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                int row = dgvPalvelut.SelectedCells[0].RowIndex;
                int id = int.Parse(dgvPalvelut.Rows[row].Cells[0].Value.ToString());
                TaskDB.PoistaPalvelu(id);

                dgvPalvelut.DataSource = TaskDB.HaePalvelut();
            }
        }

        private void btnLisaaPalvelu_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Syötetään palvelun tiedot olioon
                Palvelu p = new Palvelu();
                p.Nimi = tbPalvNimi.Text;
                p.toimintaalue.Nimi = cbPalvToimintaAlue.Text;
                string str = p.toimintaalue.Nimi;
                DataTable t = TaskDB.HaeTaID(str);
                p.toimintaalue.Toimintaalue_id = int.Parse(t.Rows[0].ItemArray[0].ToString());
                p.Tyyppi = int.Parse(tbPalvTyyppi.Text);
                p.Kuvaus = tbPalvKuvaus.Text;
                p.Hinta = double.Parse(tbPalvHinta.Text);
                p.Alv = double.Parse(tbPalvAlv.Text);
                //lisätään tietokantaan
                TaskDB.LisaaPalvelu(p);
                //tyhjennetään tekstikentät
                tbPalvNimi.Clear();
                cbPalvToimintaAlue.SelectedItem = null;
                tbPalvTyyppi.Clear();
                tbPalvKuvaus.Clear();
                tbPalvHinta.Clear();
                tbPalvAlv.Clear();
                //päivitetään muutokset datagridviewiin
                dgvPalvelut.DataSource = TaskDB.HaePalvelut();
            }
            catch
            {
                throw;
            }
            
        }

        private void btnPoistamokki_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa mökin?", "  ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int row = dgvMokkilista.SelectedCells[0].RowIndex;
                int id = int.Parse(dgvMokkilista.Rows[row].Cells[0].Value.ToString());
                TaskDB.PoistaMokki(id);

                dgvMokkilista.DataSource = TaskDB.HaeMokit();
            }
        }

        private void btnMuokkaaPalvelua_Click(object sender, EventArgs e)
        {
            try
            {
                // ottaa tiedot dgv:stä olioon
                Palvelu pa = new Palvelu();
                int row = dgvPalvelut.SelectedCells[0].RowIndex;
                pa.Palvelu_id = int.Parse(dgvPalvelut.Rows[row].Cells[0].Value.ToString());
                pa.toimintaalue.Nimi = (string)dgvPalvelut.Rows[row].Cells[1].Value;
                pa.Nimi = (string)dgvPalvelut.Rows[row].Cells[2].Value;
                pa.Tyyppi = int.Parse(dgvPalvelut.Rows[row].Cells[3].Value.ToString());
                pa.Kuvaus = (string)dgvPalvelut.Rows[row].Cells[4].Value;
                pa.Hinta = double.Parse(dgvPalvelut.Rows[row].Cells[5].Value.ToString());
                pa.Alv = double.Parse(dgvPalvelut.Rows[row].Cells[6].Value.ToString());
                //avaa uuden formin ja siirtää olion sinne
                Muokkaa_palvelua formi = new Muokkaa_palvelua(pa);
                this.Close();
                formi.Show();
            }
            catch
            {
                throw;
            }
        }

        private void btnMuokkaamokki_Click(object sender, EventArgs e)
        {

        }

		private void btnLisaa_Click(object sender, EventArgs e)
		{
            Asiakas a = new Asiakas();
            a.Etunimi = tbAsEtunimi.Text;
            a.Sukunimi = tbAsSukunimi.Text;
            a.Lahiosoite = tbAsLahiosoite.Text;
            a.Postinro = tbAsPostinumero.Text;
            a.Email = tbAsEmail.Text;
            a.Puhelinnro = tbAsPuhnro.Text;
            TaskDB.LisaaAsiakas(a);
            tbAsEtunimi.Clear();
            tbAsSukunimi.Clear();
            tbAsLahiosoite.Clear();
            tbAsPostinumero.Clear();
            tbAsEmail.Clear();
            tbAsPuhnro.Clear();
            dgvAsiakkaanTiedot.DataSource = TaskDB.HaeAsiakkaanTiedot();
            
		}
	}
}
