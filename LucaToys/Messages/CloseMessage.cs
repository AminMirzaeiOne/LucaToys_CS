using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LucaToys.Controls;

namespace LucaToys.Messages
{
    public partial class CloseMessage : System.Windows.Forms.Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private System.Windows.Forms.Form window;

        public CloseMessage(System.Windows.Forms.Form Window)
        {
            InitializeComponent();
            this.window = Window;
            LTMenuItem itemCopy = new LTMenuItem();
            itemCopy.Text = "Copy Text";
            itemCopy.SymbolIcon = "";
            itemCopy.Clicked += new EventHandler(this.ItemCopy_Clicked);
            this.ltSmallMenu1.Items.Add(itemCopy);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaxRes_Click(object sender, EventArgs e)
        {
            this.window.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
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

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void ItemCopy_Clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.label3.Text);
        }
    }
}
