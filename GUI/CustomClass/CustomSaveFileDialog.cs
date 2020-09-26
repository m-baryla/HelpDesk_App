using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomClass
{
    public static class CustomSaveFileDialog
    {
        public static void SaveFile(Panel panel)
        {
            SaveFileDialog f = new SaveFileDialog();

            f.Filter = "JPG(*.JPG)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(panel.Width + 50, panel.Height + panel.Height / 2);
                panel.DrawToBitmap(bmp, panel.Bounds);
                bmp.Save(f.FileName);
            }
        }
    }
}
