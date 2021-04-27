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
            cbToimintaAlue.DataSource = TaskDB.HaeToimintaalue();
            cbToimintaAlue.ValueMember = "toimintaalue_id";
            cbToimintaAlue.DisplayMember = "nimi";
        }

        private void btnTeeVaraus_Click(object sender, EventArgs e)
        {
            //Etsii dgv:stä valitun rivin rivi-indexin ja hakee sen id-numeron muuttujaan ja hakee tietokannasta tiedot mökistä, jolla ko id-numro
            Mokki m = new Mokki();
            int row = dgvMokit.SelectedCells[0].RowIndex;
            int id = int.Parse(dgvMokit.Rows[row].Cells[0].Value.ToString());
            
            DataTable t = TaskDB.Hae(id);
            varaus vr = new varaus(t);
            vr.Show();
        }

        private void btnMokkienHaku_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
           
        }

        private void btnHaeMokit_Click(object sender, EventArgs e)
        {
            string toimintaalue = cbToimintaAlue.Text;
            int henkilomaara = int.Parse(cbHenkilomaara.Text);
            dgvMokit.DataSource = TaskDB.HaeMokki(henkilomaara);
        }

        private void btnYllapito_Click(object sender, EventArgs e)
        {
            yllapito formi = new yllapito();
            formi.Show();
        }
    }
}
