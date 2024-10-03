using System;
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
        }
        private LucaToys.Submenus.UsersSubmenu usersSubmenu;
        private LucaToys.Submenus.ProductsSubmenu productsSubmenu;
        private LucaToys.Submenus.WidgetsSubmenu widgetsSubmenu;
        private LucaToys.Submenus.ExportSubmenu exportSubmenu;
        private LucaToys.Submenus.AboutSubmenu aboutSubmenu;
        private LucaToys.Submenus.HelpSubmenu helpSubmenu;

    }
}
