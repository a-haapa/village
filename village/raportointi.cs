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
    public partial class raportointi : Form
    {
        public raportointi()
        {
            InitializeComponent();
            dtpAlku.CustomFormat = " ";
            dtpLoppu.CustomFormat = " ";
            cbToimialueet.DataSource = TaskDB.HaeToimintaalue();
            cbToimialueet.ValueMember = "toimintaalue_id";
            cbToimialueet.DisplayMember = "nimi";
            cbToimialueet.SelectedItem = null;
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {
            //Ajan arvon muuttuessa formaatti muuttuu tyhjästä tähän
            dtpLoppu.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {
            dtpAlku.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void btnHaeRaportti_Click(object sender, EventArgs e)
        {
            DateTime alku = DateTime.Parse(dtpAlku.Text);
            DateTime loppu = DateTime.Parse(dtpLoppu.Text);
            string toimialue = cbToimialueet.Text;
            DataTable tt = TaskDB.HaeRaportti(toimialue, alku, loppu);

            dgvPalvRapsa.DataSource = TaskDB.HaeVaratutPalv(toimialue,alku,loppu);
            int i = dgvPalvRapsa.Rows.Count - 1;
            lbMaara.Text = "Yhteensä: " + i + " kpl";
            lbMaara.Visible = true;

            double paivat = 0;
            int rivi = 0;

            List<int> list = new List<int>();
            try
            {
                foreach (DataRow row in tt.Rows)
                {
                    //Hakee taulukosta päivämäärät sekä dtp:loppupäivän vertailukohteeksi
                    DateTime alkupv = (DateTime)tt.Rows[rivi].ItemArray[2];
                    DateTime loppupv = tt.Rows[rivi].Field<DateTime>(3);
                    DateTime vertaa = DateTime.Parse(dtpLoppu.Text);
                    int id = int.Parse(tt.Rows[rivi].ItemArray[0].ToString());
                    //Jos listassa ei ole ko mökkiä, lisää sen id:n listaan, jotta myöhemmin voidaan laskea mökkien lukumäärä
                    if (!list.Contains(id))
                    {
                        list.Add(id);
                    }
                    rivi++;
                    //Jos päättymispäivä on suurempi, kuin vertauspäivä, lasketaan varatutpäivät vertauspäivän mukaan eli raportointijakson päättymisen mukaan
                    if (loppupv > vertaa)
                    {
                        paivat += (vertaa - alkupv).TotalDays;
                    }
                    else
                    {
                        //Muussa tapauksessa lasketaan loppupäivän mukaan. Tällä lasketaan varatut vuorokaudet kaikkiaan.
                        paivat += (loppupv - alkupv).TotalDays;
                    }
                }
                lbPaivat.Text = "Varatut päivät yhteensä: " + paivat.ToString("00");
                lbPaivat.Visible = true;
                DateTime raporttiAlku = DateTime.Parse(dtpAlku.Text);
                DateTime raporttiLoppu = DateTime.Parse(dtpLoppu.Text);
                //Lasketaan raportoitavien päivien määrä
                double raportoitavaAika = (raporttiLoppu - raporttiAlku).TotalDays;
                //Katsotaan listasta mökkien lukumäärä
                int kerroin = list.Count;
                //Kaikkiaan varattavissa olevien päivien määrä ajanjaksolla
                double mokkipäivatYht = raportoitavaAika * kerroin;
                //Täyttöaste
                double tayttoaste = (paivat / mokkipäivatYht) * 100;
                lbTaytto.Text = "Täyttöaste: " + tayttoaste.ToString("00") + " %";
                lbTaytto.Visible = true;
                cbToimialueet.SelectedItem = null;
                dgvRaportti.DataSource = tt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe tiedoissa! " + ex.Message);
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
