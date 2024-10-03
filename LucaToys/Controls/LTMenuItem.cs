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

        public event EventHandler Clicked;

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.timerShow.Start();
            this.label3.ForeColor = Color.PaleVioletRed;
            this.label4.ForeColor = Color.PaleVioletRed;
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
            this.label3.ForeColor = Color.Black;
            this.label4.ForeColor = Color.Black;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            this.label3.BackColor = Color.Plum;
            this.label4.BackColor = Color.Plum;
            this.label3.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label3.ForeColor = Color.PaleVioletRed;
            this.label4.ForeColor = Color.PaleVioletRed;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Clicked(sender, e);
        }
    }
}
