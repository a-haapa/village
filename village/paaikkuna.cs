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
            varaus vr = new varaus();
            vr.Show();
        }
    }
}
