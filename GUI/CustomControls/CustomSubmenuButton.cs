using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Button = System.Windows.Forms.Button;
using Point = System.Drawing.Point;

namespace GUI.CustomControls
{
    public class CustomSubmenuButton : Button
    {

       

        #region Private Variabels

        private Color _borderColor = Color.Silver;
        private Color _onButtonUpBorderColor = Color.Gray;
        private Color _buttonColor = Color.Red;
        private Color _onButtonUpColor = Color.Yellow;
        private Color _textColor = Color.White;
        private Color _onButtonUpTextColor = Color.Gray;
        private BtnState btnState = BtnState.Normal;

        #endregion




        public CustomSubmenuButton()
        {
            DoubleBuffered = true;
        }


        #region Paint
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            paint_Background(e);
            paint_Border(e);
            paint_InnerBorder(e);
            paint_FocusBorder(e);



        }
        #endregion

        #region Events
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            btnState = BtnState.Normal;
            this.Invalidate();
            this.Capture = false;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            btnState = BtnState.Normal;
            this.Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.Capture = true;
            btnState = BtnState.Pushed;
            this.Invalidate();
        }

        #endregion


        #region Private Methods

        private bool _FocusRectangleEnabled = true;

        [Browsable(true),
        CategoryAttribute("Appearance"),
        Description("enables the focus rectangle"),
        System.ComponentModel.RefreshProperties(RefreshProperties.Repaint)
        ]
        public bool FocusRectangleEnabled
        {
            get { return _FocusRectangleEnabled; }
            set { _FocusRectangleEnabled = value; }
        }
        private void paint_FocusBorder(PaintEventArgs e)
        {
            if (e == null)
                return;
            if (e.Graphics == null)
                return;
            //
            // if the button has focus, and focus rectangle is enabled,
            // draw the focus box
            //
            if (this.Focused)
            {
                if (FocusRectangleEnabled)
                {
                    ControlPaint.DrawFocusRectangle(e.Graphics, new System.Drawing.Rectangle(3, 3, this.Width - 6, this.Height - 6), System.Drawing.Color.Black, this.BackColor);
                }
            }
        }
        private void paint_Background(PaintEventArgs e)
        {
            if (e == null)
                return;
            if (e.Graphics == null)
                return;

            Graphics g = e.Graphics;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, Size.Width, Size.Height);
            //
            // get color of background
            //			
            System.Drawing.Color color = this.BackColor; ;
            if (btnState == BtnState.Inactive)
                color = System.Drawing.Color.LightGray;
            //
            // intialize ColorArray and Positions Array
            //
            Color[] ColorArray = null;
            float[] PositionArray = null;
            //
            // initialize color array for a button that is pushed
            //			
            if (btnState == BtnState.Pushed)
            {
                ColorArray = new Color[]{
                                     Blend(this.BackColor,System.Drawing.Color.White,80),
                                     Blend(this.BackColor,System.Drawing.Color.White,40),
                                     Blend(this.BackColor,System.Drawing.Color.Black,0),
                                     Blend(this.BackColor,System.Drawing.Color.Black,0),
                                     Blend(this.BackColor,System.Drawing.Color.White,40),
                                     Blend(this.BackColor,System.Drawing.Color.White,80),
                };
                PositionArray = new float[] { 0.0f, .05f, .40f, .60f, .95f, 1.0f };
            }
            //
            // else, initialize color array for a button that is normal or disabled
            //			
            else
            {
                ColorArray = new Color[]{
                                         Blend(color,System.Drawing.Color.White,80),
                                         Blend(color,System.Drawing.Color.White,90),
                                         Blend(color,System.Drawing.Color.White,30),
                                         Blend(color,System.Drawing.Color.White,00),
                                         Blend(color,System.Drawing.Color.Black,30),
                                         Blend(color,System.Drawing.Color.Black,20),
                };
                PositionArray = new float[] { 0.0f, .15f, .40f, .65f, .80f, 1.0f };
            }
            //
            // create blend variable for the interpolate the colors
            //
            System.Drawing.Drawing2D.ColorBlend blend = new System.Drawing.Drawing2D.ColorBlend();
            blend.Colors = ColorArray;
            blend.Positions = PositionArray;
            //
            // create vertical gradient brush
            //
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, this.BackColor, Blend(this.BackColor, this.BackColor, 10), System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            brush.InterpolationColors = blend;
            //
            // fill the rectangle
            //
            g.FillRectangle(brush, rect);

            brush.Dispose();
        }
        private void paint_Border(PaintEventArgs e)
        {
            if (e == null)
                return;
            if (e.Graphics == null)
                return;
            //
            // create the pen
            //
            Pen pen = new Pen(this.BorderColor, 5);
            //
            // get the points for the border
            //
            System.Drawing.Point[] pts = border_Get(0, 0, this.Width - 1, this.Height - 1);
            //
            // paint the border
            //
            e.Graphics.DrawLines(pen, pts);
            //
            // release resources
            //
        }
        private Point[] border_Get(int nLeftEdge, int nTopEdge, int nWidth, int nHeight)
        {
            int X = nWidth;
            int Y = nHeight;
            System.Drawing.Point[] points =
            {
                new Point(1   , 0  ),
                new Point(X-1 , 0  ),
                new Point(X-1 , 1  ),
                new Point(X   , 1  ),
                new Point(X   , Y-1),
                new Point(X-1 , Y-1),
                new Point(X-1 , Y  ),
                new Point(1   , Y  ),
                new Point(1   , Y-1),
                new Point(0   , Y-1),
                new Point(0   , 1  ),
                new Point(1   , 1  )
            };
            for (int i = 0; i < points.Length; i++)
            {
                points[i].Offset(nLeftEdge, nTopEdge);
            }
            return points;
        }
        private void paint_InnerBorder(PaintEventArgs e)
        {
            if (e == null)
                return;
            if (e.Graphics == null)
                return;

            Graphics g = e.Graphics;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, Size.Width, Size.Height);

            System.Drawing.Color color = this.BackColor;
            //
            // get color of inner border
            //
            switch (btnState)
            {
                case BtnState.Inactive:
                    color = System.Drawing.Color.Gray;
                    break;
                case BtnState.Normal:
                    if (this.Focused)
                        color = this.BorderColor;
                    else
                        color = this.BorderColor;
                    break;
                case BtnState.Pushed:
                    color = Blend(BorderColor, System.Drawing.Color.Black, 10);
                    break;
                case BtnState.MouseOver:
                    color = BorderColor;
                    break;
            }
            //
            // populate color and position arrays
            //			
            Color[] ColorArray = null;
            float[] PositionArray = null;
            if (btnState == BtnState.Pushed)
            {
                ColorArray = new System.Drawing.Color[] {
                                       Blend(color,System.Drawing.Color.Black,20),
                                       Blend(color,System.Drawing.Color.Black,10),
                                       Blend(color,System.Drawing.Color.White,00),
                                       Blend(color,System.Drawing.Color.White,50),
                                       Blend(color,System.Drawing.Color.White,85),
                                       Blend(color,System.Drawing.Color.White,90),
                };
                PositionArray = new float[] { 0.0f, .20f, .50f, .60f, .90f, 1.0f };
            }
            else
            {
                ColorArray = new System.Drawing.Color[] {
                                       Blend(color,System.Drawing.Color.White,80),
                                       Blend(color,System.Drawing.Color.White,60),
                                       Blend(color,System.Drawing.Color.White,10),
                                       Blend(color,System.Drawing.Color.White,00),
                                       Blend(color,System.Drawing.Color.Black,20),
                                       Blend(color,System.Drawing.Color.Black,50),
                };
                PositionArray = new float[] { 0.0f, .20f, .50f, .60f, .90f, 1.0f };
            }
            //
            // create blend object
            //
            System.Drawing.Drawing2D.ColorBlend blend = new System.Drawing.Drawing2D.ColorBlend();
            blend.Colors = ColorArray;
            blend.Positions = PositionArray;
            //
            // create gradient brush and pen
            //
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, this.BackColor, Blend(this.BackColor, this.BackColor, 10), System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            brush.InterpolationColors = blend;
            System.Drawing.Pen pen0 = new System.Drawing.Pen(brush, 1);
            //
            // get points array to draw the line
            //
            Point[] pts = border_Get(0, 0, this.Width - 1, this.Height - 1);
            //
            // draw line 0
            //
            this.border_Contract(1, ref pts);
            e.Graphics.DrawLines(pen0, pts);
            //
            // draw line 1
            //			
            this.border_Contract(1, ref pts);
            e.Graphics.DrawLines(pen0, pts);
            //
            // release resources
            //
            pen0.Dispose();
            brush.Dispose();
        }
        private void border_Contract(int nPixel, ref Point[] pts)
        {
            int a = nPixel;
            pts[0].X += a; pts[0].Y += a;
            pts[1].X -= a; pts[1].Y += a;
            pts[2].X -= a; pts[2].Y += a;
            pts[3].X -= a; pts[3].Y += a;
            pts[4].X -= a; pts[4].Y -= a;
            pts[5].X -= a; pts[5].Y -= a;
            pts[6].X -= a; pts[6].Y -= a;
            pts[7].X += a; pts[7].Y -= a;
            pts[8].X += a; pts[8].Y -= a;
            pts[9].X += a; pts[9].Y -= a;
            pts[10].X += a; pts[10].Y += a;
            pts[11].X += a; pts[10].Y += a;
        }
        #endregion

        #region Public Properties
        [Category("ColorChangeButtonOFF")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }
        [Category("ColorChangeButtonOFF")]
        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }
        [Category("ColorChangeButtonOFF")]
        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        [Category("ColorChangeButtonON")]
        public Color OnButtonUpBorderColor
        {
            get => _onButtonUpBorderColor;
            set
            {
                _onButtonUpBorderColor = value;
                Invalidate();
            }
        }
        [Category("ColorChangeButtonON")]
        public Color OnButtonUpColor
        {
            get => _onButtonUpColor;
            set
            {
                _onButtonUpColor = value;
                Invalidate();
            }
        }
        [Category("ColorChangeButtonON")]
        public Color OnButtonUpTextColor
        {
            get => _onButtonUpTextColor;
            set
            {
                _onButtonUpTextColor = value;
                Invalidate();
            }
        }
        #endregion

        #region Helper Methods
        private static Color Blend(Color SColor, Color DColor, int Percentage)
        {
            int r = SColor.R + ((DColor.R - SColor.R) * Percentage) / 100;
            int g = SColor.G + ((DColor.G - SColor.G) * Percentage) / 100;
            int b = SColor.B + ((DColor.B - SColor.B) * Percentage) / 100;
            return Color.FromArgb(r, g, b);
        }
        #endregion

    }
}
