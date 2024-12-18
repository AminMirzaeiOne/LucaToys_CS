﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.CSS;

namespace LucaToys.Controls
{
    public partial class LTComboBox : UserControl
    {
        public LTComboBox()
        {
            InitializeComponent();

            border.ColumnCount = 1;
            border.RowCount = 1;
            border.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.BackColor = Color.FromArgb(20, 20, 20);
            panel.Margin = new Padding(2);

            xDrop = new XDropDown.XToolStripDropDown(border);
        }

        TableLayoutPanel border = new TableLayoutPanel();
        Panel panel = new Panel();
        private XDropDown.XToolStripDropDown xDrop;
        private System.Int32 height = 0;
        private System.Byte itemsHeight = 40;
        private System.Drawing.Color itemsCheckedColor = Color.Plum;
        private System.Drawing.Color itemsForeColor = Color.White;
        private System.Drawing.Color itemsBackColor = Color.FromArgb(20, 20, 20);
        private System.Drawing.Font itemsFont = new Font("Segoe UI Semibold", 9, FontStyle.Regular);
        private System.Boolean imageStyle = false;
        private System.Boolean topDirection = false;
        private System.String arrow = "";
        public List<RadioButton> RadioItems = new List<RadioButton>();

        public System.Boolean TopDirection
        {
            get { return this.topDirection; }
            set 
            { 
                this.topDirection = value;
                if (value)
                    this.arrow = "";
                else
                    this.arrow = "";
            }
        }

        public System.Boolean ImageStyle
        {
            get { return this.imageStyle; }
            set
            {
                this.imageStyle = value;
            }
        }

        public System.Windows.Forms.ImageList ImageList { get; set; }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                this.button6.BackColor = value;
            }
        }

        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                this.button6.Font = value;
            }
        }

        public System.Drawing.Color BorderColor
        {
            get { return this.tableLayoutPanel1.BackColor; }
            set
            {
                this.tableLayoutPanel1.BackColor = value;
                this.border.BackColor = value;
                this.button6.FlatAppearance.BorderColor = value;
            }
        }

        public System.Byte ItemsHeight
        {
            get { return this.itemsHeight; }
            set
            {
                this.itemsHeight = value;
                if (this.RadioItems != null)
                {
                    foreach (RadioButton item in this.RadioItems)
                    {
                        item.Height = value;
                    }
                }

            }
        }

        public System.Drawing.Font ItemsFont
        {
            get { return this.itemsFont; }
            set
            {
                this.itemsFont = value;
                if (this.RadioItems != null)
                {
                    foreach (RadioButton item in this.RadioItems)
                    {
                        item.Font = value;
                    }
                }

            }
        }

        public System.Drawing.Color ItemsCheckedColor
        {
            get { return this.itemsCheckedColor; }
            set
            {
                this.itemsCheckedColor = value;
                if (this.RadioItems != null)
                {
                    foreach (RadioButton item in this.RadioItems)
                    {
                        item.FlatAppearance.CheckedBackColor = value;
                    }
                }

            }
        }

        public System.Drawing.Color ItemsForeColor
        {
            get { return this.itemsForeColor; }
            set
            {
                this.itemsForeColor = value;
                if (this.RadioItems != null)
                {
                    foreach (RadioButton item in this.RadioItems)
                    {
                        item.ForeColor = value;
                    }
                }

            }
        }

        public System.Drawing.Color ItemsBackColor
        {
            get { return this.itemsBackColor; }
            set
            {
                this.itemsBackColor = value;
                if (this.RadioItems != null)
                {
                    foreach (RadioButton item in this.RadioItems)
                    {
                        item.BackColor = value;
                    }
                }

            }
        }



        public System.Drawing.Image Icon { get; set; }

        public System.Byte IconY { get; set; } = 10;

        public System.String Content
        {
            get { return this.button6.Text; }
            set
            {
                this.button6.Text = value;
            }
        }


        public event EventHandler<EventArgs> SelectedItemChanged;

        private List<string> _items = new List<string>();
        public string[] Items
        {
            get { return _items.ToArray(); }
            set
            {
                _items = value.ToList();
                OnItemsChanged();
            }
        }

        private void OnItemsChanged()
        {
            panel.Controls.Clear();
            if (this.RadioItems != null)
            {
                this.RadioItems.Clear();
            }
            foreach (string item in Items)
            {
                RadioButton rb = new RadioButton();
                rb.Text = item;
                rb.AutoSize = false;
                rb.FlatStyle = FlatStyle.Flat;
                rb.Appearance = Appearance.Button;
                rb.Dock = DockStyle.Top;
                rb.FlatAppearance.BorderSize = 0;
                rb.FlatAppearance.CheckedBackColor = Color.Plum;
                rb.ForeColor = Color.White;
                rb.CheckedChanged += Rb_CheckedChanged;
                this.RadioItems.Add(rb);
                panel.Controls.Add(rb);
                rb.BringToFront();
            }
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                SelectedItemChanged?.Invoke(rb, EventArgs.Empty);
                this.Content = rb.Text;
            }
        }


        private void button6_Paint(object sender, PaintEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(this.arrow, new Font("Segoe MDL2 Assets", 9, FontStyle.Bold), new SolidBrush(this.button6.ForeColor), new Point(e.ClipRectangle.Width - 10, e.ClipRectangle.Height / 2 + 2), sf);
            Rectangle rectangle = new Rectangle(0, this.IconY, 26, 26);
            if (this.Icon != null)
                e.Graphics.DrawImage(this.Icon, rectangle);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.height == 0)
            {
                foreach (RadioButton radio in this.RadioItems)
                {
                    this.height += radio.Size.Height;
                }
            }

            this.border.Size = new Size(this.Width, height + 4);

            if (!this.TopDirection)
                xDrop.Show(this);
            else
                xDrop.Show(this, new Point(0,0-this.border.Bottom));

            if (this.RadioItems != null)
            {
                if (this.ImageStyle)
                {
                    foreach (RadioButton radio in this.RadioItems)
                    {
                        radio.TextImageRelation = TextImageRelation.ImageBeforeText;
                        radio.TextAlign = ContentAlignment.MiddleLeft;
                        radio.ImageAlign = ContentAlignment.MiddleLeft;
                    }
                }
                else
                {
                    foreach (RadioButton radio in this.RadioItems)
                    {
                        radio.TextImageRelation = TextImageRelation.Overlay;
                        radio.TextAlign = ContentAlignment.MiddleLeft;
                        radio.ImageAlign = ContentAlignment.MiddleLeft;
                    }
                }

                if (this.RadioItems != null && this.ImageList != null)
                {
                    for (int i = 0; i < this.RadioItems.Count; i++)
                    {
                        this.RadioItems[i].Image = this.ImageList.Images[i];
                    }
                }



                foreach (RadioButton radio in this.RadioItems)
                {
                    radio.Padding = new Padding(2, 0, 0, 0);
                }
            }



        }
    }
}
