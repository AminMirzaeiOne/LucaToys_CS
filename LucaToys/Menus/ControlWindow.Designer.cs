namespace LucaToys.Menus
{
    partial class ControlWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnMaxRes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnMaxRes);
            this.panel1.Controls.Add(this.btnClose);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Plum;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnRestart.FlatAppearance.BorderSize = 2;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            resources.ApplyResources(this.btnRestart, "btnRestart");
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Image = global::LucaToys.Properties.Resources.icons8_restart_48;
            this.btnRestart.Name = "btnRestart";
            this.toolTip1.SetToolTip(this.btnRestart, resources.GetString("btnRestart.ToolTip"));
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Plum;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnAbout.FlatAppearance.BorderSize = 2;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::LucaToys.Properties.Resources.icons8_about_48__1_;
            this.btnAbout.Name = "btnAbout";
            this.toolTip1.SetToolTip(this.btnAbout, resources.GetString("btnAbout.ToolTip"));
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Plum;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnMinimize.FlatAppearance.BorderSize = 2;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::LucaToys.Properties.Resources.icons8_minimize_48;
            this.btnMinimize.Name = "btnMinimize";
            this.toolTip1.SetToolTip(this.btnMinimize, resources.GetString("btnMinimize.ToolTip"));
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Plum;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::LucaToys.Properties.Resources.icons8_exit_48__1_;
            this.btnExit.Name = "btnExit";
            this.toolTip1.SetToolTip(this.btnExit, resources.GetString("btnExit.ToolTip"));
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Plum;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnHelp.FlatAppearance.BorderSize = 2;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::LucaToys.Properties.Resources.icons8_help_48;
            this.btnHelp.Name = "btnHelp";
            this.toolTip1.SetToolTip(this.btnHelp, resources.GetString("btnHelp.ToolTip"));
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnMaxRes
            // 
            this.btnMaxRes.BackColor = System.Drawing.Color.Plum;
            this.btnMaxRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxRes.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnMaxRes.FlatAppearance.BorderSize = 2;
            this.btnMaxRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnMaxRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            resources.ApplyResources(this.btnMaxRes, "btnMaxRes");
            this.btnMaxRes.ForeColor = System.Drawing.Color.White;
            this.btnMaxRes.Image = global::LucaToys.Properties.Resources.icons8_maximize_48__1_;
            this.btnMaxRes.Name = "btnMaxRes";
            this.toolTip1.SetToolTip(this.btnMaxRes, resources.GetString("btnMaxRes.ToolTip"));
            this.btnMaxRes.UseVisualStyleBackColor = false;
            this.btnMaxRes.Click += new System.EventHandler(this.btnMaxRes_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Plum;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::LucaToys.Properties.Resources.icons8_close_48__1_;
            this.btnClose.Name = "btnClose";
            this.toolTip1.SetToolTip(this.btnClose, resources.GetString("btnClose.ToolTip"));
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ControlWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ControlWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaxRes;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
