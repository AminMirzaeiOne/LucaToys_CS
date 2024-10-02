using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.panel2.Controls.Add(this.loginPage);
            this.panel2.Controls.Add(this.foregetPage);
            this.loginPage.Dock = DockStyle.Fill;
            this.foregetPage.Dock = DockStyle.Fill;
            this.foregetPage.BringToFront();
        }

        private LucaToys.Pages.LoginPage loginPage = new Pages.LoginPage();
        private LucaToys.Pages.ForgetPage foregetPage = new Pages.ForgetPage();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
