using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public event KeyEventHandler TextBoxKeyDown;

        public System.Boolean EnableClearButton { get; set; } = true;

        public System.String Text
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }
        public Font FontOptions
        {
            get { return this.textBox1.Font; }
            set
            {
                this.textBox1.Font = value;
            }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                this.textBox1.BackColor = value;
                this.label1.BackColor = value;
                this.btnClear.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                this.textBox1.ForeColor = value;
            }
        }



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
                if (this.EnableClearButton)
                    this.btnClear.Visible = true;
            }
            else
            {
                this.label1.Visible = true;
                if (this.EnableClearButton)
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.TextBoxKeyDown != null)
                this.TextBoxKeyDown(sender, e);
        }

        public void Clear()
        {
            this.btnClear_Click(null, null);
            this.textBox1.Clear();
        }
    }
}
