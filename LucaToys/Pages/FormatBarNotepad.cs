using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Pages
{
    public partial class FormatBarNotepad : UserControl
    {
        public FormatBarNotepad()
        {
            InitializeComponent();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Crimson, 3), new Rectangle(50, 56, 35, 4));
        }
    }
}
