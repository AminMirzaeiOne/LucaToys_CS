namespace LucaToys.Pages
{
    partial class FeedbackPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackPage));
            this.btnSend = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ltRadioButton2 = new LucaToys.Controls.LTRadioButton();
            this.ltRadioButton1 = new LucaToys.Controls.LTRadioButton();
            this.ltTextBox2 = new LucaToys.Controls.LTTextBox();
            this.ltTextBox1 = new LucaToys.Controls.LTTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Plum;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnSend.FlatAppearance.BorderSize = 2;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = global::LucaToys.Properties.Resources.icons8_send_28;
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LucaToys.Properties.Resources.icons8_page_48;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LucaToys.Properties.Resources.icons8_title_48;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ltRadioButton2
            // 
            resources.ApplyResources(this.ltRadioButton2, "ltRadioButton2");
            this.ltRadioButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ltRadioButton2.CheckedColor = System.Drawing.Color.Violet;
            this.ltRadioButton2.ForeColor = System.Drawing.Color.Black;
            this.ltRadioButton2.Name = "ltRadioButton2";
            this.ltRadioButton2.UnCheckedColor = System.Drawing.Color.Gray;
            this.ltRadioButton2.UseVisualStyleBackColor = false;
            // 
            // ltRadioButton1
            // 
            resources.ApplyResources(this.ltRadioButton1, "ltRadioButton1");
            this.ltRadioButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ltRadioButton1.Checked = true;
            this.ltRadioButton1.CheckedColor = System.Drawing.Color.Violet;
            this.ltRadioButton1.ForeColor = System.Drawing.Color.Black;
            this.ltRadioButton1.Name = "ltRadioButton1";
            this.ltRadioButton1.TabStop = true;
            this.ltRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.ltRadioButton1.UseVisualStyleBackColor = false;
            // 
            // ltTextBox2
            // 
            this.ltTextBox2.BackColor = System.Drawing.Color.White;
            this.ltTextBox2.BorderColor = System.Drawing.Color.Plum;
            this.ltTextBox2.BorderDownColor = System.Drawing.Color.Orchid;
            this.ltTextBox2.BorderHoverColor = System.Drawing.Color.Violet;
            this.ltTextBox2.BorderSize = ((byte)(2));
            this.ltTextBox2.EnableClearButton = false;
            this.ltTextBox2.FontOptions = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltTextBox2.HolderTextColor = System.Drawing.Color.Gray;
            this.ltTextBox2.HolderTextContent = "Enter Feedback Text";
            this.ltTextBox2.HolderTextFont = new System.Drawing.Font("Segoe UI", 11F);
            resources.ApplyResources(this.ltTextBox2, "ltTextBox2");
            this.ltTextBox2.Name = "ltTextBox2";
            // 
            // ltTextBox1
            // 
            this.ltTextBox1.BackColor = System.Drawing.Color.White;
            this.ltTextBox1.BorderColor = System.Drawing.Color.Plum;
            this.ltTextBox1.BorderDownColor = System.Drawing.Color.Orchid;
            this.ltTextBox1.BorderHoverColor = System.Drawing.Color.Violet;
            this.ltTextBox1.BorderSize = ((byte)(2));
            this.ltTextBox1.EnableClearButton = true;
            this.ltTextBox1.FontOptions = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltTextBox1.HolderTextColor = System.Drawing.Color.Gray;
            this.ltTextBox1.HolderTextContent = "Enter Subject";
            this.ltTextBox1.HolderTextFont = new System.Drawing.Font("Segoe UI", 11F);
            resources.ApplyResources(this.ltTextBox1, "ltTextBox1");
            this.ltTextBox1.Name = "ltTextBox1";
            // 
            // FeedbackPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ltRadioButton2);
            this.Controls.Add(this.ltRadioButton1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ltTextBox2);
            this.Controls.Add(this.ltTextBox1);
            this.Name = "FeedbackPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.LTTextBox ltTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.LTTextBox ltTextBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSend;
        private Controls.LTRadioButton ltRadioButton1;
        private Controls.LTRadioButton ltRadioButton2;
    }
}
