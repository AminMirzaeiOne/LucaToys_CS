namespace LucaToys.Pages
{
    partial class ForgetPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPage));
            this.button1 = new System.Windows.Forms.Button();
            this.ltTextBox1 = new LucaToys.Controls.LTTextBox();
            this.ltTextBox2 = new LucaToys.Controls.LTTextBox();
            this.btnGetLoginInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Violet;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ltTextBox1
            // 
            this.ltTextBox1.BackColor = System.Drawing.Color.White;
            this.ltTextBox1.BorderColor = System.Drawing.Color.Plum;
            this.ltTextBox1.BorderDownColor = System.Drawing.Color.Orchid;
            this.ltTextBox1.BorderHoverColor = System.Drawing.Color.Violet;
            this.ltTextBox1.BorderSize = ((byte)(2));
            this.ltTextBox1.EnableClearButton = true;
            this.ltTextBox1.FontOptions = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltTextBox1.HolderTextColor = System.Drawing.Color.Gray;
            this.ltTextBox1.HolderTextContent = "Enter Phone";
            this.ltTextBox1.HolderTextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resources.ApplyResources(this.ltTextBox1, "ltTextBox1");
            this.ltTextBox1.Name = "ltTextBox1";
            // 
            // ltTextBox2
            // 
            this.ltTextBox2.BackColor = System.Drawing.Color.White;
            this.ltTextBox2.BorderColor = System.Drawing.Color.Plum;
            this.ltTextBox2.BorderDownColor = System.Drawing.Color.Orchid;
            this.ltTextBox2.BorderHoverColor = System.Drawing.Color.Violet;
            this.ltTextBox2.BorderSize = ((byte)(2));
            this.ltTextBox2.EnableClearButton = true;
            this.ltTextBox2.FontOptions = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltTextBox2.HolderTextColor = System.Drawing.Color.Gray;
            this.ltTextBox2.HolderTextContent = "Enter Email";
            this.ltTextBox2.HolderTextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resources.ApplyResources(this.ltTextBox2, "ltTextBox2");
            this.ltTextBox2.Name = "ltTextBox2";
            // 
            // btnGetLoginInfo
            // 
            this.btnGetLoginInfo.BackColor = System.Drawing.Color.Plum;
            this.btnGetLoginInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGetLoginInfo.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnGetLoginInfo.FlatAppearance.BorderSize = 2;
            this.btnGetLoginInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnGetLoginInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            resources.ApplyResources(this.btnGetLoginInfo, "btnGetLoginInfo");
            this.btnGetLoginInfo.ForeColor = System.Drawing.Color.White;
            this.btnGetLoginInfo.Image = global::LucaToys.Properties.Resources.icons8_get_38;
            this.btnGetLoginInfo.Name = "btnGetLoginInfo";
            this.btnGetLoginInfo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LucaToys.Properties.Resources.icons8_admin_settings_male_96;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ForgetPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetLoginInfo);
            this.Controls.Add(this.ltTextBox2);
            this.Controls.Add(this.ltTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ForgetPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetLoginInfo;
        private Controls.LTTextBox ltTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.LTTextBox ltTextBox2;
    }
}
