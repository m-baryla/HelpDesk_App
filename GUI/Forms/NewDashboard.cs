using GUI.CustomClass;
using Interfaces;
using LogicApp;
using Reports;
using Reports.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class NewDashboard : Form
    {

        #region Private Variabels
        private int _panelWidthSideMenu;
        private bool _hidden;

        private readonly IDataAcces _dataAcces;
        private readonly IInfoMessageBox _infoMessageBox;
        #endregion

        public NewDashboard(IDataAcces dataAcces, IInfoMessageBox infoMessageBox)
        {
            this._dataAcces = dataAcces;
            this._infoMessageBox = infoMessageBox;
            InitializeComponent();
            customizeDesing();
            timerClock.Start();
        }


        #region Events
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            CustomShowSubMenu.ShowSubMenu(panelAddNewSubMenu);
        }

        private void buttonMenuList_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            CustomShowSubMenu.ShowSubMenu(panelReportsSubMenu);
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

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            CustomChildForm.openChildForm(new DataGrindViewForms(new ComputersLogic(_dataAcces, _infoMessageBox),
                                                                new NotebooksLogic(_dataAcces, _infoMessageBox),
                                                                new MonitorsLogic(_dataAcces, _infoMessageBox)), panelChildForm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_hidden)
            {
                panelSideMenu.Width += 10;
                if (panelSideMenu.Width >= _panelWidthSideMenu)
                {
                    DoubleBuffered = true;
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
                    DoubleBuffered = true;
                    timer1.Stop();
                    _hidden = true;
                    this.Refresh();
                }
            }
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            customizeDesing();
            timerClock.Start();
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelHourMin.Text = DateTime.Now.ToString("HH:mm");
            labelMMDDRRRR.Text = DateTime.Now.ToString("dd / MM / yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd");
            labelSec.Text = DateTime.Now.ToString("ss");
        }
        private void buttonCompleComputersReport_Click(object sender, EventArgs e)
        {
            try
            {
                var dialogResult = MessageBox.Show("Do you want to open the file in full screen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        {
                            CompleteReportComputers reportComputers = new CompleteReportComputers();
                            reportComputers.Show();
                            reportComputers.WindowState = FormWindowState.Normal;

                            break;
                        }
                    case DialogResult.No:
                        {
                            CustomChildForm.openChildForm(new CompleteReportComputers(), panelChildForm);

                            break;
                        }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void buttonCompleNotebooksReport_Click(object sender, EventArgs e)
        {
            
            try
            {
                var dialogResult = MessageBox.Show("Do you want to open the file in full screen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        {
                            CompleteReportNotebooks reportNotebooks = new CompleteReportNotebooks();
                            reportNotebooks.Show();
                            reportNotebooks.WindowState = FormWindowState.Normal;

                            break;
                        }
                    case DialogResult.No:
                        {
                           CustomChildForm.openChildForm(new CompleteReportNotebooks(), panelChildForm);

                            break;
                        }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Helper Methods
        private void customizeDesing()
        {
            panelAddNewSubMenu.Visible = false;
            panelReportsSubMenu.Visible = false;

            _panelWidthSideMenu = panelSideMenu.Width;
            _hidden = false;
            
        }
        #endregion

        #region Paint
        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(panelSideMenu, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void panelMenuList_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(panelMenuList, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void panelChildForm_Paint_1(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(panelChildForm, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }



        #endregion

       
    }
}
