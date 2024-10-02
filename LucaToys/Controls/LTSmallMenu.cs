using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xTool = new XDropDown.XToolStripDropDown(borderPanel);
        }
        private XDropDown.XToolStripDropDown xTool;
        private System.Windows.Forms.TableLayoutPanel borderPanel = new System.Windows.Forms.TableLayoutPanel();
        private System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();


        public void Show()
        {
            //xTool()
        }
    }
}
