using System.Windows.Forms;

namespace GUI.CustomClass
{
    public static class CustomShowSubMenu
    {
        public static void ShowSubMenu(Panel submenuPanel)
        {
            submenuPanel.Visible = submenuPanel.Visible == false;
            //if (submenuPanel.Visible == false)
            //{
            //    submenuPanel.Visible = true;
            //}
            //else
            //{
            //    submenuPanel.Visible = false;
            //}
        }
    }
}
