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
    public partial class AddUser : Form
    {
        public enum CheckedUserTypes
        {
            Manager, Seller, Customer
        }
        private bool mouseDown;
        private Point lastLocation;
        private LucaToys.Pages.AddManager addManager = new Pages.AddManager();
        private LucaToys.Pages.AddSeller addSeller = new Pages.AddSeller();
        private LucaToys.Pages.AddCustomer addCustomer = new Pages.AddCustomer();
        public AddUser(CheckedUserTypes usertype = CheckedUserTypes.Manager)
        {
            InitializeComponent();
            this.panel4.Controls.Add(this.addManager);
            this.panel4.Controls.Add(this.addSeller);
            this.panel4.Controls.Add(this.addCustomer);

            this.addManager.Dock = DockStyle.Fill;
            this.addSeller.Dock = DockStyle.Fill;
            this.addCustomer.Dock = DockStyle.Fill;

            switch (usertype)
            {
                case CheckedUserTypes.Manager:
                    this.radioButton2.Checked = true;
                    break;
                case CheckedUserTypes.Seller:
                    this.radioButton1.Checked = true;
                    break;
                case CheckedUserTypes.Customer:
                    this.radioButton3.Checked = true;
                    break;
            }

            this.BackColor = System.Drawing.Color.Black;
            this.TransparencyKey = System.Drawing.Color.Black;
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

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown == true)
            {
                this.Location = new Point(
                (this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);

                this.Update();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
                this.addManager.BringToFront();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.addSeller.BringToFront();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
                this.addCustomer.BringToFront();
        }
    }
}
