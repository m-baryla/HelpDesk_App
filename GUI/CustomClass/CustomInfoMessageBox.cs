using System.Windows.Forms;
using Interfaces;

namespace GUI.CustomClass
{
    public class CustomInfoMessageBox : IInfoMessageBox
    {
        private static readonly string caption_Error = "Error";
        private static readonly string caption_Information = "Information";
        private static readonly string caption_Sucesfull = "Sucesfull";

        public void Info(string msg)
        {
            MessageBox.Show(msg, caption_Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Error(string msg)
        {
            MessageBox.Show(msg, caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Sucesfull(string msg)
        {
            MessageBox.Show(msg, caption_Sucesfull, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult InfoYesNo(string msg)
        {
            return MessageBox.Show(msg, caption_Information, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
