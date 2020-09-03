using System;
using System.Linq;
using System.Windows.Forms;
using Interfaces;

namespace GUI.Forms
{
    public partial class AddMonitorForms : Form
    {
        private readonly IMonitorsLogic _monitorsLogic;

        public AddMonitorForms(IMonitorsLogic monitorsLogic)
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
            ///
            textBoxCompanyFixedAssetMonitors.Text = "T-D-00000";
        }

        #region Button
        private void buttonInsertDataMonitors_Click(object sender, EventArgs e)
        {
            _monitorsLogic?.Insert(textBoxCompanyFixedAssetMonitors.Text, textBoxTagServiceMonitors.Text,
                comboBoxLocationMonitors.Text, comboBoxUsers.Text, comboBoxModelMonitors.Text, 
                richTextBoxComentsMonitors.Text, dateTimePickerPurchaseDateMonitors.Value, dateTimePickerWarrantyDateMonitors.Value); // if != null
        }

        private void buttonCloseMonitor_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Label link add new _values
        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic?.InsertComboBoxLocation(comboBoxLocationMonitors.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic?.InsertComboBoxModelMonitor(comboBoxModelMonitors.Text); // if != null
            UploadData();
        }
        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic?.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text); // if != null
            UploadData();
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
