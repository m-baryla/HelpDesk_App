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
            groupBoxAddNewUser.Visible = false;
        }

        private void UploadData()
        {
            comboBoxLocationComputer.DataSource = _computersLogic.FillComboBoxLocation().ToList();
            comboBoxLocationComputer.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxLocationComputer.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxModelComputer.DataSource = _computersLogic.FillComboBoxModelComputer().ToList();
            comboBoxModelComputer.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxModelComputer.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxCPUComputer.DataSource = _computersLogic.FillComboBoxCPU().ToList();
            comboBoxCPUComputer.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCPUComputer.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxRAMComputer.DataSource = _computersLogic.FillComboBoxRAM().ToList();
            comboBoxRAMComputer.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxRAMComputer.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxHardDriveComputer.DataSource = _computersLogic.FillComboBoxHardDrive().ToList();
            comboBoxHardDriveComputer.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxHardDriveComputer.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxOfficeComputer.DataSource = _computersLogic.FillComboBoxOffice().ToList();
            comboBoxOfficeComputer.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxOfficeComputer.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxOperatigSystemComputer.DataSource = _computersLogic.FillComboBoxOperatingSystem().ToList();
            comboBoxOperatigSystemComputer.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxOperatigSystemComputer.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxUser.DataSource = _computersLogic.FillComboBoxUsers().ToList();
            comboBoxUser.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxUser.AutoCompleteSource = AutoCompleteSource.ListItems;
            ///
            textBoxNameComputer.Text = "OPP-00000";
            textBoxCompanyFixedAssetComputer.Text = "T-D-00000";
        }

        #region Button
        private void buttonInsertDataComputer_Click(object sender, EventArgs e)
        {
            _computersLogic.Insert(textBoxNameComputer.Text, comboBoxOperatigSystemComputer.Text,
                            textBoxCompanyFixedAssetComputer.Text,textBoxTagServiceComputer.Text,
                            comboBoxLocationComputer.Text,comboBoxUser.Text,
                            comboBoxOfficeComputer.Text,textBoxIPComputer.Text, comboBoxModelComputer.Text,
                            comboBoxCPUComputer.Text, comboBoxRAMComputer.Text, comboBoxHardDriveComputer.Text,
                            richTextBoxComentsComputer.Text,dateTimePickerPurchaseDateComputer.Value,
                            dateTimePickerWarrantyDateComputer.Value); // if != null
        }  
        private void buttonCloseComputer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxAddNewUser.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            groupBoxAddNewUser.Visible = false;
        }
        #endregion

        #region Label link add new _values

        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxModelComputer(comboBoxModelComputer.Text);  // if != null 
            UploadData();
        }

        private void linkLabelAddNewRAM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxRAM(comboBoxRAMComputer.Text);  // if != null
            UploadData();
        }

        private void linkLabelAddNewHardDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxHardDrive(comboBoxHardDriveComputer.Text);  // if != null
            UploadData();
        }

        private void linkLabelAddNewOperatingSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxOperatingSystem(comboBoxOperatigSystemComputer.Text);  // if != null
            UploadData();
        }

        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxLocation(comboBoxLocationComputer.Text);  // if != null
            UploadData();
        }

        private void linkLabelAddNewMicrosoftOffice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxMicrosoftOffice(comboBoxOfficeComputer.Text);  // if != null
            UploadData();
        }
        private void linkLabelAddNewCPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxCPU(comboBoxCPUComputer.Text);  // if != null
            UploadData();
        }

        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text);  // if != null
            UploadData();
        }
        #endregion

 
    }
}
