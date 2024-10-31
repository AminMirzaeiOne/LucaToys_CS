using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Submenus
{
    public partial class ToolsSubmenu : UserControl
    {
        public ToolsSubmenu()
        {
            InitializeComponent();
        }

        public ToolsSubmenu(Control parent)
        {
            InitializeComponent();
            xTool = new XDropDown.XToolStripDropDown(this);
            this.ParentControl = parent;
            this.ParentControl.MouseDown += new MouseEventHandler(this.Parent_MouseDown);
        }
        private System.Windows.Forms.Control ParentControl;
        XDropDown.XToolStripDropDown xTool;

        public void ShowSubmenu(Control parent)
        {
            this.xTool.Show(parent);
        }

        private void Parent_MouseDown(object sender, MouseEventArgs e)
        {
            this.ShowSubmenu(this.ParentControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.Drawing drawing = new Forms.Drawing();
            drawing.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.Notepad notepad = new Forms.Notepad();
            notepad.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.Converter converter = new Forms.Converter();
            converter.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.Screenshot screenshot = new Forms.Screenshot();
            screenshot.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.Player player = new Forms.Player();
            player.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.WebBrowser webBrowser = new Forms.WebBrowser();
            webBrowser.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.Translate translate = new Forms.Translate();
            translate.Show();
        }
    }
}
