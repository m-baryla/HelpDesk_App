using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomClass
{
    public static class CustomConvertToBinary
    {
        public static byte[] ImgToBinary(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();

            pictureBox.Image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
