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
        private System.Drawing.Color hoverForeColor = Color.Plum;
        private System.Drawing.Color downForeColor = Color.White;
        private System.Drawing.Color downBackColor = Color.Plum;
        private System.Drawing.Color lineColor = Color.Plum;
        private System.Byte symbolSize = 8;
        private System.Byte symbolWidth = 40;
        private System.Drawing.Font font = new Font("Segoe UI", 9, FontStyle.Regular);
        private System.Drawing.Color backColor = Color.White;
        private System.Drawing.Color foreColor = Color.Black;

        [Category("Appearance")]
        public System.Drawing.Color HoverForeColor 
        { 
            get { return this.hoverForeColor; }
            set
            {
                this.hoverForeColor = value;
                foreach(var item in this.Items)
                {
                    item.HoverForeColor = value;
                }
                
            }
        }

        [Category("Appearance")]
        public System.Drawing.Color DownForeColor
        {
            get { return this.downForeColor; }
            set
            {
                this.downForeColor = value;
                foreach (var item in this.Items)
                {
                    item.DownForeColor = value;
                }

            }
        }

        [Category("Appearance")]
        public System.Drawing.Color DownBackColor
        {
            get { return this.downBackColor; }
            set
            {
                this.downBackColor = value;
                foreach (var item in this.Items)
                {
                    item.DownBackColor = value;
                }

            }
        }

        [Category("Appearance")]
        public System.Drawing.Color LineColor
        {
            get { return this.lineColor; }
            set
            {
                this.lineColor = value;
                foreach (var item in this.Items)
                {
                    item.LineColor = value;
                }
            }
        }

        [Category("Symbol Options")]
        public System.Byte SymbolSize
        {
            get { return this.symbolSize; }
            set
            {
                this.symbolSize = value;
                foreach (var item in this.Items)
                {
                    item.SymbolSize = value;
                }
            }
        }

        [Category("Symbol Options")]
        public System.Byte SymbolWidth
        {
            get { return this.symbolWidth; }
            set
            {
                this.symbolWidth = value;
                foreach (var item in this.Items)
                {
                    item.SymbolWidth = value;
                }
            }
        }

        public System.Drawing.Font Font
        {
            get { return this.font; }
            set
            {
                this.font = value;
                foreach (var item in this.Items)
                {
                    item.Font = value;
                }
            }
        }

        public System.Drawing.Color BackColor
        {
            get { return this.backColor; }
            set
            {
                this.backColor = value;
                this.panel.BackColor = value;
                foreach (var item in this.Items)
                {
                    item.BackColor = value;
                }
            }
        }

        public System.Drawing.Color ForeColor
        {
            get { return this.foreColor; }
            set
            {
                this.foreColor = value;
                foreach (var item in this.Items)
                {
                    item.ForeColor = value;
                }
            }
        }


        public void Show()
        {
            this.UpdateItems();
            xTool.Show(Cursor.Position);
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
                item.HoverForeColor = this.HoverForeColor;
                item.DownForeColor = this.DownForeColor;
                item.DownBackColor = this.DownBackColor;
                item.LineColor = this.LineColor;
                item.SymbolWidth = this.SymbolWidth;
                item.SymbolSize = this.SymbolSize;
                item.Font = this.Font;
                item.BackColor = this.BackColor;
                item.ForeColor = this.ForeColor;
            }

            this.borderPanel.Size = new Size(this.borderPanel.Size.Width, height+4);
        }
    }
}
