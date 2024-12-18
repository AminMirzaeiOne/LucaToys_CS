﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Menus
{
    public partial class HomeTopMenu : UserControl
    {
        public HomeTopMenu()
        {
            InitializeComponent();
            this.usersSubmenu = new Submenus.UsersSubmenu(this.button1);
            this.productsSubmenu = new Submenus.ProductsSubmenu(this.button3);
            this.widgetsSubmenu = new Submenus.WidgetsSubmenu(this.button11);
            this.aboutSubmenu = new Submenus.AboutSubmenu(this.button19);
            this.helpSubmenu = new Submenus.HelpSubmenu(this.button17);
            this.exportSubmenu = new Submenus.ExportSubmenu(this.button9);
            this.toolsSubmenu = new Submenus.ToolsSubmenu(this.button13);
            this.settingsSubmenu = new Submenus.SettingsSubmenu(this.button15);
            this.accountingSubmenu = new Submenus.AccountingSubmenu(this.button5);
            this.financeSubmenu = new Submenus.FinanceSubmenu(this.button7);
            this.documents = new Submenus.Documents(this.button21);
            this.invoice = new Submenus.Invoice(this.button23);
        }
        private LucaToys.Submenus.UsersSubmenu usersSubmenu;
        private LucaToys.Submenus.ProductsSubmenu productsSubmenu;
        private LucaToys.Submenus.WidgetsSubmenu widgetsSubmenu;
        private LucaToys.Submenus.ExportSubmenu exportSubmenu;
        private LucaToys.Submenus.AboutSubmenu aboutSubmenu;
        private LucaToys.Submenus.HelpSubmenu helpSubmenu;
        private LucaToys.Submenus.ToolsSubmenu toolsSubmenu;
        private LucaToys.Submenus.SettingsSubmenu settingsSubmenu;
        private LucaToys.Submenus.AccountingSubmenu accountingSubmenu;
        private LucaToys.Submenus.FinanceSubmenu financeSubmenu;
        private LucaToys.Submenus.Documents documents;
        private LucaToys.Submenus.Invoice invoice;

        private void btnMaxRes_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.Users users = new Forms.Users();
            users.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.Products products = new Forms.Products();
            products.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.About about = new Forms.About();
            about.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.Export export = new Forms.Export();
            export.Show();
        }
    }
}
