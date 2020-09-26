using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomClass
{
    public static class CustomBorder 
    {
        public static void PaintBorderPictureBox(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            float width = (float)4.0;
            Pen pen = new Pen(Color.DarkRed, width);
            pen.DashStyle = DashStyle.DashDotDot;
            e.Graphics.DrawLine(pen, 0, 0, 0, pictureBox.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, pictureBox.Width - 0, 0);
            e.Graphics.DrawLine(pen, pictureBox.Width - 1, pictureBox.Height - 1, 0, pictureBox.Height - 1);
            e.Graphics.DrawLine(pen, pictureBox.Width - 1, pictureBox.Height - 1, pictureBox.Width - 1, 0);
        }
     
        public static void PaintBorderButtons(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            float width = (float)1.0;
            Pen pen = new Pen(Color.DarkRed, width);
            pen.DashStyle = DashStyle.DashDotDot;
            e.Graphics.DrawLine(pen, 0, 0, 0, button.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, button.Width - 0, 0);
            e.Graphics.DrawLine(pen, button.Width - 1, button.Height - 1, 0, button.Height - 1);
            e.Graphics.DrawLine(pen, button.Width - 1, button.Height - 1, button.Width - 1, 0);
        }
    }
}
