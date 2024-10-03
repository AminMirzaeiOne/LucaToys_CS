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
    public class LTCheckBox : System.Windows.Forms.CheckBox
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


        [Category("Appearance")]
        public System.Drawing.Color CheckedColor { get; set; } = Color.White;


        [Category("Appearance")]
        public System.Drawing.Color CheckedBorderColor { get; set; } = Color.Plum;

        [Category("Appearance")]
        public System.Drawing.Color BackgroundColor { get; set; } = Color.White;

        [Category("Appearance")]
        public System.Drawing.Color CheckedBackColor { get; set; } = Color.Plum;

        // ------------------------------------------------------------------------
        // Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            // Have to call this when handling stacked controls or will get strange artifacts
            // (Clipping and background setup)
            base.OnPaint(e);

            // Fill in the background
            if (BackColor != Color.Transparent)
                e.Graphics.Clear(BackColor);

            // The checkbox will be the full height of the space and the same width (or as wide as possible), the thickness will be proportional to the 
            // scaled-up size (unless ExpandThickness is false, in which case box will always be one pixel).
            int boxThickness = ExpandBorderThickness ? Math.Max(1, Height / 13) : 1;
            Rectangle checkRect = new Rectangle(boxThickness - 1, boxThickness - 1, Math.Min(Height, Width) - boxThickness - boxThickness, Height - boxThickness - boxThickness);

            // Draw the inside of the check. We do this first so that the checkbox can just sit on top and we can avoid worrying
            // about the thickness
            Color interiorColor = Color.Black;
            if (!this.Checked)
                interiorColor = this.BackgroundColor;
            else
                interiorColor = this.CheckedBackColor;
            Rectangle interiorRect = new Rectangle(checkRect.Left + boxThickness - 1, checkRect.Top + boxThickness - 1, checkRect.Width - boxThickness - boxThickness + 2, checkRect.Height - boxThickness - boxThickness + 2);
            using (Brush interiorBrush = new SolidBrush(interiorColor))
            {
                e.Graphics.FillRectangle(interiorBrush, checkRect);
            }

            // Will draw the box in the highlight color if mouse over or if we have focus
            Color boxColor = this.CheckedBorderColor;
            using (Pen boxPen = new Pen(boxColor, boxThickness))
            {
                e.Graphics.DrawRectangle(boxPen, checkRect);
            }


            // Draw the checkmark if appropriate
            if (Checked)
            {
                // Scale the line thickness based on the size of the box
                float thickness = (float)interiorRect.Width / 11f;
                Color checkColor = this.CheckedColor;
                using (Pen boxPen = new Pen(checkColor, thickness))
                {
                    float tailStartX = (float)interiorRect.Left + (float)interiorRect.Width * 2f / 11f;
                    float tailStartY = (float)interiorRect.Top + (float)interiorRect.Height / 2f;
                    float tailEndX = (float)interiorRect.Left + (float)interiorRect.Width * 4f / 11f;
                    float tailEndY = (float)interiorRect.Bottom - (float)interiorRect.Height * 3f / 11f;
                    float mainEndX = (float)interiorRect.Right - (float)interiorRect.Width * 2f / 11f;
                    float mainEndY = (float)interiorRect.Top + (float)interiorRect.Height * 3f / 11f;

                    // As the shape gets bigger, the thickness of the pen will cause a gap at the bottom of the check.
                    // This figures out the angle of the tale (relative to the X axis) so that we can extend the line
                    // the extra little bit required to fill in the gap
                    double angle = Math.Atan2(tailEndY - tailStartY, tailEndX - tailStartX) * 180 / Math.PI;

                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawLine(boxPen, tailStartX, tailStartY, tailEndX + (float)Math.Sin(angle) * thickness / 2, tailEndY + (float)Math.Cos(angle) * thickness / 2);
                    //e.Graphics.DrawLine(boxPen, tailStartX, tailStartY, tailEndX, tailEndY);
                    e.Graphics.DrawLine(boxPen, tailEndX, tailEndY, mainEndX, mainEndY);
                }
            }

            // Draw Text
            if (!string.IsNullOrEmpty(Text))
            {
                Color textColor = Enabled ? ForeColor : SystemColors.ControlDark;
                StringFormat format = new StringFormat(StringFormatFlags.NoWrap)
                {
                    Alignment = GetHorStringAlignFromContentAlignment(this.TextAlign),
                    LineAlignment = GetVerStringAlignFromContentAlignment(this.TextAlign),
                    Trimming = AutoEllipsis ? StringTrimming.EllipsisCharacter : StringTrimming.None
                };

                Rectangle textRect = new Rectangle(checkRect.Right + boxThickness + 2, 0, this.Width - checkRect.Right - boxThickness - 2, this.Height);
                //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                using (Brush textBrush = new SolidBrush(textColor))
                {
                    e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    e.Graphics.DrawString(Text, Font, textBrush, textRect, format);
                }
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs eventargs)
        {
            base.OnMouseEnter(eventargs);
            _mouseOver = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs eventargs)
        {
            base.OnMouseLeave(eventargs);
            _mouseOver = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _mouseDown = true;
            Capture = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _mouseDown = false;
            Capture = false;
            Invalidate();
        }

        public static StringAlignment GetHorStringAlignFromContentAlignment(ContentAlignment textAlign)
        {
            StringAlignment result = StringAlignment.Near;
            switch (textAlign)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.BottomLeft:
                    result = StringAlignment.Near;
                    break;

                case ContentAlignment.TopCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.BottomCenter:
                    result = StringAlignment.Center;
                    break;

                case ContentAlignment.TopRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.BottomRight:
                    result = StringAlignment.Far;
                    break;
            }

            return result;
        }

        public static StringAlignment GetVerStringAlignFromContentAlignment(ContentAlignment textAlign)
        {
            StringAlignment result = StringAlignment.Center;
            switch (textAlign)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopCenter:
                case ContentAlignment.TopRight:
                    result = StringAlignment.Near;
                    break;

                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleRight:
                    result = StringAlignment.Center;
                    break;

                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomRight:
                    result = StringAlignment.Far;
                    break;
            }

            return result;
        }



    }
}
