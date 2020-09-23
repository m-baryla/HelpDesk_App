using System;
using System.Drawing;
using System.Windows.Forms;
using Interfaces;
using LogicApp;
using Microsoft.Office.Interop.Excel;
using Zuby.ADGV;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace GUI.Forms
{
    public partial class DataGrindViewForms : Form
    {
        private readonly IComputersLogic _computersLogic;
        private readonly INotebooksLogic _notebooksLogic;
        private readonly IMonitorsLogic _monitorsLogic;
        public DataGrindViewForms(IComputersLogic computersLogic, INotebooksLogic notebooksLogic, IMonitorsLogic monitorsLogic)
        {
            this._computersLogic = computersLogic;
            this._notebooksLogic = notebooksLogic;
            this._monitorsLogic = monitorsLogic;
            InitializeComponent();
            UploadData();
           
        }

        #region Get
        private void UploadData()
        {
            this.vwAll_NotebooksTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Notebooks);
            this.vwAll_MonitorsTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Monitors);
            this.vwAll_ComputersTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Computers);
            this.advancedDataGridViewComputers.Columns[0].Visible = false;
            this.advancedDataGridViewMonitors.Columns[0].Visible = false;
            this.advancedDataGridViewNotebooks.Columns[0].Visible = false;
        }
        private void DataGrindViewForms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'helpDeskDB_TESTDataSet.vwAll_Notebooks' table. You can move, or remove it, as needed.
            this.vwAll_NotebooksTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Notebooks);
            // TODO: This line of code loads data into the 'helpDeskDB_TESTDataSet.vwAll_Monitors' table. You can move, or remove it, as needed.
            this.vwAll_MonitorsTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Monitors);
            // TODO: This line of code loads data into the 'helpDeskDB_TESTDataSet.vwAll_Computers' table. You can move, or remove it, as needed.
            this.vwAll_ComputersTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Computers);

            UploadData();

        }
        #endregion

        #region Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (advancedDataGridViewComputers.SelectedRows.Count == 1)
                {
                    int selectRowIdComputers = Convert.ToInt32(advancedDataGridViewComputers.CurrentCell.RowIndex);
                    _computersLogic.DeleteComputer(new DataGridViewCellEventArgs(1, selectRowIdComputers), advancedDataGridViewComputers);
                    UploadData();

                }
                else if (advancedDataGridViewNotebooks.SelectedRows.Count == 1)
                {
                    int selectRowIdNotebooks = Convert.ToInt32(advancedDataGridViewNotebooks.CurrentCell.RowIndex);
                    _notebooksLogic.DeleteNotebooks(new DataGridViewCellEventArgs(1, selectRowIdNotebooks), advancedDataGridViewNotebooks);
                    UploadData();
                }
                else if (advancedDataGridViewMonitors.SelectedRows.Count == 1)
                {
                    int selectRowIdMonitors = Convert.ToInt32(advancedDataGridViewMonitors.CurrentCell.RowIndex);
                    _monitorsLogic.DeleteMonitors(new DataGridViewCellEventArgs(1, selectRowIdMonitors), advancedDataGridViewMonitors);
                    UploadData();
                }
            }
            catch (Exception)
            {
                
            }
           
        }

        #endregion

        #region Update

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (advancedDataGridViewComputers.SelectedRows.Count == 1)
                {
                    int selectRowIdComputers = Convert.ToInt32(advancedDataGridViewComputers.CurrentCell.RowIndex);

                    var updateComputers = new UpdateComputersForms(_computersLogic);
                    updateComputers.EditDataLoad(new DataGridViewCellEventArgs(1, selectRowIdComputers), advancedDataGridViewComputers);
                    updateComputers.Show();
                    UploadData();
                }
                else if (advancedDataGridViewNotebooks.SelectedRows.Count == 1)
                {
                    int selectRowIdNotebooks = Convert.ToInt32(advancedDataGridViewNotebooks.CurrentCell.RowIndex);

                    var _updateNotebooks = new UpdateNotebooksForms(_notebooksLogic);
                    _updateNotebooks.EditDataLoad(new DataGridViewCellEventArgs(1, selectRowIdNotebooks), advancedDataGridViewNotebooks);
                    _updateNotebooks.Show();
                    UploadData();
                }
                else if (advancedDataGridViewMonitors.SelectedRows.Count == 1)
                {
                    int selectRowIdMonitors = Convert.ToInt32(advancedDataGridViewMonitors.CurrentCell.RowIndex);

                    var _updateMonitors = new UpdateMonitorsForms(_monitorsLogic);
                    _updateMonitors.EditDataLoad(new DataGridViewCellEventArgs(1, selectRowIdMonitors), advancedDataGridViewMonitors);
                    _updateMonitors.Show();
                    UploadData();
                }
            }
            catch (Exception)
            {
               
            }
        }

        #endregion

        #region Filter and Sorting

        private void advancedDataGridViewComputers_SortStringChanged(object sender, AdvancedDataGridView.SortEventArgs e)
        {
            this.vwAllComputersBindingSource.Sort = advancedDataGridViewComputers.SortString;
        }
        private void advancedDataGridViewComputers_FilterStringChanged(object sender, AdvancedDataGridView.FilterEventArgs e)
        {
            this.vwAllComputersBindingSource.Filter = advancedDataGridViewComputers.FilterString;
        }
        private void advancedDataGridViewMonitors_SortStringChanged(object sender, AdvancedDataGridView.SortEventArgs e)
        {
            this.vwAllMonitorsBindingSource.Sort = advancedDataGridViewMonitors.SortString;
        }
        private void advancedDataGridViewMonitors_FilterStringChanged(object sender, AdvancedDataGridView.FilterEventArgs e)
        {
            this.vwAllMonitorsBindingSource.Filter = advancedDataGridViewMonitors.FilterString;
        }
        private void advancedDataGridViewNotebooks_SortStringChanged(object sender, AdvancedDataGridView.SortEventArgs e)
        {
            this.vwAllNotebooksBindingSource.Sort = advancedDataGridViewNotebooks.SortString;
        }
        private void advancedDataGridViewNotebooks_FilterStringChanged(object sender, AdvancedDataGridView.FilterEventArgs e)
        {
            this.vwAllNotebooksBindingSource.Filter = advancedDataGridViewNotebooks.FilterString;
        }
        #endregion

        #region Buttons
        private void buttonCloseDataGrind_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonFullScrean_Click(object sender, EventArgs e)
        {
          var fullScrean = new DataGrindViewForms(_computersLogic,_notebooksLogic,_monitorsLogic);
          fullScrean.Show();

            if (fullScrean.WindowState == FormWindowState.Maximized)
            {
                fullScrean.WindowState = FormWindowState.Normal;
                fullScrean.CenterToScreen();
            }
            else
            {
                fullScrean.WindowState = FormWindowState.Maximized;
                fullScrean.CenterToScreen();
            }
        } 
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UploadData();
        }

        #endregion

        #region ExportToExel
        private void buttonExel_Click(object sender, EventArgs e)
        {
            try
            {
                if (advancedDataGridViewComputers.SelectedRows.Count == 1)
                {                 
                    _computersLogic.ExportExelComputers(advancedDataGridViewComputers);
                    UploadData();
                }
                else if (advancedDataGridViewNotebooks.SelectedRows.Count == 1)
                { 
                    _notebooksLogic.ExportExelNotebooks(advancedDataGridViewNotebooks);
                    UploadData();
                }
                else if (advancedDataGridViewMonitors.SelectedRows.Count == 1)
                {
                    _monitorsLogic.ExportExelMonitors(advancedDataGridViewMonitors);
                    UploadData();
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ChangeColorState
        private void advancedDataGridViewComputers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (radioButtonColorOn.Checked)
            {
                try
                {
                    _computersLogic.ChangeStateColorComputers(advancedDataGridViewComputers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
               
        }
        private void advancedDataGridViewNotebooks_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (radioButtonColorOn.Checked)
            {
                try
                {
                    _notebooksLogic.ChangeStateColorNotebooks(advancedDataGridViewNotebooks);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void advancedDataGridViewMonitors_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if(radioButtonColorOn.Checked)
            {
                try
                {
                    _monitorsLogic.ChangeStateColorMonitors(advancedDataGridViewMonitors);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void radioButtonColorOn_CheckedChanged(object sender, EventArgs e)
        {
            UploadData();
        }
    }
}
