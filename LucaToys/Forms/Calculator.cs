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
    public partial class Calculator : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private System.String op = string.Empty;

        public Calculator()
        {
            InitializeComponent();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.label3.Text.Contains("."))
            {
                this.label3.Text += ".";
                this.button23.Enabled = true;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.label3.Text != "0")
            {
                this.label3.Text += "0";
                this.button23.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.label3.Text == "0")
                this.label3.Text = "";
            this.label3.Text += ((Button)sender).Text;
            this.button23.Enabled = true;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (this.label3.Text.Length > 1)
            {
                label3.Text = label3.Text.Remove(label3.Text.Length - 1, 1);
            }
            else
            {
                this.label3.Text = "0";
                this.button23.Enabled = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.label3.Text = string.Empty;
            this.label2.Text = string.Empty;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.label3.Text = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.op = ((Button)sender).Text;
            if (this.label3.Text != "0")
            {
                this.label2.Text = this.label3.Text;
                this.label3.Text = string.Empty;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            switch (this.op)
            {
                case "+":
                    this.label3.Text = Convert.ToDouble(Convert.ToDouble(this.label3.Text) + Convert.ToDouble(this.label2.Text)).ToString();
                    break;
                case "-":
                    this.label3.Text = Convert.ToDouble(Convert.ToDecimal(this.label2.Text) - Convert.ToDecimal(this.label3.Text)).ToString();
                    break;
                case "":
                    this.label3.Text = Convert.ToDouble(Convert.ToDouble(this.label3.Text) * Convert.ToDouble(this.label2.Text)).ToString();
                    break;
                case "":
                    this.label3.Text = Convert.ToDouble(Convert.ToDouble(this.label2.Text) / Convert.ToDouble(this.label3.Text)).ToString();
                    break;

            }
            this.label2.Text = "0";
        }
    }
}
