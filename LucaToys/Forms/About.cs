using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.controlWindow.AboutEnable = false;
            this.controlWindow.Window = this;
            this.panel2.Controls.Add(this.versionPage);
            this.panel2.Controls.Add(this.developerPage);
            this.versionPage.Dock = DockStyle.Fill;
            this.developerPage.Dock = DockStyle.Fill;
            xTool = new XDropDown.XToolStripDropDown(this.controlWindow);
            
        }
        XDropDown.XToolStripDropDown xTool;
        LucaToys.Pages.VersionPage versionPage = new Pages.VersionPage();
        LucaToys.Pages.DeveloperPage developerPage = new Pages.DeveloperPage();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private LucaToys.Menus.ControlWindow controlWindow = new Menus.ControlWindow();
        private bool mouseDown;
        private Point lastLocation;

        private void btnControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.xTool.Show(this.btnControl);
            }
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.versionPage.BringToFront();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
                this.developerPage.BringToFront();
        }
    }
}
