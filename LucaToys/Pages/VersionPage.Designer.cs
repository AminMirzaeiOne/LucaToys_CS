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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionPage));
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuild = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::LucaToys.Properties.Resources.icons8_licence_48;
            this.label1.Name = "label1";
            // 
            // lblBuild
            // 
            resources.ApplyResources(this.lblBuild, "lblBuild");
            this.lblBuild.BackColor = System.Drawing.Color.Plum;
            this.lblBuild.ForeColor = System.Drawing.Color.White;
            this.lblBuild.Image = global::LucaToys.Properties.Resources.icons8_date_48;
            this.lblBuild.Name = "lblBuild";
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.BackColor = System.Drawing.Color.Plum;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Image = global::LucaToys.Properties.Resources.icons8_version_48__1_;
            this.lblVersion.Name = "lblVersion";
            // 
            // lblChannel
            // 
            resources.ApplyResources(this.lblChannel, "lblChannel");
            this.lblChannel.BackColor = System.Drawing.Color.Plum;
            this.lblChannel.ForeColor = System.Drawing.Color.White;
            this.lblChannel.Image = global::LucaToys.Properties.Resources.icons8_version_48;
            this.lblChannel.Name = "lblChannel";
            // 
            // VersionPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBuild);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblChannel);
            this.Name = "VersionPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblBuild;
        private System.Windows.Forms.Label label1;
    }
}
