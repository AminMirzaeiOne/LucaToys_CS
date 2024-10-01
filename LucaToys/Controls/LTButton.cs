using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Controls
{
    public class LTButton : System.Windows.Forms.Button
    {
        [Category("Symbol")]
        public System.String SymbolIcon { get; set; } = "";
        [Category("Symbol")]

        public System.Drawing.Color SymbolColor { get; set; } = Color.Plum;
        [Category("Symbol")]

        public System.Drawing.Color SymbolHoverColor { get; set; } = Color.White;
        [Category("Symbol")]

        public System.Byte SymbolSize { get; set; } = 9;
        [Category("Symbol")]

        public FontStyle SymbolStyle { get; set; } = FontStyle.Regular;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;

            pevent.Graphics.DrawString(this.SymbolIcon, new Font("Segoe MDL2 Assets", this.SymbolSize, this.SymbolStyle), new SolidBrush(this.SymbolColor), pevent.ClipRectangle, sf);


        }
    }
}
