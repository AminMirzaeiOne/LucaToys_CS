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
    public partial class PhoneBook : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private LucaToys.Pages.ListPhone listPhone = new Pages.ListPhone();
        private LucaToys.Pages.AddPhone addPhone = new Pages.AddPhone();
        private LucaToys.Pages.UpdatePhone updatePhone = new Pages.UpdatePhone();
        private LucaToys.Pages.DeletePhone deletePhone = new Pages.DeletePhone();

        public PhoneBook()
        {
            InitializeComponent();
            this.panel5.Controls.Add(this.listPhone);
            this.panel5.Controls.Add(this.addPhone);
            this.panel5.Controls.Add(this.updatePhone);
            this.panel5.Controls.Add(this.deletePhone);

            this.listPhone.Dock = DockStyle.Fill;
            this.addPhone.Dock = DockStyle.Fill;
            this.updatePhone.Dock = DockStyle.Fill;
            this.deletePhone.Dock = DockStyle.Fill;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.listPhone.BringToFront();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton2.Checked)
                this.addPhone.BringToFront();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
                this.updatePhone.BringToFront();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked)
                this.deletePhone.BringToFront();
        }
    }
}
