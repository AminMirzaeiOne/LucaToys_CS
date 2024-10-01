using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Menus
{
    public partial class ControlWindow : UserControl
    {
        public ControlWindow()
        {
            InitializeComponent();
            
        }

        [Category("Buttons Enable")]
        public System.Boolean CloseEnable { get { return this.btnClose.Enabled; } set { this.btnClose.Enabled = value; } }

        [Category("Buttons Enable")]
        public System.Boolean MaxResEnable { get { return this.btnMaxRes.Enabled; } set { this.btnMaxRes.Enabled = value; } }

        [Category("Buttons Enable")]
        public System.Boolean MinimizeEnable { get { return this.btnMinimize.Enabled; } set { this.btnMinimize.Enabled = value; } }

        [Category("Buttons Enable")]
        public System.Boolean HelpEnable { get { return this.btnHelp.Enabled; } set { this.btnHelp.Enabled = value; } }

        [Category("Buttons Enable")]
        public System.Boolean AboutEnable { get { return this.btnAbout.Enabled; } set { this.btnAbout.Enabled = value; } }

        [Category("Buttons Enable")]
        public System.Boolean ExitEnable { get { return this.btnExit.Enabled; } set { this.btnExit.Enabled = value; } }

        [Category("Buttons Enable")]
        public System.Boolean RestartEnable { get { return this.btnRestart.Enabled; } set { this.btnRestart.Enabled = value; } }

        public System.Windows.Forms.Form Window { get; set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.About about = new Forms.About();
            about.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
                this.Window.Close();
        }

        private void btnMaxRes_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
            {
                if (this.Window.WindowState == FormWindowState.Normal)
                {
                    this.Window.WindowState = FormWindowState.Maximized;
                }
                else if (this.Window.WindowState == FormWindowState.Maximized)
                {
                    this.Window.WindowState = FormWindowState.Normal;
                }
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
                this.Window.WindowState = FormWindowState.Minimized;
        }
    }
}
