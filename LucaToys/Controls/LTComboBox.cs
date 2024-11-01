using System;
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

namespace LucaToys.Controls
{
    public partial class LTComboBox : UserControl
    {
        public LTComboBox()
        {
            InitializeComponent();

            border.ColumnCount = 1;
            border.RowCount = 1;
            border.BackColor = System.Drawing.Color.Plum;
            border.Size = new Size(this.Size.Width, 600);
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

        public System.Drawing.Image Icon { get; set; } = null;


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
            foreach (string item in Items)
            {
                RadioButton rb = new RadioButton();
                rb.Text = item;
                rb.AutoSize = false;
                rb.FlatStyle = FlatStyle.Flat;
                rb.Appearance = Appearance.Button;
                rb.Height = 40;
                rb.Dock = DockStyle.Top;
                rb.FlatAppearance.BorderSize = 0;
                rb.FlatAppearance.CheckedBackColor = Color.Plum;
                rb.ForeColor = Color.White;
                rb.CheckedChanged += Rb_CheckedChanged;
                this.height += rb.Size.Height;
                panel.Controls.Add(rb);
            }
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                SelectedItemChanged?.Invoke(this, EventArgs.Empty);
            }
        }


        private void button6_Paint(object sender, PaintEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("", new Font("Segoe MDL2 Assets", 9, FontStyle.Bold), new SolidBrush(this.button6.ForeColor), new Point(e.ClipRectangle.Width - 10, e.ClipRectangle.Height / 2 + 2), sf);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.border.Size = new Size(this.Width,height);
            xDrop.Show(this);
            
        }
    }
}
