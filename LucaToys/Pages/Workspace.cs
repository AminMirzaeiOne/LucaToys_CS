using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Pages
{
    public partial class Workspace : UserControl
    {
        public Workspace()
        {
            InitializeComponent();
        }

        private System.Boolean mouseDown = false;
        private System.Int32 width = 410;


        private void Workspace_Load(object sender, EventArgs e)
        {
            //this.chromiumWebBrowser1.LoadUrl("https://www.google.com/");
        }

        private void chromiumWebBrowser1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void chromiumWebBrowser1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.width = e.X;

        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.chromiumWebBrowser1.Size = new Size((this.chromiumWebBrowser1.Location.X - this.width) + e.X, this.chromiumWebBrowser1.Size.Height);

                this.Update();
            }
        }
    }
}
