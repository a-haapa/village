﻿using System;
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
            cbToimintaAlue.Text = p.ToimintaAlue;
            tbTyyppi.Text = p.Tyyppi;
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
            pa.ToimintaAlue = cbToimintaAlue.Text;
            pa.Tyyppi = tbTyyppi.Text;
            pa.Kuvaus = tbKuvaus.Text;
            pa.Hinta = double.Parse(tbHinta.Text);
            pa.Alv = double.Parse(tbAlv.Text);
            TaskDB.MuokkaaPalvelu(pa);
            this.Close();
        }
    }
}
