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


        public AddProduct()
        {
            InitializeComponent();

            this.panel4.Controls.Add(this.addDoll);

            this.addDoll.Dock = DockStyle.Fill;

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
    }
}
