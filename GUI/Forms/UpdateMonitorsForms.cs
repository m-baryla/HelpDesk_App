using System;
using System.Linq;
using System.Windows.Forms;
using Interfaces;
using Zuby.ADGV;

namespace GUI.Forms
{
    public partial class UpdateMonitorsForms : Form
    {
        private readonly IMonitorsLogic _monitorsLogic;

        public UpdateMonitorsForms(IMonitorsLogic monitorsLogic)
        {
            this._monitorsLogic = monitorsLogic;
            InitializeComponent();
            UploadData();
        }

        private void UploadData()
        {
            comboBoxLocationMonitors.DataSource = _monitorsLogic.FillComboBoxLocation().ToList();
            comboBoxModelMonitors.DataSource = _monitorsLogic.FillComboBoxModelMonitors().ToList();
        }

        #region COMBOBOX DATA
        public void EditDataLoad(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView)
        {

            var barcode = "wq";

            var dialogResult = MessageBox.Show("Do you want to edit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                    {
                        DataGridViewRow dgViewRow = advancedDataGridView.Rows[e.RowIndex];

                        // [UpdateMonitorsDataViev] must be like the view as [vwAll_Monitors]
                        textBoxIDMonitor.Text = dgViewRow.Cells[0].Value.ToString();
                        textBoxTagServiceMonitors.Text = dgViewRow.Cells[1].Value.ToString();
                        dateTimePickerPurchaseDateMonitors.Value = Convert.ToDateTime(dgViewRow.Cells[2].Value);
                        dateTimePickerWarrantyDateMonitors.Value = Convert.ToDateTime(dgViewRow.Cells[3].Value);
                        barcode = dgViewRow.Cells[4].Value.ToString();
                        richTextBoxComentsMonitors.Text = dgViewRow.Cells[5].Value.ToString();
                        textBoxCompanyFixedAssetMonitors.Text = dgViewRow.Cells[6].Value.ToString();
                        textBoxFirstNameUserMonitors.Text = dgViewRow.Cells[7].Value.ToString();
                        comboBoxLocationMonitors.Text = dgViewRow.Cells[8].Value.ToString();
                        comboBoxModelMonitors.Text = dgViewRow.Cells[9].Value.ToString();
                        break;
                    }
                    case DialogResult.No:
                    {
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BUTTON
        private void buttonUpdateDataMonitor_Click(object sender, EventArgs e)
        {
            _monitorsLogic.Update(Convert.ToInt32(textBoxIDMonitor.Text), textBoxCompanyFixedAssetMonitors.Text,textBoxTagServiceMonitors.Text,
                comboBoxLocationMonitors.Text, textBoxFirstNameUserMonitors.Text, comboBoxModelMonitors.Text,richTextBoxComentsMonitors.Text,
                dateTimePickerPurchaseDateMonitors.Value, dateTimePickerWarrantyDateMonitors.Value);
        }
        #endregion

        #region LABEL LINK ADD NEW --VALUES
        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic.InsertComboBoxModelMonitor(comboBoxModelMonitors.Text);
            UploadData();
        }

        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic.InsertComboBoxLocation(comboBoxLocationMonitors.Text);
            UploadData();
        }

        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ///
        }
        #endregion
    }
}
