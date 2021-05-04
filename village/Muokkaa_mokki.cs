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
    public partial class Muokkaa_mokki : Form
    {
        public Muokkaa_mokki(Mokki mokki)
        {
            InitializeComponent();

            tbMuokkaMokkiID.Text = mokki.Mokki_id.ToString();
            tbMuokkaaMokkiNimi.Text = mokki.Mokkinimi.ToString();
            tbMuokkaamokinOsoite.Text = mokki.Katuosoite.ToString();
            tbMuokkaaMokinPostinro.Text = mokki.Postinro.ToString();
            tbMuokkaaMokinHlomaara.Text = mokki.Henkilomaara.ToString();
            tbMuokkaaMokinHinta.Text = mokki.Mokinhinta.ToString();
            TbMuokkaaMokinKuvaus.Text = mokki.Kuvaus.ToString();
            tbMuokkaaMokinVarustelu.Text = mokki.Varustelu.ToString();
        }

        private void btnMuokkaaMokkiPoistu_Click(object sender, EventArgs e)
        {
            yllapito formi = new yllapito();
            formi.Show();
            this.Close();
        }

        private void btnMuokkaaMokkiTallenna_Click(object sender, EventArgs e)
        {
            // tekee uuden mökkiolion ja käy päivittämässä olion tiedot tietokantaan

            Mokki m = new Mokki();
            m.Mokki_id = int.Parse(tbMuokkaMokkiID.Text);
            m.Mokkinimi = tbMuokkaaMokkiNimi.Text;
            m.Katuosoite = tbMuokkaamokinOsoite.Text;
            m.Postinro = tbMuokkaaMokinPostinro.Text;
            m.Henkilomaara = int.Parse(tbMuokkaaMokinHlomaara.Text);
            m.Mokinhinta = double.Parse(tbMuokkaaMokinHinta.Text);
            m.Kuvaus = TbMuokkaaMokinKuvaus.Text;
            m.Varustelu = tbMuokkaaMokinVarustelu.Text;
            TaskDB.MuokkaaMokki(m);
            yllapito formi = new yllapito();
            formi.Show();
            this.Close();
        }
    }
}
