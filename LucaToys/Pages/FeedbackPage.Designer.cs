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
            this.ltTextBox1 = new LucaToys.Controls.LTTextBox();
            this.ltTextBox2 = new LucaToys.Controls.LTTextBox();
            this.SuspendLayout();
            // 
            // ltTextBox1
            // 
            this.ltTextBox1.BackColor = System.Drawing.Color.White;
            this.ltTextBox1.BorderColor = System.Drawing.Color.Plum;
            this.ltTextBox1.BorderDownColor = System.Drawing.Color.Orchid;
            this.ltTextBox1.BorderHoverColor = System.Drawing.Color.Violet;
            this.ltTextBox1.BorderSize = ((byte)(2));
            this.ltTextBox1.EnableClearButton = false;
            this.ltTextBox1.HolderTextColor = System.Drawing.Color.Gray;
            this.ltTextBox1.HolderTextContent = "Enter Text";
            this.ltTextBox1.HolderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.ltTextBox1.Location = new System.Drawing.Point(39, 28);
            this.ltTextBox1.Name = "ltTextBox1";
            this.ltTextBox1.Size = new System.Drawing.Size(401, 40);
            this.ltTextBox1.TabIndex = 2;
            // 
            // ltTextBox2
            // 
            this.ltTextBox2.BackColor = System.Drawing.Color.White;
            this.ltTextBox2.BorderColor = System.Drawing.Color.Plum;
            this.ltTextBox2.BorderDownColor = System.Drawing.Color.Orchid;
            this.ltTextBox2.BorderHoverColor = System.Drawing.Color.Violet;
            this.ltTextBox2.BorderSize = ((byte)(2));
            this.ltTextBox2.EnableClearButton = false;
            this.ltTextBox2.HolderTextColor = System.Drawing.Color.Gray;
            this.ltTextBox2.HolderTextContent = "Enter Text";
            this.ltTextBox2.HolderTextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.ltTextBox2.Location = new System.Drawing.Point(83, 105);
            this.ltTextBox2.Name = "ltTextBox2";
            this.ltTextBox2.Size = new System.Drawing.Size(250, 86);
            this.ltTextBox2.TabIndex = 3;
            // 
            // FeedbackPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.ltTextBox2);
            this.Controls.Add(this.ltTextBox1);
            this.Name = "FeedbackPage";
            this.Size = new System.Drawing.Size(494, 490);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.LTTextBox ltTextBox1;
        private Controls.LTTextBox ltTextBox2;
    }
}
