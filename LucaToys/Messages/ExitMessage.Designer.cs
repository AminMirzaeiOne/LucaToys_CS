namespace LucaToys.Messages
{
    partial class ExitMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitMessage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMaxRes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ltSmallMenu1 = new LucaToys.Controls.LTSmallMenu();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnControl);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnMaxRes);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.button1.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Plum;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaxRes
            // 
            this.btnMaxRes.BackColor = System.Drawing.Color.Plum;
            this.btnMaxRes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMaxRes.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnMaxRes.FlatAppearance.BorderSize = 2;
            this.btnMaxRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnMaxRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            resources.ApplyResources(this.btnMaxRes, "btnMaxRes");
            this.btnMaxRes.ForeColor = System.Drawing.Color.White;
            this.btnMaxRes.Name = "btnMaxRes";
            this.btnMaxRes.UseVisualStyleBackColor = false;
            this.btnMaxRes.Click += new System.EventHandler(this.btnMaxRes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LucaToys.Properties.Resources.icons8_open_door_96;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Plum;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.White;
            this.btnControl.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnControl, "btnControl");
            this.btnControl.ForeColor = System.Drawing.Color.Plum;
            this.btnControl.Name = "btnControl";
            this.btnControl.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = System.Drawing.Color.Plum;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ltSmallMenu1
            // 
            this.ltSmallMenu1.BackColor = System.Drawing.Color.White;
            this.ltSmallMenu1.Control = this.label3;
            this.ltSmallMenu1.DownBackColor = System.Drawing.Color.Plum;
            this.ltSmallMenu1.DownForeColor = System.Drawing.Color.White;
            this.ltSmallMenu1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ltSmallMenu1.ForeColor = System.Drawing.Color.Black;
            this.ltSmallMenu1.HoverForeColor = System.Drawing.Color.Plum;
            this.ltSmallMenu1.LineColor = System.Drawing.Color.Plum;
            this.ltSmallMenu1.SymbolSize = ((byte)(10));
            this.ltSmallMenu1.SymbolWidth = ((byte)(40));
            // 
            // ExitMessage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitMessage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMaxRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.LTSmallMenu ltSmallMenu1;
        private System.Windows.Forms.Label label5;
    }
}