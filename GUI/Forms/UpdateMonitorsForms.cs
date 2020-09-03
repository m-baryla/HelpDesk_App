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
            groupBoxAddNewUser.Visible = false;
        }

        private void UploadData()
        {
            comboBoxLocationMonitors.DataSource = _monitorsLogic.FillComboBoxLocation().ToList();
            comboBoxModelMonitors.DataSource = _monitorsLogic.FillComboBoxModelMonitors().ToList();
            comboBoxUsers.DataSource = _monitorsLogic.FillComboBoxUsers().ToList();
        }

        #region COMBOBOX DATA
        public void EditDataLoad(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView)
        {

            var barcode = "q";

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
                        textBoxFirstName.Text = dgViewRow.Cells[7].Value.ToString();
                        textBoxLastName.Text = dgViewRow.Cells[8].Value.ToString();
                        textBoxJob.Text = dgViewRow.Cells[9].Value.ToString();
                        comboBoxLocationMonitors.Text = dgViewRow.Cells[10].Value.ToString();
                        comboBoxModelMonitors.Text = dgViewRow.Cells[11].Value.ToString();
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
                comboBoxLocationMonitors.Text, comboBoxUsers.Text, comboBoxModelMonitors.Text,richTextBoxComentsMonitors.Text,
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
            _monitorsLogic.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text);
            comboBoxUsers.DataSource = _monitorsLogic.FillComboBoxUsers().ToList();
            comboBoxUsers.Text = textBoxFirstName.Text + " " + textBoxLastName.Text;
        }
        #endregion

        private void buttonAddNewUsers_Click(object sender, EventArgs e)
        {
            groupBoxAddNewUser.Visible = true;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            groupBoxAddNewUser.Visible = false;
        }
    }
}
