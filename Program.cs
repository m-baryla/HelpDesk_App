using System;
using System.Windows.Forms;
using DataBaseLayer.DataBase;
using GUI;
using GUI.Forms;

namespace HelpDesk_DB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard(new DataAcces(new InfoMessageBox()),new InfoMessageBox()));
        }
    }
}
