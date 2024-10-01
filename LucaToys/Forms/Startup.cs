using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Forms
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private System.IO.MemoryStream soundLocation = new MemoryStream(Properties.Sounds.CSSound);
        private System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        private bool mouseDown;
        private Point lastLocation;

        private void lineProgress_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Plum, 4), e.ClipRectangle);
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (this.makeProgress.Size.Width < this.lineProgress.Size.Width)
            {
                this.makeProgress.Size = new Size(this.makeProgress.Size.Width + 5, this.makeProgress.Size.Height);
            }
            else
            {
                this.timerProgress.Stop();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            this.soundPlayer.Stream = soundLocation;
            soundPlayer.Play();
            
            

        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown == true)
            {
                this.Location = new Point(
                (this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
