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
                this.panel3.Size = new Size((this.panel3.Location.X - this.width) + e.X, this.panel3.Size.Height);

                //this.chromiumWebBrowser1.Location = new Point((this.chromiumWebBrowser1.Location.X - this.lastLocation.X) + e.X, this.chromiumWebBrowser1.Location.Y);

                this.Update();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void radioGoogle_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.radioGoogle.Checked) 
            //{
            //    this.chromiumWebBrowser1.LoadUrl("https://www.google.com");
            //    this.chromiumWebBrowser1.ShowDevTools();

            //}
        }

        private void radioInstagram_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.radioInstagram.Checked)
            //{
            //    this.chromiumWebBrowser1.LoadUrl("https://www.instagram.com");
            //}
        }

        private void radioTelegram_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.radioTelegram.Checked)
            //{
            //    this.chromiumWebBrowser1.LoadUrl("https://web.telegram.org/");
            //}
        }

        private void radioWhatsapp_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.radioWhatsapp.Checked)
            //{
            //    this.chromiumWebBrowser1.LoadUrl("https://web.whatsapp.com/");
            //}
        }

        private void radioSpotify_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.radioSpotify.Checked)
            //{
            //    this.chromiumWebBrowser1.LoadUrl("https://open.spotify.com/");
            //}
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.radioButton4.Checked) 
            //{
            //    this.chromiumWebBrowser1.LoadUrl("https://www.wikipedia.org/");
            //}
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton9.Checked)
                this.chromiumWebBrowser1.LoadUrl("https://www.google.com/");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.chromiumWebBrowser1.LoadUrl("https://www.instagram.com/");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
                this.chromiumWebBrowser1.LoadUrl("https://www.tiktok.com/");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
                this.chromiumWebBrowser1.LoadUrl("https://web.whatsapp.com/");
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked)
                this.chromiumWebBrowser1.LoadUrl("https://web.telegram.org/");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton5.Checked)
                this.chromiumWebBrowser1.LoadUrl("https://www.youtube.com/");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton6.Checked)
                this.chromiumWebBrowser1.LoadUrl("https://open.spotify.com/");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton7.Checked)
                this.chromiumWebBrowser1.LoadUrl("https://twitter.com/login");
        }
    }
}
