using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Forms
{
    public partial class Translate : Form
    {
        public Translate()
        {
            InitializeComponent();
            this.ltComboBox1.RadioItems[0].Image = imageList1.Images[0];
            //this.ltComboBox1.RadioItems[0].ImageAlign = ContentAlignment.MiddleLeft;
            //this.ltComboBox1.RadioItems[0].TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void ltComboBox1_SelectedItemChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((RadioButton)sender).Image;
        }
    }
}
