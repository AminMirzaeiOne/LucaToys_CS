using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Controls
{
    public partial class LTComboBox : UserControl
    {
        public LTComboBox()
        {
            InitializeComponent();
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("", new Font("Segoe MDL2 Assets", 9, FontStyle.Bold), new SolidBrush(this.button6.ForeColor), new Point(e.ClipRectangle.Width-10,e.ClipRectangle.Height/2+2), sf);
        }
    }
}
