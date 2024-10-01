using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Pages
{
    public partial class VersionPage : UserControl
    {
        public VersionPage()
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++)
            {
                this.Controls.Clear();
                InitializeComponent();
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa");
            }
        }
    }
}
