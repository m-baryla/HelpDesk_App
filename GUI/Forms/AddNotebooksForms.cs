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
        }

        private void UploadData()
        {
            comboBoxLocationNotebook.DataSource = _notebooksLogic.FillComboBoxLocation().ToList();
            comboBoxModelNotebook.DataSource = _notebooksLogic.FillComboBoxModelNotebooks().ToList();
            comboBoxCPUNotebook.DataSource = _notebooksLogic.FillComboBoxCPU().ToList();
            comboBoxRAMNotebook.DataSource = _notebooksLogic.FillComboBoxRAM().ToList();
            comboBoxHardDriveNotebook.DataSource = _notebooksLogic.FillComboBoxHardDrive().ToList();
            comboBoxOfficeNotebook.DataSource = _notebooksLogic.FillComboBoxOffice().ToList();
            comboBoxOperatigSystemNotebook.DataSource = _notebooksLogic.FillComboBoxOperatingSystem().ToList();
            ///
            textBoxNameNotebook.Text = "OPP-00000";
            textBoxCompanyFixedAssetNotebook.Text = "T-D-00000";
        }

        #region Button
        private void buttonInsertDataNotebooks_Click(object sender, EventArgs e)
        {
            _notebooksLogic.Insert(textBoxNameNotebook.Text, comboBoxOperatigSystemNotebook.Text,
                    textBoxCompanyFixedAssetNotebook.Text, textBoxTagServiceNotebook.Text,
                    comboBoxLocationNotebook.Text, textBoxUserNotebook.Text,
                    comboBoxOfficeNotebook.Text, textBoxIPNotebook.Text, comboBoxModelNotebook.Text,
                    comboBoxCPUNotebook.Text, comboBoxRAMNotebook.Text, comboBoxHardDriveNotebook.Text,
                    richTextBoxComentsNotebook.Text, dateTimePickerPurchaseDateNotebook.Value,
                    dateTimePickerWarrantyDateNotebook.Value);
        }

        private void buttonCloseMonitor_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Label link add new _values
        private void linkLabelAddNewOffice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxMicrosoftOffice(comboBoxOfficeNotebook.Text);
            UploadData();
        }

        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxLocation(comboBoxLocationNotebook.Text);
            UploadData();
        }

        private void linkLabelAddNewOperatingSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxOperatingSystem(comboBoxOperatigSystemNotebook.Text);
            UploadData();
        }

        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxModelNotebook(comboBoxModelNotebook.Text);
            UploadData();
        }

        private void linkLabelAddNewCPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxCPU(comboBoxCPUNotebook.Text);
            UploadData();
        }

        private void linkLabelAddNewRAM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxRAM(comboBoxRAMNotebook.Text);
            UploadData();
        }

        private void linkLabelAddNewHardDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxHardDrive(comboBoxHardDriveNotebook.Text);
            UploadData();
        }
        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ///
        }
        #endregion

    }
}
