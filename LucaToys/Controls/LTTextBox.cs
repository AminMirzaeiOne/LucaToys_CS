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
        private System.Boolean focused = false;

        [Category("Border Appearance")]
        public System.Byte BorderSize
        {
            get { return (byte)this.panel1.Margin.All; }
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
            get { return this.label1.Font; }
            set { this.label1.Font = value; }
        }

        [Category("Hoder Appearance")]
        public System.String HolderTextContent { get { return this.label1.Text; } set { this.label1.Text = value; } }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.TextLength > 0)
            {
                this.label1.Visible = false;
                this.btnClear.Visible = true;
            }
            else
            {
                this.label1.Visible = true;
                this.btnClear.Visible = false;
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (!this.focused)
                this.tableLayoutPanel1.BackColor = this.BorderHoverColor;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!this.focused)
                this.tableLayoutPanel1.BackColor = this.BorderColor;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.focused = true;
            this.tableLayoutPanel1.BackColor = this.BorderDownColor;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.focused = false;
            this.tableLayoutPanel1.BackColor = this.BorderColor;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
        }
    }
}
