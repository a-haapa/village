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
    public partial class paaikkuna : Form
    {
        public paaikkuna()
        {
            InitializeComponent();
        }

        private void btnTeeVaraus_Click(object sender, EventArgs e)
        {
            Mokki m = new Mokki();
            int row = dgvMokit.SelectedCells[0].RowIndex;
            int id = int.Parse(dgvMokit.Rows[row].Cells[0].Value.ToString());
            
            DataTable t = TaskDB.Hae(id);
            varaus vr = new varaus(t);
            vr.Show();
        }

        private void btnMokkienHaku_Click(object sender, EventArgs e)
        {

        }

        private void btnHaeMokit_Click(object sender, EventArgs e)
        {
            string toimintaalue = cbToimintaAlue.Text;
            int henkilomaara = int.Parse(cbHenkilomaara.Text);
            dgvMokit.DataSource = TaskDB.HaeMokki(henkilomaara);
        }
    }
}