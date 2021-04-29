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
        public Muokkaa_ToimintaAlue()
        {
            InitializeComponent();
            
        }

        public Muokkaa_ToimintaAlue(Toimintaalue to)
        {
            InitializeComponent();

            tbToimintaAlueenMuok.Text = to.Nimi;
            
            

        }


        private void btnPoistuToimintaMuokkaus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
