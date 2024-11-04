﻿namespace LucaToys.Pages
{
    partial class Workspace
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioSpotify = new System.Windows.Forms.RadioButton();
            this.radioWhatsapp = new System.Windows.Forms.RadioButton();
            this.radioTelegram = new System.Windows.Forms.RadioButton();
            this.radioInstagram = new System.Windows.Forms.RadioButton();
            this.radioGoogle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ltComboBox1 = new LucaToys.Controls.LTComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.radioSpotify);
            this.panel1.Controls.Add(this.radioWhatsapp);
            this.panel1.Controls.Add(this.radioTelegram);
            this.panel1.Controls.Add(this.radioInstagram);
            this.panel1.Controls.Add(this.radioGoogle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1244, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 460);
            this.panel1.TabIndex = 0;
            // 
            // radioSpotify
            // 
            this.radioSpotify.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSpotify.BackColor = System.Drawing.Color.Transparent;
            this.radioSpotify.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.radioSpotify.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum;
            this.radioSpotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioSpotify.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSpotify.ForeColor = System.Drawing.Color.White;
            this.radioSpotify.Image = global::LucaToys.Properties.Resources.icons8_spotify_48;
            this.radioSpotify.Location = new System.Drawing.Point(9, 350);
            this.radioSpotify.Name = "radioSpotify";
            this.radioSpotify.Size = new System.Drawing.Size(82, 69);
            this.radioSpotify.TabIndex = 48;
            this.radioSpotify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioSpotify.UseVisualStyleBackColor = false;
            this.radioSpotify.CheckedChanged += new System.EventHandler(this.radioSpotify_CheckedChanged);
            // 
            // radioWhatsapp
            // 
            this.radioWhatsapp.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioWhatsapp.BackColor = System.Drawing.Color.Transparent;
            this.radioWhatsapp.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.radioWhatsapp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum;
            this.radioWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioWhatsapp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWhatsapp.ForeColor = System.Drawing.Color.White;
            this.radioWhatsapp.Image = global::LucaToys.Properties.Resources.icons8_whatsapp_48;
            this.radioWhatsapp.Location = new System.Drawing.Point(9, 266);
            this.radioWhatsapp.Name = "radioWhatsapp";
            this.radioWhatsapp.Size = new System.Drawing.Size(82, 69);
            this.radioWhatsapp.TabIndex = 48;
            this.radioWhatsapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioWhatsapp.UseVisualStyleBackColor = false;
            this.radioWhatsapp.CheckedChanged += new System.EventHandler(this.radioWhatsapp_CheckedChanged);
            // 
            // radioTelegram
            // 
            this.radioTelegram.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTelegram.BackColor = System.Drawing.Color.Transparent;
            this.radioTelegram.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.radioTelegram.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum;
            this.radioTelegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTelegram.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTelegram.ForeColor = System.Drawing.Color.White;
            this.radioTelegram.Image = global::LucaToys.Properties.Resources.icons8_telegram_app_48;
            this.radioTelegram.Location = new System.Drawing.Point(9, 181);
            this.radioTelegram.Name = "radioTelegram";
            this.radioTelegram.Size = new System.Drawing.Size(82, 69);
            this.radioTelegram.TabIndex = 48;
            this.radioTelegram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioTelegram.UseVisualStyleBackColor = false;
            this.radioTelegram.CheckedChanged += new System.EventHandler(this.radioTelegram_CheckedChanged);
            // 
            // radioInstagram
            // 
            this.radioInstagram.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioInstagram.BackColor = System.Drawing.Color.Transparent;
            this.radioInstagram.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.radioInstagram.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum;
            this.radioInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioInstagram.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInstagram.ForeColor = System.Drawing.Color.White;
            this.radioInstagram.Image = global::LucaToys.Properties.Resources.icons8_instagram_old_48;
            this.radioInstagram.Location = new System.Drawing.Point(9, 97);
            this.radioInstagram.Name = "radioInstagram";
            this.radioInstagram.Size = new System.Drawing.Size(82, 69);
            this.radioInstagram.TabIndex = 48;
            this.radioInstagram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioInstagram.UseVisualStyleBackColor = false;
            this.radioInstagram.CheckedChanged += new System.EventHandler(this.radioInstagram_CheckedChanged);
            // 
            // radioGoogle
            // 
            this.radioGoogle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioGoogle.BackColor = System.Drawing.Color.Transparent;
            this.radioGoogle.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.radioGoogle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum;
            this.radioGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioGoogle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGoogle.ForeColor = System.Drawing.Color.White;
            this.radioGoogle.Image = global::LucaToys.Properties.Resources.icons8_google_48__1_;
            this.radioGoogle.Location = new System.Drawing.Point(9, 12);
            this.radioGoogle.Name = "radioGoogle";
            this.radioGoogle.Size = new System.Drawing.Size(82, 69);
            this.radioGoogle.TabIndex = 47;
            this.radioGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioGoogle.UseVisualStyleBackColor = false;
            this.radioGoogle.CheckedChanged += new System.EventHandler(this.radioGoogle_CheckedChanged);
            this.radioGoogle.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1241, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 460);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Plum;
            this.label4.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(830, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(3, 460);
            this.label4.TabIndex = 8;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label4_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chromiumWebBrowser1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(833, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 460);
            this.panel2.TabIndex = 9;
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 50);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(408, 410);
            this.chromiumWebBrowser1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel3.Controls.Add(this.ltComboBox1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 50);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Plum;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(10, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 39);
            this.button2.TabIndex = 48;
            this.button2.Text = "";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(58, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 39);
            this.button1.TabIndex = 48;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Plum;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(106, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 39);
            this.button3.TabIndex = 49;
            this.button3.Text = "";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ltComboBox1
            // 
            this.ltComboBox1.BorderColor = System.Drawing.Color.Plum;
            this.ltComboBox1.Content = "App";
            this.ltComboBox1.Icon = null;
            this.ltComboBox1.IconY = ((byte)(10));
            this.ltComboBox1.ImageList = null;
            this.ltComboBox1.ImageStyle = false;
            this.ltComboBox1.Items = new string[] {
        "Google",
        "Instagram",
        "Telegram",
        "Whatsapp",
        "Spotify"};
            this.ltComboBox1.ItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ltComboBox1.ItemsCheckedColor = System.Drawing.Color.Plum;
            this.ltComboBox1.ItemsFont = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ltComboBox1.ItemsForeColor = System.Drawing.Color.White;
            this.ltComboBox1.ItemsHeight = ((byte)(40));
            this.ltComboBox1.Location = new System.Drawing.Point(156, 5);
            this.ltComboBox1.Name = "ltComboBox1";
            this.ltComboBox1.Size = new System.Drawing.Size(246, 39);
            this.ltComboBox1.TabIndex = 50;
            this.ltComboBox1.TopDirection = false;
            // 
            // Workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Workspace";
            this.Size = new System.Drawing.Size(1344, 460);
            this.Load += new System.EventHandler(this.Workspace_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioGoogle;
        private System.Windows.Forms.RadioButton radioInstagram;
        private System.Windows.Forms.RadioButton radioTelegram;
        private System.Windows.Forms.RadioButton radioWhatsapp;
        private System.Windows.Forms.RadioButton radioSpotify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private Controls.LTComboBox ltComboBox1;
    }
}
