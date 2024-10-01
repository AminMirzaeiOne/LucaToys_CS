using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucaToys.Controls
{
    public class LTButton : System.Windows.Forms.Button
    {
        [Category("Symbol")]
        public System.String SymbolIcon { get; set; } = "";
        public System.Drawing.Color SymbolColor { get; set; } = Color.Plum;
        public System.Drawing.Color SymbolHoverColor { get; set; } = Color.White;
        public System.Byte SymbolSize { get; set; } = 9;
    }
}
