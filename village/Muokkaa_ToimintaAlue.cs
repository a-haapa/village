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
    public partial class Muokkaa_ToimintaAlue : Form
    {
        public Muokkaa_ToimintaAlue(Toimintaalue to)
        {
            //Syöttää olion tiedot text boxeihin
            InitializeComponent();
            tbID.Text = to.Toimintaalue_id.ToString();
            tbToimintaAlueenMuok.Text = to.Nimi;
        }


        private void btnPoistuToimintaMuokkaus_Click(object sender, EventArgs e)
        {
            yllapito formi = new yllapito();
            formi.Show();
            this.Close();
        }

        private void btnTallennaToimintaMuokkaus_Click(object sender, EventArgs e)
        {
            //tekee uuden olion ja käy päivittämässä olion tiedot tietokantaan
            Toimintaalue t = new Toimintaalue();
            t.Toimintaalue_id = int.Parse(tbID.Text);
            t.Nimi = tbToimintaAlueenMuok.Text;
            TaskDB.MuokkaaToimintaAlue(t);
            yllapito formi = new yllapito();
            formi.Show();
            this.Close();
        }
    }
}
