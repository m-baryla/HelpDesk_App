using System;
using System.Drawing;
using System.Windows.Forms;
using HelpDesk_DB.UIDesign;
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

        private void buttonChangeStyleOn(Button button,Panel panel)
        {
            button.BackColor = Color.White;
            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.Text = "";
            button.Padding = new Padding(0, 0, 0, 0);
            panel.Visible = true;
            panel.BackColor = Color.DarkOrange;
            panel.Size = new Size(10, 35);
        }
        private void buttonChangeStyleOff(Button button,string name,Panel panel)
        {
            //button.BackColor = Color.FromArgb(43, 43, 43);
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;
            button.Text = name;
            button.ImageAlign = ContentAlignment.MiddleRight;
            button.Padding = new Padding(40, 0, 20, 0);
            panel.Visible = false;
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

        #region ADD NEW
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            ShowSubMenu.showSubMenu(panelAddNewSubMenu);
        }
        private void buttonAddNewComputers_Click(object sender, EventArgs e)
        {
            ChildForm.openChildForm(new AddComputerForms(new ComputersLogic(_dataAcces, _infoMessageBox)), panelChildForm);
        }
        private void buttonAddNewNotebooks_Click(object sender, EventArgs e)
        {
            ChildForm.openChildForm(new AddNotebooksForms(new NotebooksLogic(_dataAcces, _infoMessageBox)), panelChildForm);
        }
        private void buttonAddNewMonitors_Click(object sender, EventArgs e)
        {
            ChildForm.openChildForm(new AddMonitorForms(new MonitorsLogic(_dataAcces, _infoMessageBox)), panelChildForm);
        }
        #endregion

        #region REPORTS
        private void buttonReports_Click(object sender, EventArgs e)
        {
            ShowSubMenu.showSubMenu(panelReportsSubMenu);
        }
        #endregion

        #region SHOW DATA GRIND
        private void buttonShow_Click(object sender, EventArgs e)
        {
            ChildForm.openChildForm(new DataGrindViewForms(new ComputersLogic(_dataAcces, _infoMessageBox),new NotebooksLogic(_dataAcces, _infoMessageBox),new MonitorsLogic(_dataAcces, _infoMessageBox)), panelChildForm);
        }
        #endregion

        #region BUTTON
        private void buttonLogo_Click(object sender, EventArgs e)
        {
            var about = new AboutForms();
            about.Show();
        }

        private void buttonAddNewComputers_MouseMove(object sender, MouseEventArgs e)
        {
            buttonChangeStyleOn(buttonAddNewComputers, panelComputerButton);
        }

        private void buttonAddNewComputers_MouseLeave(object sender, EventArgs e)
        {
            buttonChangeStyleOff(buttonAddNewComputers,"COMPUTERS", panelComputerButton);
        }

        private void buttonAddNewNotebooks_MouseMove(object sender, MouseEventArgs e)
        {
            buttonChangeStyleOn(buttonAddNewNotebooks,panelNotebooksButton);
        }    
        private void buttonAddNewNotebooks_MouseLeave(object sender, EventArgs e)
        {
            buttonChangeStyleOff(buttonAddNewNotebooks, "NOTEBOOKS", panelNotebooksButton);
        } 

        private void buttonAddNewMonitors_MouseMove(object sender, MouseEventArgs e)
        {
            buttonChangeStyleOn(buttonAddNewMonitors, panelMonitorsButton);
        }
        private void buttonAddNewMonitors_MouseLeave(object sender, EventArgs e)
        {
            buttonChangeStyleOff(buttonAddNewMonitors, "MONITORS", panelMonitorsButton);
        }
        private void buttonListMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        #endregion

    }
}
