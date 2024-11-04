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
    public partial class Export : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Export()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Messages.CloseMessage closeMessage = new Messages.CloseMessage(this);
            closeMessage.ShowDialog();
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

        private void btnClose_Click_1(object sender, EventArgs e)
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox item in this.panel4.Controls.OfType<CheckBox>())
            {
                if (item == this.checkBox1)
                    continue;

                if (this.checkBox1.Checked)
                    item.Checked = true;
                else
                {
                    item.Checked = false;
                    this.checkBox2.Checked = true;
                }
                    

            }
        }
    }
}
