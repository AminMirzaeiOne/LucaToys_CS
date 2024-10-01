namespace LucaToys.Pages
{
    partial class DeveloperPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloperPage));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::LucaToys.Properties.Resources.icons8_instagram_48__1_;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::LucaToys.Properties.Resources.icons8_github_48__1_;
            this.label1.Name = "label1";
            // 
            // lblChannel
            // 
            resources.ApplyResources(this.lblChannel, "lblChannel");
            this.lblChannel.BackColor = System.Drawing.Color.Plum;
            this.lblChannel.ForeColor = System.Drawing.Color.White;
            this.lblChannel.Image = global::LucaToys.Properties.Resources.icons8_name_48;
            this.lblChannel.Name = "lblChannel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::LucaToys.Properties.Resources.NewProfile;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // DeveloperPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DeveloperPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
