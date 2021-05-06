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
            dgvRaportti.DataSource = tt;

            double paivat = 0;
            int rivi = 0;
            List<int> list = new List<int>();
            foreach (DataRow row in tt.Rows)
            {
                
                DateTime alkupv = (DateTime)tt.Rows[rivi].ItemArray[2];
                DateTime loppupv = tt.Rows[rivi].Field<DateTime>(3);
                DateTime vertaa = DateTime.Parse(dtpLoppu.Text);
                int id = int.Parse(tt.Rows[rivi].ItemArray[0].ToString());
                if (!list.Contains(id))
                {
                    list.Add(id);
                }
                rivi++;
                if (loppupv > vertaa)
                {
                    paivat += (vertaa - alkupv).TotalDays;
                }
                else
                {

                    paivat += (loppupv - alkupv).TotalDays;
                }
            }
            lbPaivat.Text = "Varatut päivät yhteensä: " + paivat.ToString();
            lbPaivat.Visible = true;
            DateTime raporttiAlku = DateTime.Parse(dtpAlku.Text);
            DateTime raporttiLoppu = DateTime.Parse(dtpLoppu.Text);
            double raportoitavaAika = (raporttiLoppu - raporttiAlku).TotalDays;
            int kerroin = list.Count;
            double mokkipäivatYht = raportoitavaAika * kerroin;
            double tayttoaste = (paivat / mokkipäivatYht) * 100;
            lbTaytto.Text = "Täyttöaste: " + tayttoaste.ToString() + " %";
            lbTaytto.Visible = true;
            
        }
    }
}
