using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.CustomClass;
using HelpDesk_DB.UIDesign.Forms;
using Interfaces;
using LogicApp;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace GUI.Forms
{
    public partial class Dashboard : Form
    {
        private int _panelWidthSideMenu;

        private bool _hidden;

        private readonly IDataAcces _dataAcces;
        private readonly IInfoMessageBox _infoMessageBox;


        public Dashboard(IDataAcces dataAcces, IInfoMessageBox infoMessageBox)
        {
            this._dataAcces = dataAcces;
            this._infoMessageBox = infoMessageBox;
            InitializeComponent(); 
            customizeDesing();
        }

        #region CUSTOMIZE SUBMENU
        private void customizeDesing()
        {
            panelAddNewSubMenu.Visible = false;
            panelReportsSubMenu.Visible = false;

            _panelWidthSideMenu = panelSideMenu.Width;
            _hidden = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_hidden)
            {
                panelSideMenu.Width += 10;
                if (panelSideMenu.Width >= _panelWidthSideMenu)
                {
                    timer1.Stop();
                    _hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSideMenu.Width -= 10;
                if (panelSideMenu.Width <= 0)
                {
                    timer1.Stop();
                    _hidden = true;
                    this.Refresh();
                }
            }
        }
        #endregion

        #region Submenu Add New
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            CustomShowSubMenu.ShowSubMenu(panelAddNewSubMenu);
        }
        private void buttonAddNewComputers_Click(object sender, EventArgs e)
        {
            CustomChildForm.openChildForm(new AddComputerForms(new ComputersLogic(_dataAcces, _infoMessageBox)), panelChildForm);
        }
        private void buttonAddNewNotebooks_Click(object sender, EventArgs e)
        {
            CustomChildForm.openChildForm(new AddNotebooksForms(new NotebooksLogic(_dataAcces, _infoMessageBox)), panelChildForm);
        }
        private void buttonAddNewMonitors_Click(object sender, EventArgs e)
        {
            CustomChildForm.openChildForm(new AddMonitorForms(new MonitorsLogic(_dataAcces, _infoMessageBox)), panelChildForm);
        }
        #endregion

        #region Submenu Reports
        private void buttonReports_Click(object sender, EventArgs e)
        {
            CustomShowSubMenu.ShowSubMenu(panelReportsSubMenu);
        }
        #endregion

        #region Submenu Show Data
        private void buttonShow_Click(object sender, EventArgs e)
        {
            CustomChildForm.openChildForm(new DataGrindViewForms(new ComputersLogic(_dataAcces, _infoMessageBox),
                                                                 new NotebooksLogic(_dataAcces, _infoMessageBox),
                                                                 new MonitorsLogic(_dataAcces, _infoMessageBox)), panelChildForm);
        }
        #endregion

        #region Buttons
        private void buttonLogo_Click(object sender, EventArgs e)
        {
            var about = new AboutForms();
            about.Show();
        }
        private void buttonAddNewComputers_MouseMove(object sender, MouseEventArgs e)
        {
            CustomButtonStyle.ButtonSubMenuChangeStyleOn(buttonAddNewComputers, panelComputerButton);
        }
        private void buttonAddNewComputers_MouseLeave(object sender, EventArgs e)
        {
            CustomButtonStyle.ButtonSubMenuChangeStyleOff(buttonAddNewComputers,"COMPUTERS", panelComputerButton);
        }
        private void buttonAddNewNotebooks_MouseMove(object sender, MouseEventArgs e)
        {
            CustomButtonStyle.ButtonSubMenuChangeStyleOn(buttonAddNewNotebooks,panelNotebooksButton);
        }    
        private void buttonAddNewNotebooks_MouseLeave(object sender, EventArgs e)
        {
            CustomButtonStyle.ButtonSubMenuChangeStyleOff(buttonAddNewNotebooks, "NOTEBOOKS", panelNotebooksButton);
        } 
        private void buttonAddNewMonitors_MouseMove(object sender, MouseEventArgs e)
        {
            CustomButtonStyle.ButtonSubMenuChangeStyleOn(buttonAddNewMonitors, panelMonitorsButton);
        }
        private void buttonAddNewMonitors_MouseLeave(object sender, EventArgs e)
        {
            CustomButtonStyle.ButtonSubMenuChangeStyleOff(buttonAddNewMonitors, "MONITORS", panelMonitorsButton);
        }
        private void buttonHome_MouseLeave(object sender, EventArgs e)
        {
            CustomButtonStyle.ButtonMenuPanelChangeStyleOff(buttonHome);
        }

        private void buttonHome_MouseMove(object sender, MouseEventArgs e)
        {
            CustomButtonStyle.ButtonMenuPanelChangeStyleOn(buttonHome);
        }

        private void buttonListMenu_MouseLeave(object sender, EventArgs e)
        {
            CustomButtonStyle.ButtonMenuPanelChangeStyleOff(buttonListMenu);
        }

        private void buttonListMenu_MouseMove(object sender, MouseEventArgs e)
        {
            CustomButtonStyle.ButtonMenuPanelChangeStyleOn(buttonListMenu);
        }

        private void buttoSetings_MouseLeave(object sender, EventArgs e)
        {
            CustomButtonStyle.ButtonMenuPanelChangeStyleOff(buttoSetings);
        }

        private void buttoSetings_MouseMove(object sender, MouseEventArgs e)
        {
            CustomButtonStyle.ButtonMenuPanelChangeStyleOn(buttoSetings);
        }

        private void buttonAbout_MouseLeave(object sender, EventArgs e)
        {
            CustomButtonStyle.ButtonMenuPanelChangeStyleOff(buttonAbout);
        }

        private void buttonAbout_MouseMove(object sender, MouseEventArgs e)
        {
            CustomButtonStyle.ButtonMenuPanelChangeStyleOn(buttonAbout);
        }
        private void buttonAddNew_MouseLeave(object sender, EventArgs e)
        {
            CustomButtonStyle.ButtonSubmenuListChangeStyleOff(buttonAddNew);
        }

        private void buttonAddNew_MouseMove(object sender, MouseEventArgs e)
        {
            CustomButtonStyle.ButtonSubmenuListChangeStyleOn(buttonAddNew);
        }

        private void buttonReports_MouseLeave(object sender, EventArgs e)
        {
            CustomButtonStyle.ButtonSubmenuListChangeStyleOff(buttonReports);
        }

        private void buttonReports_MouseMove(object sender, MouseEventArgs e)
        {
            CustomButtonStyle.ButtonSubmenuListChangeStyleOn(buttonReports);
        }

        private void buttonShow_MouseLeave(object sender, EventArgs e)
        {
            CustomButtonStyle.ButtonSubmenuListChangeStyleOff(buttonShow);
        }

        private void buttonShow_MouseMove(object sender, MouseEventArgs e)
        {
            CustomButtonStyle.ButtonSubmenuListChangeStyleOn(buttonShow);
        }
        private void buttonAddNew_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderButtons(sender, e);
        }

        private void buttonReports_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderButtons(sender, e);
        }

        private void buttonShow_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderButtons(sender, e);
        }

        private void buttonHome_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderButtons(sender, e);
        }

        private void buttonListMenu_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderButtons(sender, e);
        }

        private void buttoSetings_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderButtons(sender, e);
        }

        private void buttonAbout_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderButtons(sender, e);
        }
        private void buttonLogo_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderButtons(sender, e);
        }
        private void buttonListMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        #endregion

    }
}
