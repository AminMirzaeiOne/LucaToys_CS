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

        [Category("Appearance")]
        public System.Drawing.Color HoverForeColor { get; set; } = Color.DodgerBlue;

        [Category("Appearance")]
        public System.Drawing.Color DownForeColor { get; set; } = Color.White;

        [Category("Appearance")]
        public System.Drawing.Color DownBackColor { get; set; } = Color.DodgerBlue;

        [Category("Appearance")]
        public System.Drawing.Color LineColor
        {
            get { return this.label1.BackColor; }
            set { this.label1.BackColor = value; }
        }



        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.timerShow.Start();
            this.label3.ForeColor = this.HoverForeColor;
            this.label4.ForeColor = this.HoverForeColor;
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
            this.label3.BackColor = this.DownBackColor;
            this.label4.BackColor = this.DownBackColor;
            this.label3.ForeColor = this.DownForeColor;
            this.label4.ForeColor = this.DownForeColor;
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label3.ForeColor = this.HoverForeColor;
            this.label4.ForeColor = this.HoverForeColor;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (this.Clicked != null)
                this.Clicked(sender, e);
        }
    }
}
