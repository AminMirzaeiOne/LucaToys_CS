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
            
            border.ColumnCount = 1;
            border.RowCount = 1;
            border.BackColor = System.Drawing.Color.Plum;
            border.Size = new Size(this.Size.Width, 600);
            border.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.BackColor = Color.FromArgb(20, 20, 20);
            panel.Margin = new Padding(2);

            xDrop = new XDropDown.XToolStripDropDown(border);
        }

        TableLayoutPanel border = new TableLayoutPanel();
        Panel panel = new Panel();

        private XDropDown.XToolStripDropDown xDrop;

        public System.String[] Items { get; set; }


        private void button6_Paint(object sender, PaintEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("", new Font("Segoe MDL2 Assets", 9, FontStyle.Bold), new SolidBrush(this.button6.ForeColor), new Point(e.ClipRectangle.Width-10,e.ClipRectangle.Height/2+2), sf);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            xDrop.Show(this);
            int hight = 0;
            if (this.Items != null)
            {
                for(int i = 0; i < this.Items.Length; i++)
                {
                    RadioButton item = new RadioButton();
                    item.Appearance = Appearance.Button;
                    item.AutoSize = false;
                    item.TextAlign = ContentAlignment.MiddleCenter;
                    item.BackColor = Color.FromArgb(20,20,20);
                    item.Dock = DockStyle.Top;
                    item.FlatStyle = FlatStyle.Flat;
                    item.FlatAppearance.BorderColor = Color.Plum;
                    item.ForeColor = Color.White;
                    item.FlatAppearance.CheckedBackColor = Color.Plum;
                    item.Size = new Size(item.Width, 40);
                    item.Text = "radiobutton";
                    hight += item.Size.Height;
                    this.panel.Controls.Add(item);

                }
            }
            this.border.Size = new Size(border.Width, hight);
        }
    }
}
