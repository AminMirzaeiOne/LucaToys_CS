using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Submenus
{
    public partial class ProductsSubmenu : UserControl
    {
        public ProductsSubmenu()
        {
            InitializeComponent();
        }

        public ProductsSubmenu(Control parent)
        {
            InitializeComponent();
            xTool = new XDropDown.XToolStripDropDown(this);
            this.ParentControl = parent;
            this.ParentControl.MouseDown += new MouseEventHandler(this.Parent_MouseDown);
        }
        private System.Windows.Forms.Control ParentControl;
        XDropDown.XToolStripDropDown xTool;

        public void ShowSubmenu(Control parent)
        {
            this.xTool.Show(parent);
        }

        private void Parent_MouseDown(object sender, MouseEventArgs e)
        {
            this.ShowSubmenu(this.ParentControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.AddProduct addProduct = new Forms.AddProduct();
            addProduct.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.DeleteDoll deleteDoll = new Forms.DeleteDoll();
            deleteDoll.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LucaToys.Forms.UpdateDoll updateDoll = new Forms.UpdateDoll();
            updateDoll.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.AddProduct addProduct = new Forms.AddProduct();
            addProduct.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.DeleteToy deleteToy = new Forms.DeleteToy();
            deleteToy.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.UpdateToy updateToy = new Forms.UpdateToy();
            updateToy.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.AddProduct addProduct = new Forms.AddProduct();
            addProduct.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.DeleteOther deleteOther = new Forms.DeleteOther();
            deleteOther.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LucaToys.Forms.UpdateOther updateOther = new Forms.UpdateOther();
            updateOther.Show();
        }
    }
}
