using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToys.Controls
{
    public class LTCheckBox:System.Windows.Forms.CheckBox
    {
        // Fields

        // TODO: Should create a temporary checkbox to read proper system color. Color is <i>probably</i> calculated based on another color.
        private static Color _mouseDownBackground = Color.FromArgb(204, 228, 247);

        private bool _mouseOver = false;
        private bool _mouseDown = false;
        private bool _expandBorderThickness = false;

        // Construction/Initialization

        /// Constructor</summary>
        public LTCheckBox()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        // ------------------------------------------------------------------------
    }
}
