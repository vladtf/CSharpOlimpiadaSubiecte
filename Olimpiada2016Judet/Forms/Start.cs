﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Olimpiada2016Judet.Forms
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var page = new Creare_cont_client();
            page.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var page = new Autentificare_client();
            page.ShowDialog(this);
        }
    }
}