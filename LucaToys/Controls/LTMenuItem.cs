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

        private System.Drawing.Color baseBackColor = Color.White;
        private System.Drawing.Color baseForeColor = Color.Black;

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

        [Category("Symbol Options")]
        public System.String SymbolIcon
        {
            get { return this.label3.Text; }
            set { this.label3.Text = value; }
        }

        [Category("Symbol Options")]
        public System.Byte SymbolSize
        {
            get { return (byte) this.label3.Font.Size; }
            set { this.label3.Font = new Font(this.label3.Font.FontFamily,value,this.label3.Font.Style); }
        }

        [Category("Symbol Options")]
        public System.Byte SymbolWidth
        {
            get { return (byte)this.label3.Size.Width; }
            set { this.label3.Size = new Size(value,this.label3.Size.Height); }
        }

        public System.String Text
        {
            get { return this.label4.Text; }
            set
            {
                this.label4.Text = value;
            }
        }

        public override Font Font
        {
            get { return base.Font; }
            set 
            {
                base.Font = value;
                this.label4.Font = value;
            }
        }

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                this.label3.ForeColor = value;
                this.label4.ForeColor = value;
            }
        }



        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.timerShow.Start();
            this.baseForeColor = this.ForeColor;
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
            this.label3.ForeColor = this.baseForeColor;
            this.label4.ForeColor = this.baseForeColor;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            this.baseBackColor = this.BackColor;
            this.label3.BackColor = this.DownBackColor;
            this.label4.BackColor = this.DownBackColor;
            this.label3.ForeColor = this.DownForeColor;
            this.label4.ForeColor = this.DownForeColor;
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            this.label3.BackColor = this.baseBackColor;
            this.label4.BackColor = this.baseBackColor;
            this.label3.ForeColor = this.HoverForeColor;
            this.label4.ForeColor = this.HoverForeColor;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (this.Clicked != null)
                this.Clicked(sender, e);
        }
    }

    public class SeparatorMenuItem : System.Windows.Forms.Label
    {
        public SeparatorMenuItem(System.Byte width = 100 ,System.Byte height = 3)
        {
            this.AutoSize = false;
            this.Text = string.Empty;
            this.BackColor = Color.PaleVioletRed;
            this.Size = new Size(width, height);
        }

        public SeparatorMenuItem(System.Byte width = 100, System.Byte height = 3,DockStyle dock = DockStyle.Top)
        {
            this.AutoSize = false;
            this.Text = string.Empty;
            this.BackColor = Color.PaleVioletRed;
            this.Size = new Size(width, height);
        }
    }
}
