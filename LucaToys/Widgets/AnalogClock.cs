using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Widgets
{
    public partial class AnalogClock : System.Windows.Forms.UserControl
    {
        private bool mouseDown;
        private Point lastLocation;


        public AnalogClock()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown == true)
            {
                this.Location = new Point(
                (this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void AnalogMouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
