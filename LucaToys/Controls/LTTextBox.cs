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
            get { return this.tableLayoutPanel1.BackColor; }
            set
            {
                this.tableLayoutPanel1.BackColor = value;
            }
        }

        [Category("Border Appearance")]
        public System.Drawing.Color BorderHoverColor { get; set; } = Color.Violet;

        [Category("Border Appearance")]
        public System.Drawing.Color BorderDownColor { get; set; } = Color.Orchid;


    }
}
