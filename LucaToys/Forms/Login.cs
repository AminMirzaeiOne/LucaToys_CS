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
        private bool mouseDown;
        private Point lastLocation;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown == true)
            {
                this.Location = new Point(
                (this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
