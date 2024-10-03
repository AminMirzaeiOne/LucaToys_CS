using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LucaToys.Controls;

namespace LucaToys.Forms
{
    public partial class Home : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Home()
        {
            InitializeComponent();
            this.controlWindow.Window = this;
            this.xTool = new XDropDown.XToolStripDropDown(this.controlWindow);
            LTMenuItem itemBackground = new LTMenuItem();
            LTMenuItem itemRemoveWidget = new LTMenuItem();
            itemBackground.SymbolIcon = "";
            itemRemoveWidget.SymbolIcon = "";
            itemBackground.Text = "Change Background";
            itemRemoveWidget.Text = "Remove Widgets";
            this.ltSmallMenu1.Items.Add(itemBackground);
            this.ltSmallMenu1.Items.Add(itemRemoveWidget);
            this.ltSmallMenu1.AddSeparator();

        }
        XDropDown.XToolStripDropDown xTool;
        private LucaToys.Menus.ControlWindow controlWindow = new Menus.ControlWindow();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Messages.CloseMessage closeMessage = new Messages.CloseMessage(this);
            closeMessage.ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btnMaximize.Text = "";
            }
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.btnMaximize.Text = "";
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

        private void btnControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.xTool.Show(this.btnControl);
            }
        }
    }
}
