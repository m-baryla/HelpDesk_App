using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomClass
{
    public static class CustomCreateCode
    {
        public static void CreateQRCode(PictureBox pictureBox, MaskedTextBox textBoxCompanyFixedAsset, TextBox textBoxTagService, ComboBox comboBoxModel)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrBarcodeDraw = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox.Image = qrBarcodeDraw.Draw(textBoxCompanyFixedAsset.Text
                                                        + " " +
                                                        textBoxTagService.Text
                                                        + " " +
                                                        comboBoxModel.Text, pictureBox.Width);
        }
        public static void CreateBarcodeCode(PictureBox pictureBox, MaskedTextBox textBoxCompanyFixedAsset)
        {
            Zen.Barcode.Code128BarcodeDraw barcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox.Image = barcodeDraw.Draw(textBoxCompanyFixedAsset.Text, pictureBox.Height);
        }
    }
}
