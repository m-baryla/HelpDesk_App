using System;
using System.Windows.Forms;
using Interfaces;
using Zuby.ADGV;

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

        #region GET
        private void UploadData()
        {
            this.vwAll_NotebooksTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Notebooks);
            this.vwAll_MonitorsTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Monitors);
            this.vwAll_ComputersTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Computers);
        }
        #endregion

        #region DELETE
        private void buttonDelete_Click(object sender, EventArgs e)
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

        #endregion

        #region UPDATE

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (advancedDataGridViewComputers.SelectedRows.Count == 1)
                {
                    int selectRowIdComputers = Convert.ToInt32(advancedDataGridViewComputers.CurrentCell.RowIndex);

                    UpdateComputersForms _updateComputers = new UpdateComputersForms(_computersLogic);
                    _updateComputers.EditDataLoad(new DataGridViewCellEventArgs(1, selectRowIdComputers),
                        advancedDataGridViewComputers);
                    _updateComputers.Show();
                }
                else if (advancedDataGridViewNotebooks.SelectedRows.Count == 1)
                {
                    int selectRowIdNotebooks = Convert.ToInt32(advancedDataGridViewNotebooks.CurrentCell.RowIndex);

                    UpdateNotebooksForms _updateNotebooks = new UpdateNotebooksForms(_notebooksLogic);
                    _updateNotebooks.EditDataLoad(new DataGridViewCellEventArgs(1, selectRowIdNotebooks),
                        advancedDataGridViewComputers);
                    _updateNotebooks.Show();
                }
                else if (advancedDataGridViewMonitors.SelectedRows.Count == 1)
                {
                    int selectRowIdMonitors = Convert.ToInt32(advancedDataGridViewMonitors.CurrentCell.RowIndex);

                    UpdateMonitorsForms _updateMonitors = new UpdateMonitorsForms(_monitorsLogic);
                    _updateMonitors.EditDataLoad(new DataGridViewCellEventArgs(1, selectRowIdMonitors),
                        advancedDataGridViewComputers);
                    _updateMonitors.Show();
                }
            }
            catch (Exception )
            {
                ///
            }
            finally
            {
                UploadData();
            }
        }

        #endregion

        #region FILTER AND SORTING

        private void DataGrindViewForms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'helpDeskDB_TESTDataSet.vwAll_Notebooks' table. You can move, or remove it, as needed.
            this.vwAll_NotebooksTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Notebooks);
            // TODO: This line of code loads data into the 'helpDeskDB_TESTDataSet.vwAll_Monitors' table. You can move, or remove it, as needed.
            this.vwAll_MonitorsTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Monitors);
            // TODO: This line of code loads data into the 'helpDeskDB_TESTDataSet.vwAll_Computers' table. You can move, or remove it, as needed.
            this.vwAll_ComputersTableAdapter.Fill(this.helpDeskDB_TESTDataSet.vwAll_Computers);
        }

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
        
        #region BUTTON
        private void buttonCloseDataGrind_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UploadData();
        }
        private void buttonFullScrean_Click(object sender, EventArgs e)
        {
          var fullScrean = new DataGrindViewForms(_computersLogic,_notebooksLogic,_monitorsLogic);
          fullScrean.Show();
        }
        #endregion

    }
}
