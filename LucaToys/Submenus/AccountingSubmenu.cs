﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Submenus
{
    public partial class AccountingSubmenu : UserControl
    {
        public AccountingSubmenu(Control parent)
        {
            InitializeComponent();
            xTool = new XDropDown.XToolStripDropDown(this);
            this.ParentControl = parent;
            this.ParentControl.MouseDown += new MouseEventHandler(this.Parent_MouseDown);
        }
        private System.Windows.Forms.Control ParentControl;
        XDropDown.XToolStripDropDown xTool;

        public void ShowSubmenu(Control parent)
        {
            this.xTool.Show(parent);
        }

        private void Parent_MouseDown(object sender, MouseEventArgs e)
        {
            this.ShowSubmenu(this.ParentControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.PurchaseMode purchaseMode = new Forms.PurchaseMode();
            purchaseMode.Show();
        }
    }
}
