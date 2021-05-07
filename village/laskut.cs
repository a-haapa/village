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
    public partial class laskut : Form
    {
        public laskut()
        {
            InitializeComponent();
            dtpAlku.CustomFormat = " ";
            dtpLoppu.CustomFormat = " ";
        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {
            dtpLoppu.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {
            dtpAlku.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime alku = DateTime.Parse(dtpAlku.Text);
            DateTime loppu = DateTime.Parse(dtpLoppu.Text);
            dgvLaskut.DataSource = TaskDB.HaeLaskut(alku,loppu);
        }
    }
}