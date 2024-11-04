using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;

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
        private Point lastLocation;

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
            this.lastLocation = e.Location;

        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.panel2.Size = new Size((this.panel2.Location.X - this.width) + e.X, this.panel2.Size.Height);
               
                //this.chromiumWebBrowser1.Location = new Point((this.chromiumWebBrowser1.Location.X - this.lastLocation.X) + e.X, this.chromiumWebBrowser1.Location.Y);

                this.Update();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void radioGoogle_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioGoogle.Checked) 
            {
                this.chromiumWebBrowser1.LoadUrl("https://www.google.com");
                this.chromiumWebBrowser1.ShowDevTools();

            }
        }

        private void radioInstagram_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioInstagram.Checked)
            {
                this.chromiumWebBrowser1.LoadUrl("https://www.instagram.com");
            }
        }

        private void radioTelegram_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioTelegram.Checked)
            {
                this.chromiumWebBrowser1.LoadUrl("https://web.telegram.org/");
            }
        }

        private void radioWhatsapp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioWhatsapp.Checked)
            {
                this.chromiumWebBrowser1.LoadUrl("https://web.whatsapp.com/");
            }
        }

        private void radioSpotify_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioSpotify.Checked)
            {
                this.chromiumWebBrowser1.LoadUrl("https://open.spotify.com/");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked) 
            {
                this.chromiumWebBrowser1.LoadUrl("https://www.wikipedia.org/");
            }
        }
    }
}
