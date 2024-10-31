using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CefSharp;
using CefSharp.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LucaToys.Forms
{
    public partial class WebBrowser : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public WebBrowser()
        {
            InitializeComponent();
            this.KeyPreview = true;
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

        private void WebBrowser_Load(object sender, EventArgs e)
        {

            this.chromiumWebBrowser1.LoadUrl("https://www.google.com/");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.chromiumWebBrowser1.LoadUrl("https://www.google.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chromiumWebBrowser1.Back();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chromiumWebBrowser1.Forward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.chromiumWebBrowser1.Refresh();
        }

        private void chromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                this.ltTextBox1.Text = e.Address;
            }));



        }

        private void ltTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void ltTextBox1_TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.chromiumWebBrowser1.LoadUrl(this.ltTextBox1.Text);
        }
    }
}
