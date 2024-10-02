using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucaToys.Controls
{
    public class LTTextBox : System.Windows.Forms.TextBox
    {
        [Category("Border Appearance")]
        public System.Byte BorderSize { get; set; } = 2;

        [Category("Border Appearance")]
        public System.Drawing.Color BorderColor { get; set; } = System.Drawing.Color.Plum;
        
        [Category("Border Appearance")]
        public System.Drawing.Color BorderHoverColor { get; set; } = System.Drawing.Color.Violet;

        [Category("Border Appearance")]
        public System.Drawing.Color BorderDownColor { get; set; } = System.Drawing.Color.Orchid;
    }
}
