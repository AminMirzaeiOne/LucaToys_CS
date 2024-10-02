using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Controls
{
    public partial class LTTextBox : UserControl
    {
        public LTTextBox()
        {
            InitializeComponent();
        }

        private System.Drawing.Color borderColor = Color.Plum;

        [Category("Border Appearance")]
        public System.Byte BorderSize
        {
            get { return (byte) this.panel1.Margin.All; }
            set
            {
                this.panel1.Margin = new Padding(value);
            }
        }

        [Category("Border Appearance")]
        public System.Drawing.Color BorderColor
        {
            get { return this.borderColor; }
            set
            {
                this.borderColor = value;
                this.tableLayoutPanel1.BackColor = value;
            }
        }

        [Category("Border Appearance")]
        public System.Drawing.Color BorderHoverColor { get; set; } = Color.Violet;

        [Category("Border Appearance")]
        public System.Drawing.Color BorderDownColor { get; set; } = Color.Orchid;

        [Category("Hoder Appearance")]
        public System.Drawing.Color HolderTextColor
        {
            get { return this.label1.ForeColor; }
            set { this.label1.ForeColor = value; }
        }

        [Category("Hoder Appearance")]
        public System.Drawing.Font HolderTextFont
        {
            get { return  this.label1.Font; }
            set { this.label1.Font = value; }
        }

        [Category("Hoder Appearance")]
        public System.String HolderTextContent { get { return this.label1.Text; } set { this.label1.Text = value; } }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.TextLength > 0)
            {
                this.label1.Visible = false;
            }
            else
            {
                this.label1.Visible = true;
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.BackColor = this.BorderHoverColor;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.BackColor = this.BorderColor;
        }
    }
}
