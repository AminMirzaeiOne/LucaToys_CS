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
    public partial class AddProduct : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private LucaToys.Pages.AddDoll addDoll = new Pages.AddDoll();
        private LucaToys.Pages.AddToy addToy = new Pages.AddToy();
        private LucaToys.Pages.AddOther addOther = new Pages.AddOther();
        public enum CheckedProductTypes
        {
            Doll, Toy, Other
        }

        public AddProduct()
        {
            InitializeComponent();

            this.panel4.Controls.Add(this.addDoll);
            this.panel4.Controls.Add(this.addToy);
            this.panel4.Controls.Add(this.addOther);

            this.addDoll.Dock = DockStyle.Fill;
            this.addToy.Dock = DockStyle.Fill;
            this.addOther.Dock = DockStyle.Fill;

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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
                this.addDoll.BringToFront();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.addToy.BringToFront();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
                this.addOther.BringToFront();
        }
    }
}
