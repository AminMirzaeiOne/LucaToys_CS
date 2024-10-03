using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Controls
{
    public class LTSmallMenu : Component
    {
        public LTSmallMenu()
        {
            this.borderPanel.RowCount = 1;
            this.borderPanel.ColumnCount = 1;
            this.borderPanel.BackColor = Color.Plum;
            this.borderPanel.Controls.Add(this.panel);
            this.panel.BackColor = Color.White;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.xTool = new XDropDown.XToolStripDropDown(borderPanel);
            
        }

        private System.Windows.Forms.Control control = new Control();
        public List<Controls.LTMenuItem> Items = new List<LTMenuItem>();

        public System.Windows.Forms.Control Control
        {
            get { return this.control; }
            set
            {
                this.control = value;
                this.control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_Down);
            }
        }

        private XDropDown.XToolStripDropDown xTool;
        private System.Windows.Forms.TableLayoutPanel borderPanel = new System.Windows.Forms.TableLayoutPanel();
        private System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();


        public void Show()
        {
            this.UpdateItems();
            xTool.Show(this.Control);
        }

        private void Control_Down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                this.Show();
        }

        private void UpdateItems()
        {
            int height = 0;
            foreach(LTMenuItem item in this.Items)
            {
                this.panel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                height += item.Size.Height;
            }

            this.borderPanel.Size = new Size(this.borderPanel.Size.Width, height+4);
        }
    }
}
