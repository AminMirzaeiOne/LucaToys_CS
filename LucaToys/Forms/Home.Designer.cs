namespace LucaToys.Forms
{
    partial class Home
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcPower1 = new LucaToys.Widgets.PCPower();
            this.currency1 = new LucaToys.Widgets.Currency();
            this.puzzleGame1 = new LucaToys.Widgets.PuzzleGame();
            this.hardwareInfo1 = new LucaToys.Widgets.HardwareInfo();
            this.weather1 = new LucaToys.Widgets.Weather();
            this.calender1 = new LucaToys.Widgets.Calender();
            this.digitalClock1 = new LucaToys.Widgets.DigitalClock();
            this.miniCalculator1 = new LucaToys.Widgets.MiniCalculator();
            this.analogClock1 = new LucaToys.Widgets.AnalogClock();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.homeStatus1 = new LucaToys.Menus.HomeStatus();
            this.label2 = new System.Windows.Forms.Label();
            this.homeTopMenu1 = new LucaToys.Menus.HomeTopMenu();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ltSmallMenu1 = new LucaToys.Controls.LTSmallMenu();
            this.whiteBoard1 = new LucaToys.Widgets.WhiteBoard();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Plum;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 700);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.homeStatus1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.homeTopMenu1);
            this.panel1.Controls.Add(this.btnControl);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 694);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.whiteBoard1);
            this.panel2.Controls.Add(this.pcPower1);
            this.panel2.Controls.Add(this.currency1);
            this.panel2.Controls.Add(this.puzzleGame1);
            this.panel2.Controls.Add(this.hardwareInfo1);
            this.panel2.Controls.Add(this.weather1);
            this.panel2.Controls.Add(this.calender1);
            this.panel2.Controls.Add(this.digitalClock1);
            this.panel2.Controls.Add(this.miniCalculator1);
            this.panel2.Controls.Add(this.analogClock1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 460);
            this.panel2.TabIndex = 28;
            // 
            // pcPower1
            // 
            this.pcPower1.Location = new System.Drawing.Point(885, 174);
            this.pcPower1.Name = "pcPower1";
            this.pcPower1.Size = new System.Drawing.Size(350, 350);
            this.pcPower1.TabIndex = 13;
            // 
            // currency1
            // 
            this.currency1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency1.Location = new System.Drawing.Point(961, 174);
            this.currency1.Name = "currency1";
            this.currency1.Size = new System.Drawing.Size(350, 350);
            this.currency1.TabIndex = 12;
            // 
            // puzzleGame1
            // 
            this.puzzleGame1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puzzleGame1.Location = new System.Drawing.Point(793, 58);
            this.puzzleGame1.Name = "puzzleGame1";
            this.puzzleGame1.Size = new System.Drawing.Size(350, 350);
            this.puzzleGame1.TabIndex = 11;
            // 
            // hardwareInfo1
            // 
            this.hardwareInfo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardwareInfo1.Location = new System.Drawing.Point(779, 218);
            this.hardwareInfo1.Name = "hardwareInfo1";
            this.hardwareInfo1.Size = new System.Drawing.Size(350, 350);
            this.hardwareInfo1.TabIndex = 10;
            // 
            // weather1
            // 
            this.weather1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weather1.Location = new System.Drawing.Point(1212, 69);
            this.weather1.Name = "weather1";
            this.weather1.Size = new System.Drawing.Size(350, 350);
            this.weather1.TabIndex = 9;
            // 
            // calender1
            // 
            this.calender1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calender1.Location = new System.Drawing.Point(842, 122);
            this.calender1.Name = "calender1";
            this.calender1.Size = new System.Drawing.Size(350, 350);
            this.calender1.TabIndex = 8;
            // 
            // digitalClock1
            // 
            this.digitalClock1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalClock1.Location = new System.Drawing.Point(842, 22);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(350, 200);
            this.digitalClock1.TabIndex = 7;
            // 
            // miniCalculator1
            // 
            this.miniCalculator1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniCalculator1.Location = new System.Drawing.Point(410, 22);
            this.miniCalculator1.Name = "miniCalculator1";
            this.miniCalculator1.Size = new System.Drawing.Size(350, 350);
            this.miniCalculator1.TabIndex = 6;
            // 
            // analogClock1
            // 
            this.analogClock1.Location = new System.Drawing.Point(5, 22);
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.Size = new System.Drawing.Size(350, 350);
            this.analogClock1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Plum;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1344, 3);
            this.label4.TabIndex = 4;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Plum;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1344, 3);
            this.label3.TabIndex = 3;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // homeStatus1
            // 
            this.homeStatus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.homeStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.homeStatus1.Location = new System.Drawing.Point(0, 624);
            this.homeStatus1.Name = "homeStatus1";
            this.homeStatus1.Size = new System.Drawing.Size(1344, 70);
            this.homeStatus1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(41, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Home Window";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // homeTopMenu1
            // 
            this.homeTopMenu1.BackColor = System.Drawing.Color.White;
            this.homeTopMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeTopMenu1.Location = new System.Drawing.Point(0, 36);
            this.homeTopMenu1.Name = "homeTopMenu1";
            this.homeTopMenu1.Size = new System.Drawing.Size(1344, 128);
            this.homeTopMenu1.TabIndex = 19;
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.Black;
            this.btnControl.FlatAppearance.BorderSize = 0;
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7F, System.Drawing.FontStyle.Bold);
            this.btnControl.ForeColor = System.Drawing.Color.Plum;
            this.btnControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnControl.Location = new System.Drawing.Point(4, 4);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(25, 25);
            this.btnControl.TabIndex = 16;
            this.btnControl.Text = "";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            this.btnControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe MDL2 Assets", 6F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.Plum;
            this.btnMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMinimize.Location = new System.Drawing.Point(1247, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.Text = "";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Black;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe MDL2 Assets", 6F, System.Drawing.FontStyle.Bold);
            this.btnMaximize.ForeColor = System.Drawing.Color.Plum;
            this.btnMaximize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMaximize.Location = new System.Drawing.Point(1281, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 17;
            this.btnMaximize.Text = "";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 6F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Plum;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(1315, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1344, 36);
            this.label1.TabIndex = 13;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // ltSmallMenu1
            // 
            this.ltSmallMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltSmallMenu1.Control = this.panel2;
            this.ltSmallMenu1.DownBackColor = System.Drawing.Color.Plum;
            this.ltSmallMenu1.DownForeColor = System.Drawing.Color.White;
            this.ltSmallMenu1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ltSmallMenu1.ForeColor = System.Drawing.Color.White;
            this.ltSmallMenu1.HoverForeColor = System.Drawing.Color.Plum;
            this.ltSmallMenu1.LineColor = System.Drawing.Color.Plum;
            this.ltSmallMenu1.SymbolSize = ((byte)(10));
            this.ltSmallMenu1.SymbolWidth = ((byte)(40));
            this.ltSmallMenu1.Width = ((byte)(230));
            // 
            // whiteBoard1
            // 
            this.whiteBoard1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteBoard1.Location = new System.Drawing.Point(793, 122);
            this.whiteBoard1.Name = "whiteBoard1";
            this.whiteBoard1.Size = new System.Drawing.Size(350, 350);
            this.whiteBoard1.TabIndex = 14;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private Menus.HomeTopMenu homeTopMenu1;
        private Controls.LTSmallMenu ltSmallMenu1;
        private System.Windows.Forms.Label label2;
        private Menus.HomeStatus homeStatus1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Widgets.AnalogClock analogClock1;
        private Widgets.MiniCalculator miniCalculator1;
        private Widgets.DigitalClock digitalClock1;
        private Widgets.Calender calender1;
        private Widgets.Weather weather1;
        private Widgets.HardwareInfo hardwareInfo1;
        private Widgets.PuzzleGame puzzleGame1;
        private Widgets.Currency currency1;
        private Widgets.PCPower pcPower1;
        private Widgets.WhiteBoard whiteBoard1;
    }
}