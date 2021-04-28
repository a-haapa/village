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
            int i;
            Mokki m = new Mokki();
            m.Mokkinimi = tbNimi.Text;
            m.MokinToimintaalue.Nimi = cbAlue.SelectedItem.ToString();
            m.Katuosoite = tbOsoite.Text;
            m.Postinro = tbPostinro.Text;
            m.Henkilomaara = int.Parse(tbHenkilomaara.Text);
            m.Kuvaus = tbKuvaus.Text;
            m.Varustelu = tbVarustelu.Text;
            m.Mokinhinta = double.Parse(tbHinta.Text);
            m.Mokinalv = 10;
            TaskDB.LisaaMokki(m);
            dgvMokkilista.DataSource = TaskDB.HaeMokit();
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

        private void btnLisaaPalvelu_Click(object sender, EventArgs e)
        {
            Palvelu p = new Palvelu();
            p.Nimi = tbPalvNimi.Text;
            p.ToimintaAlue = cbPalvToimintaAlue.SelectedIndex.ToString();
            p.Tyyppi = tbPalveluTyyppi.Text;
            p.Kuvaus = tbPalvKuvaus.Text;
            p.Hinta = double.Parse(tbPalvHinta.Text);
            p.Alv = double.Parse(tbPalvAlv.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
