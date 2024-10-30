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
    public partial class Screenshot : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Screenshot()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
