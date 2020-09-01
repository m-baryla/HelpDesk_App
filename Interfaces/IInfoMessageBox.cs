using System.Windows.Forms;

namespace Interfaces
{
    public interface IInfoMessageBox
    {
        void Info(string msg);
        void Error(string msg);
        void Sucesfull(string msg);
        DialogResult InfoYesNo(string msg);
    }
}