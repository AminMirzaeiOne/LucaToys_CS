namespace LucaToys.Pages
{
    partial class VersionPage
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
            this.lblBuild = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBuild
            // 
            this.lblBuild.BackColor = System.Drawing.Color.Plum;
            this.lblBuild.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblBuild.ForeColor = System.Drawing.Color.White;
            this.lblBuild.Image = global::LucaToys.Properties.Resources.icons8_date_48;
            this.lblBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBuild.Location = new System.Drawing.Point(44, 319);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(385, 99);
            this.lblBuild.TabIndex = 0;
            this.lblBuild.Text = "Build Year : 2024";
            this.lblBuild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Plum;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Image = global::LucaToys.Properties.Resources.icons8_version_48__1_;
            this.lblVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVersion.Location = new System.Drawing.Point(44, 182);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(385, 99);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version : 1.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChannel
            // 
            this.lblChannel.BackColor = System.Drawing.Color.Plum;
            this.lblChannel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblChannel.ForeColor = System.Drawing.Color.White;
            this.lblChannel.Image = global::LucaToys.Properties.Resources.icons8_version_48;
            this.lblChannel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblChannel.Location = new System.Drawing.Point(44, 48);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(385, 99);
            this.lblChannel.TabIndex = 0;
            this.lblChannel.Text = "Channel : Stable";
            this.lblChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VersionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.lblBuild);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblChannel);
            this.Name = "VersionPage";
            this.Size = new System.Drawing.Size(494, 490);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblBuild;
    }
}
