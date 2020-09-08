using System;
using System.Linq;
using System.Windows.Forms;
using Interfaces;

namespace GUI.Forms
{
    public partial class AddNotebooksForms : Form
    {
        private readonly INotebooksLogic _notebooksLogic;

        public AddNotebooksForms(INotebooksLogic notebooksLogic)
        {
            this._notebooksLogic = notebooksLogic;
            InitializeComponent();
            UploadData();
            groupBoxAddNewUser.Visible = false;
        }

        private void UploadData()
        {
            comboBoxLocationNotebook.DataSource = _notebooksLogic.FillComboBoxLocation().ToList();
            comboBoxLocationNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxLocationNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxModelNotebook.DataSource = _notebooksLogic.FillComboBoxModelNotebooks().ToList();
            comboBoxModelNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxModelNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxCPUNotebook.DataSource = _notebooksLogic.FillComboBoxCPU().ToList();
            comboBoxCPUNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCPUNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxRAMNotebook.DataSource = _notebooksLogic.FillComboBoxRAM().ToList();
            comboBoxRAMNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxRAMNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxHardDriveNotebook.DataSource = _notebooksLogic.FillComboBoxHardDrive().ToList();
            comboBoxHardDriveNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxHardDriveNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxOfficeNotebook.DataSource = _notebooksLogic.FillComboBoxOffice().ToList();
            comboBoxOfficeNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxOfficeNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxOperatigSystemNotebook.DataSource = _notebooksLogic.FillComboBoxOperatingSystem().ToList();
            comboBoxOperatigSystemNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxOperatigSystemNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxUsers.DataSource = _notebooksLogic.FillComboBoxUsers().ToList();
            comboBoxUsers.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxUsers.AutoCompleteSource = AutoCompleteSource.ListItems;
            ///
            textBoxNameNotebook.Text = "OPP-00000";
            textBoxCompanyFixedAssetNotebook.Text = "T-D-00000";
        }

        #region Button
        private void buttonInsertDataNotebooks_Click(object sender, EventArgs e)
        {
            _notebooksLogic?.Insert(textBoxNameNotebook.Text, comboBoxOperatigSystemNotebook.Text,
                    textBoxCompanyFixedAssetNotebook.Text, textBoxTagServiceNotebook.Text,
                    comboBoxLocationNotebook.Text, comboBoxUsers.Text,
                    comboBoxOfficeNotebook.Text, textBoxIPNotebook.Text, comboBoxModelNotebook.Text,
                    comboBoxCPUNotebook.Text, comboBoxRAMNotebook.Text, comboBoxHardDriveNotebook.Text,
                    richTextBoxComentsNotebook.Text, dateTimePickerPurchaseDateNotebook.Value,
                    dateTimePickerWarrantyDateNotebook.Value); // if != null
        }
        private void buttonCloseMonitor_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAddNewUsers_Click(object sender, EventArgs e)
        {
            groupBoxAddNewUser.Visible = true;
        }
        private void labelClose_Click(object sender, EventArgs e)
        {
            groupBoxAddNewUser.Visible = false;
        }
        #endregion

        #region Label link add new _values
        private void linkLabelAddNewOffice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxMicrosoftOffice(comboBoxOfficeNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxLocation(comboBoxLocationNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewOperatingSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxOperatingSystem(comboBoxOperatigSystemNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxModelNotebook(comboBoxModelNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewCPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxCPU(comboBoxCPUNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewRAM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxRAM(comboBoxRAMNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewHardDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxHardDrive(comboBoxHardDriveNotebook.Text); // if != null
            UploadData();
        }
        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text); // if != null
            UploadData();
        }
        #endregion

    }
}
