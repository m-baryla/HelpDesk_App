using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomClass
{
    public static class CustomButtonStyle
    {
        #region Sumbmenu Buttons
        public static void ButtonSubMenuChangeStyleOn(Button button, Panel panel)
        {
            button.BackColor = Color.White;
            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.Text = "";
            button.Padding = new Padding(0, 0, 0, 0);
            panel.Visible = true;
            panel.BackColor = Color.DarkRed;
            panel.Size = new Size(15, 35);
        }
        public static void ButtonSubMenuChangeStyleOff(Button button, string name, Panel panel)
        {
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;
            button.Text = name;
            button.ImageAlign = ContentAlignment.MiddleRight;
            button.Padding = new Padding(40, 0, 20, 0);
            panel.Visible = false;
        }
        #endregion

        #region Show Data Buttons
        public static void ButtonShowDataChangeStyleOn(Button button)
        {
            button.BackColor = Color.White;
            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.Text = "";
        }
        public static void ButtonShowDataChangeStyleOff(Button button, string name)
        {
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;
            button.Text = name;
            button.ImageAlign = ContentAlignment.MiddleRight;
        }
        #endregion

        #region Menu Panel Buttons
        public static void ButtonMenuPanelChangeStyleOn(Button button)
        {
            button.BackColor = Color.White;
            button.ImageAlign = ContentAlignment.MiddleCenter;
        }
        public static void ButtonMenuPanelChangeStyleOff(Button button)
        {
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;
            button.ImageAlign = ContentAlignment.MiddleCenter;
        }
        #endregion

        #region SubmenuList Panel Buttons
        public static void ButtonSubmenuListChangeStyleOn(Button button)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }
        public static void ButtonSubmenuListChangeStyleOff(Button button)
        {
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;
        }
        #endregion


    }
}
