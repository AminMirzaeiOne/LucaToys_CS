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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lineProgress = new System.Windows.Forms.Label();
            this.makeProgress = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::LucaToys.Properties.Resources.LucaLogo;
            this.picLogo.Location = new System.Drawing.Point(299, 105);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 200);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 35);
            this.label1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Plum;
            this.btnExit.Location = new System.Drawing.Point(768, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lineProgress
            // 
            this.lineProgress.BackColor = System.Drawing.Color.Transparent;
            this.lineProgress.Location = new System.Drawing.Point(204, 346);
            this.lineProgress.Name = "lineProgress";
            this.lineProgress.Size = new System.Drawing.Size(380, 18);
            this.lineProgress.TabIndex = 3;
            this.lineProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.lineProgress_Paint);
            // 
            // makeProgress
            // 
            this.makeProgress.BackColor = System.Drawing.Color.Plum;
            this.makeProgress.Location = new System.Drawing.Point(204, 346);
            this.makeProgress.Name = "makeProgress";
            this.makeProgress.Size = new System.Drawing.Size(10, 18);
            this.makeProgress.TabIndex = 3;
            this.makeProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.lineProgress_Paint);
            // 
            // lblChannel
            // 
            this.lblChannel.BackColor = System.Drawing.Color.Plum;
            this.lblChannel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblChannel.ForeColor = System.Drawing.Color.White;
            this.lblChannel.Location = new System.Drawing.Point(25, 434);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(185, 55);
            this.lblChannel.TabIndex = 3;
            this.lblChannel.Text = "Channel : Stable";
            this.lblChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Plum;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(239, 434);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(185, 55);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version : 1.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.makeProgress);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.lineProgress);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lineProgress;
        private System.Windows.Forms.Label makeProgress;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblVersion;
    }
}