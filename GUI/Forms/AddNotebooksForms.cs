using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GUI.CustomClass;
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
            buttonInsertDataNotebooks.Enabled = false;

            VisibleLabelLink(false);
        }

        #region Upload
        private void UploadData()
        {
            comboBoxLocationNotebook.DataSource = _notebooksLogic.FillComboBoxLocation().ToList();
            AutoSugestComplet(comboBoxLocationNotebook);

            comboBoxModelNotebook.DataSource = _notebooksLogic.FillComboBoxModelNotebooks().ToList();
            AutoSugestComplet(comboBoxModelNotebook);

            comboBoxCPUNotebook.DataSource = _notebooksLogic.FillComboBoxCPU().ToList();
            AutoSugestComplet(comboBoxCPUNotebook);

            comboBoxRAMNotebook.DataSource = _notebooksLogic.FillComboBoxRAM().ToList();
            AutoSugestComplet(comboBoxRAMNotebook);

            comboBoxHardDriveNotebook.DataSource = _notebooksLogic.FillComboBoxHardDrive().ToList();
            AutoSugestComplet(comboBoxHardDriveNotebook);

            comboBoxOfficeNotebook.DataSource = _notebooksLogic.FillComboBoxOffice().ToList();
            AutoSugestComplet(comboBoxOfficeNotebook);

            comboBoxOperatigSystemNotebook.DataSource = _notebooksLogic.FillComboBoxOperatingSystem().ToList();
            AutoSugestComplet(comboBoxOperatigSystemNotebook);

            comboBoxUsers.DataSource = _notebooksLogic.FillComboBoxUsers().ToList();
            AutoSugestComplet(comboBoxUsers);

            comboBoxEquState.DataSource = _notebooksLogic.FillComboBoxEquipmentStatus().ToList();
            AutoSugestComplet(comboBoxEquState);
        }
        #endregion

        #region Insert
        private void buttonInsertDataNotebooks_Click(object sender, EventArgs e)
        {
            var strIP = ip_1.Text + '.' + ip_2.Text + '.' + ip_3.Text + '.' + ip_4.Text;

            var bitmapDataBarcode = CustomConvertToBinary.ImgToBinary(pictureBoxBarcode);
            var bitmapDataQRCode = CustomConvertToBinary.ImgToBinary(pictureBoxQRCode);

            _notebooksLogic?.Insert(textBoxNameNotebook.Text, comboBoxOperatigSystemNotebook.Text,
                    textBoxCompanyFixedAssetNotebook.Text, textBoxTagServiceNotebook.Text,
                    comboBoxLocationNotebook.Text, comboBoxUsers.Text,
                    comboBoxOfficeNotebook.Text, strIP, comboBoxModelNotebook.Text,
                    comboBoxCPUNotebook.Text, comboBoxRAMNotebook.Text, comboBoxHardDriveNotebook.Text,
                    richTextBoxComentsNotebook.Text, dateTimePickerWarrantyDateNotebook.Value.Date,
                    dateTimePickerPurchaseDateNotebook.Value.Date, bitmapDataBarcode, bitmapDataQRCode, comboBoxEquState.Text); 
        }
        #endregion

        #region Create Code
        private void buttonCreateQR_Click(object sender, EventArgs e)
        {
            labelDateTimeCode.Text = DateTime.Now.ToString();
            labelCompanyFixedCode.Text = textBoxCompanyFixedAssetNotebook.Text;
            labelModelCode.Text = comboBoxModelNotebook.Text;
            labelTahServiceCode.Text = textBoxTagServiceNotebook.Text;

            CustomCreateCode.CreateQRCode(pictureBoxQRCode, textBoxCompanyFixedAssetNotebook, textBoxTagServiceNotebook, comboBoxModelNotebook);

            CustomCreateCode.CreateBarcodeCode(pictureBoxBarcode, textBoxCompanyFixedAssetNotebook);

            buttonInsertDataNotebooks.Enabled = true;
        }
        #endregion

        #region Buttons

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
        private void pictureBoxQRCode_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderPictureBox(sender,e);
        }
        private void pictureBoxBarcode_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderPictureBox(sender, e);
        }
        private void buttonSaveAsJPG_Click(object sender, EventArgs e)
        {
            CustomSaveFileDialog.SaveFile(paneLabelCode);
        }
        private void radioButtonLabelLinkON_CheckedChanged(object sender, EventArgs e)
        {
            VisibleLabelLink(true);
        }
        private void radioButtonLabelLinkOFF_CheckedChanged(object sender, EventArgs e)
        {
            VisibleLabelLink(false);
        }
        #endregion

        #region Label link add new values
        private void linkLabelAddNewOffice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxMicrosoftOffice(comboBoxOfficeNotebook.Text); 
            UploadData();
        }
        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxLocation(comboBoxLocationNotebook.Text); 
            UploadData();
        }
        private void linkLabelAddNewOperatingSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxOperatingSystem(comboBoxOperatigSystemNotebook.Text); 
            UploadData();
        }
        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxModelNotebook(comboBoxModelNotebook.Text); 
            UploadData();
        }
        private void linkLabelAddNewCPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxCPU(comboBoxCPUNotebook.Text); 
            UploadData();
        }
        private void linkLabelAddNewRAM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxRAM(comboBoxRAMNotebook.Text); 
            UploadData();
        }
        private void linkLabelAddNewHardDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxHardDrive(comboBoxHardDriveNotebook.Text); 
            UploadData();
        }
        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text); 
            UploadData();
        }
        private void linkLabelEquState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboEquipmentStatus(comboBoxEquState.Text);  
            UploadData();
        }
        #endregion

        #region HelperMethod
        private void VisibleLabelLink(bool visible)
        {
            linkLabelEquState.Visible = visible;
            linkLabelAddNewCPU.Visible = visible;
            linkLabelAddNewHardDrive.Visible = visible;
            linkLabelAddNewLocation.Visible = visible;
            linkLabelAddNewOffice.Visible = visible;
            linkLabelAddNewModel.Visible = visible;
            linkLabelAddNewOperatingSystem.Visible = visible;
            linkLabelAddNewRAM.Visible = visible;
            linkLabelAddNewUser.Visible = visible;
        }
        private void AutoSugestComplet(ComboBox comboBox)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        #endregion
    }
}
