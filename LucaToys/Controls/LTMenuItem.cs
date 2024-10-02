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
    public partial class LTMenuItem : UserControl
    {
        public LTMenuItem()
        {
            InitializeComponent();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.timerShow.Start();
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            if (this.label1.Size.Width < 10)
                this.label1.Size = new Size(this.label1.Size.Width + 1, this.label1.Size.Height);
            else
                this.timerShow.Stop();
        }

        private void timerHide_Tick(object sender, EventArgs e)
        {
            if (this.label1.Size.Width > 0)
                this.label1.Size = new Size(this.label1.Size.Width - 1, this.label1.Size.Height);
            else
                this.timerHide.Stop();
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.timerShow.Stop();
            this.timerHide.Start();
        }
    }
}
