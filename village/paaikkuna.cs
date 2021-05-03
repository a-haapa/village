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
            //Alla oleva lisää comboboxiin vaihtoehdot 
            cbToimintaAlue.DataSource = TaskDB.HaeToimintaalue();
            cbToimintaAlue.ValueMember = "toimintaalue_id";
            cbToimintaAlue.DisplayMember = "nimi";
            cbToimintaAlue.SelectedItem = null;
            dtpAlku.CustomFormat = " ";
            dtpLoppu.CustomFormat = " ";
        }

        private void btnTeeVaraus_Click(object sender, EventArgs e)
        {
            //Etsii dgv:stä valitun rivin rivi-indexin ja hakee sen id-numeron muuttujaan ja hakee tietokannasta tiedot mökistä, jolla ko id-numro
            Mokki m = new Mokki();
            int row = dgvMokit.SelectedCells[0].RowIndex;
            int id = int.Parse(dgvMokit.Rows[row].Cells[0].Value.ToString());

            DateTime alku = dtpAlku.Value;
            DateTime loppu = dtpLoppu.Value;
            
            DataTable t = TaskDB.Hae(id);
            string ta = cbToimintaAlue.Text;
            //t siirtää valitun mökin tiedot, ta siirtää toiminta-alueen nimen.
            varaus vr = new varaus(id, t, ta, alku, loppu);
            vr.Show();
        }

        private void btnMokkienHaku_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
           
        }

        private void btnHaeMokit_Click(object sender, EventArgs e)
        {
            
            string toimintaalue = cbToimintaAlue.Text;
            int id = int.Parse(cbToimintaAlue.SelectedValue.ToString());

            //Ottaa talteen päivämäärät
            DateTime date1 = DateTime.Parse(dtpAlku.Text);
            DateTime date2 = DateTime.Parse(dtpLoppu.Text);
            if (cbHenkilomaara.SelectedItem == null)
            {
                dgvMokit.DataSource = TaskDB.HaeMokki3(id, date1, date2);
            }
            else
            {
                int henkilomaara = int.Parse(cbHenkilomaara.Text);
                dgvMokit.DataSource = TaskDB.HaeMokki2(id, henkilomaara, date1, date2);
            }
            
        }

        private void btnYllapito_Click(object sender, EventArgs e)
        {
            yllapito formi = new yllapito();
            formi.Show();
        }

        private void btnVaraustenHallinta_Click(object sender, EventArgs e)
        {
            varausHallinta vh = new varausHallinta();
            vh.Show();
        }

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {
            dtpAlku.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {
            dtpLoppu.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }
    }
}
