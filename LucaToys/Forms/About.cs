﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            xTool = new XDropDown.XToolStripDropDown(this.controlWindow);
        }
        XDropDown.XToolStripDropDown xTool;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private LucaToys.Menus.ControlWindow controlWindow = new Menus.ControlWindow();
        private void btnControl_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.xTool.Show(this.btnControl);
            }
        }
    }
}
