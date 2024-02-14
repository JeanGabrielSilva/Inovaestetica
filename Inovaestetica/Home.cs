﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inovaestetica
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Icon = new Icon(Path.Combine(Application.StartupPath, "INOVAESTETICA-LOGO.ico"));
            this.Text = "INOVAESTETICA";
        }

        private void buttonCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
