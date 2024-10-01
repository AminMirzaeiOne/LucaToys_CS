namespace LucaToys.Forms
{
    partial class Startup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.makeProgress = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lineProgress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timerProgress
            // 
            this.timerProgress.Enabled = true;
            this.timerProgress.Interval = 20;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.ForeColor = System.Drawing.Color.Plum;
            this.btnMinimize.Name = "btnMinimize";
            this.toolTip1.SetToolTip(this.btnMinimize, resources.GetString("btnMinimize.ToolTip"));
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.Plum;
            this.btnExit.Name = "btnExit";
            this.toolTip1.SetToolTip(this.btnExit, resources.GetString("btnExit.ToolTip"));
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LucaToys.Properties.Resources.MainBackground;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.makeProgress);
            this.panel1.Controls.Add(this.lblDeveloper);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lblChannel);
            this.panel1.Controls.Add(this.lineProgress);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Name = "panel1";
            // 
            // makeProgress
            // 
            this.makeProgress.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.makeProgress, "makeProgress");
            this.makeProgress.Name = "makeProgress";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.lblDeveloper, "lblDeveloper");
            this.lblDeveloper.ForeColor = System.Drawing.Color.White;
            this.lblDeveloper.Name = "lblDeveloper";
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Name = "lblVersion";
            // 
            // lblChannel
            // 
            this.lblChannel.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.lblChannel, "lblChannel");
            this.lblChannel.ForeColor = System.Drawing.Color.White;
            this.lblChannel.Name = "lblChannel";
            // 
            // lineProgress
            // 
            this.lineProgress.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lineProgress, "lineProgress");
            this.lineProgress.Name = "lineProgress";
            this.lineProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.lineProgress_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::LucaToys.Properties.Resources.LucaLogo;
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.Name = "picLogo";
            this.picLogo.TabStop = false;
            // 
            // Startup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Startup";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label makeProgress;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lineProgress;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
    }
}