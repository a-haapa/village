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
    public partial class Muokkaa_palvelua : Form
    {
        public Muokkaa_palvelua(Palvelu p)
        {
            InitializeComponent();
            tbPalveluNimi.Text = p.Nimi;
            cbToimintaAlue.Text = p.toimintaalue.Nimi;
            tbTyyppi.Text = p.Tyyppi.ToString();
            tbKuvaus.Text = p.Kuvaus;
            tbHinta.Text = p.Hinta.ToString();
            tbAlv.Text = p.Alv.ToString();
        }

        private void btnPoistu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            Palvelu pa = new Palvelu();
            pa.Nimi = tbPalveluNimi.Text;
            pa.toimintaalue.Nimi = cbToimintaAlue.Text;
            pa.Tyyppi = int.Parse(tbTyyppi.Text);
            pa.Kuvaus = tbKuvaus.Text;
            pa.Hinta = double.Parse(tbHinta.Text);
            pa.Alv = double.Parse(tbAlv.Text);
            TaskDB.MuokkaaPalvelu(pa);
            yllapito formi = new yllapito();
            formi.Show();
            this.Close();
        }
    }
}
