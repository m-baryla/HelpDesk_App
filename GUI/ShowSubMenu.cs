using System.Windows.Forms;

namespace HelpDesk_DB.UIDesign
{
    public static class ShowSubMenu
    {
        public static void showSubMenu(Panel submenuPanel)
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
