using System;
using System.Windows.Forms;
using DataBaseLayer.DataBase;
using GUI.CustomClass;
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
            //try
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new Dashboard(new DataAcces(new InfoMessageBox()), new InfoMessageBox()));
            //}
            //catch (Exception)
            //{

            //}
            //finally
            //{
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewDashboard(new DataAcces(new CustomInfoMessageBox()), new CustomInfoMessageBox()));
        }
    }
}
