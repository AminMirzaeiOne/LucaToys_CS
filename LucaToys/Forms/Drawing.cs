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
    public partial class Drawing : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private LucaToys.Pages.FileBarDrwing fileBar = new Pages.FileBarDrwing();
        private LucaToys.Pages.EditBarDrawing editBar = new Pages.EditBarDrawing();
        private LucaToys.Pages.ViewBarDrawing viewBar = new Pages.ViewBarDrawing();
        private LucaToys.Pages.ToolsBarDrwing toolsBar = new Pages.ToolsBarDrwing();
        private LucaToys.Pages.DesignBarDrwing designBar = new Pages.DesignBarDrwing();

        public Drawing()
        {
            InitializeComponent();

            this.panel3.Controls.Add(this.fileBar);
            this.panel3.Controls.Add(this.editBar);
            this.panel3.Controls.Add(this.viewBar);
            this.panel3.Controls.Add(this.toolsBar);
            this.panel3.Controls.Add(this.designBar);

            this.fileBar.Dock = DockStyle.Fill;
            this.editBar.Dock = DockStyle.Fill;
            this.viewBar.Dock = DockStyle.Fill;
            this.toolsBar.Dock = DockStyle.Fill;
            this.designBar.Dock = DockStyle.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Messages.CloseMessage closeMessage = new Messages.CloseMessage(this);
            closeMessage.ShowDialog();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btnMaximize.Text = "";
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.btnMaximize.Text = "";
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown == true)
            {
                this.Location = new Point(
                (this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
                this.fileBar.BringToFront();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.editBar.BringToFront();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
                this.toolsBar.BringToFront();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked)
                this.viewBar.BringToFront();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton5.Checked)
                this.designBar.BringToFront();
        }
    }
}
