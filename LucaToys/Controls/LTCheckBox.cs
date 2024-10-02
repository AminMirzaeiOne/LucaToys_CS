using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        // Properties


        /// <summary>If true, the outer border will expand relative to the size of the checkbox. Otherwise it will be a single pixel wide.</summary>
        [Browsable(true)]
        [Category("Appearance")]
        [Description("If true, the outer border will expand relative to the size of the checkbox. Otherwise it will be a single pixel wide.")]
        public bool ExpandBorderThickness
        {
            get { return _expandBorderThickness; }
            set { _expandBorderThickness = value; Invalidate(); }
        }

        /// <summary>This is done to hide focus rectangle</summary>
        /// <remarks>The checkbox will be blue if it has focus, and the dashed-line looks ugly</remarks>
        protected override bool ShowFocusCues
        {
            get { return false; }
        }

        // ------------------------------------------------------------------------
        // Methods



    }
}
