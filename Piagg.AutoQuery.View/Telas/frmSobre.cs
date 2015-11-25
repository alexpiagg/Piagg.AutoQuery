﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piagg.AutoQuery.View
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();           
        }

        private void lblSite_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.alexpiagg.com");
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            lblNroVersao.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
