using System;
using System.Linq;
using System.Windows.Forms;
using Interfaces;
using IInfoMessageBox = Interfaces.IInfoMessageBox;

namespace GUI.Forms
{
    public partial class AddComputerForms : Form
    {
        private readonly IComputersLogic _computersLogic;

        public AddComputerForms(IComputersLogic computersLogic)
        {
            this._computersLogic = computersLogic;
            InitializeComponent();
            UploadData();
        }

        private void UploadData()
        {
            comboBoxLocationComputer.DataSource = _computersLogic.FillComboBoxLocation().ToList();
            comboBoxModelComputer.DataSource = _computersLogic.FillComboBoxModelComputer().ToList();
            comboBoxCPUComputer.DataSource = _computersLogic.FillComboBoxCPU().ToList();
            comboBoxRAMComputer.DataSource = _computersLogic.FillComboBoxRAM().ToList();
            comboBoxHardDriveComputer.DataSource = _computersLogic.FillComboBoxHardDrive().ToList();
            comboBoxOfficeComputer.DataSource = _computersLogic.FillComboBoxOffice().ToList();
            comboBoxOperatigSystemComputer.DataSource = _computersLogic.FillComboBoxOperatingSystem().ToList();
            ///
            textBoxNameComputer.Text = "OPP-00000";
            textBoxCompanyFixedAssetComputer.Text = "T-D-00000";
        }

        #region Button
        private void buttonInsertDataComputer_Click(object sender, EventArgs e)
        {
            _computersLogic.Insert(textBoxNameComputer.Text, comboBoxOperatigSystemComputer.Text,
                            textBoxCompanyFixedAssetComputer.Text,textBoxTagServiceComputer.Text,
                            comboBoxLocationComputer.Text,textBoxUserComputer.Text,
                           comboBoxOfficeComputer.Text,textBoxIPComputer.Text, comboBoxModelComputer.Text,
                            comboBoxCPUComputer.Text, comboBoxRAMComputer.Text, comboBoxHardDriveComputer.Text,
                            richTextBoxComentsComputer.Text,dateTimePickerPurchaseDateComputer.Value,
                            dateTimePickerWarrantyDateComputer.Value);
        }  
        private void buttonCloseComputer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Label link add new _values

        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxModelComputer(comboBoxModelComputer.Text);
            UploadData();
        }

        private void linkLabelAddNewRAM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxRAM(comboBoxRAMComputer.Text);
            UploadData();
        }

        private void linkLabelAddNewHardDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxHardDrive(comboBoxHardDriveComputer.Text);
            UploadData();
        }

        private void linkLabelAddNewOperatingSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxOperatingSystem(comboBoxOperatigSystemComputer.Text);
            UploadData();
        }

        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxLocation(comboBoxLocationComputer.Text);
            UploadData();
        }

        private void linkLabelAddNewMicrosoftOffice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxMicrosoftOffice(comboBoxOfficeComputer.Text);
            UploadData();
        }
        private void linkLabelAddNewCPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxCPU(comboBoxCPUComputer.Text);
            UploadData();
        }

        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ////
        }
        #endregion

    }
}
