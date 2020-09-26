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
    public partial class AddMonitorForms : Form
    {
        private readonly IMonitorsLogic _monitorsLogic;

        public AddMonitorForms(IMonitorsLogic monitorsLogic)
        {
            this._monitorsLogic = monitorsLogic;
            InitializeComponent();
            UploadData();

            groupBoxAddNewUser.Visible = false;
            buttonInsertDataMonitors.Enabled = false;

            VisibleLabelLink(false);
        }

        #region Upload
        private void UploadData()
        {
            comboBoxLocationMonitors.DataSource = _monitorsLogic.FillComboBoxLocation().ToList();
            AutoSugestComplet(comboBoxLocationMonitors);

            comboBoxModelMonitors.DataSource = _monitorsLogic.FillComboBoxModelMonitors().ToList();
            AutoSugestComplet(comboBoxModelMonitors);

            comboBoxUsers.DataSource = _monitorsLogic.FillComboBoxUsers().ToList();
            AutoSugestComplet(comboBoxUsers);

            comboBoxEquState.DataSource = _monitorsLogic.FillComboBoxEquipmentStatus().ToList();
            AutoSugestComplet(comboBoxEquState);
        }
        #endregion

        #region Insert
        private void buttonInsertDataMonitors_Click(object sender, EventArgs e)
        {
            var bitmapDataBarcode = CustomConvertToBinary.ImgToBinary(pictureBoxBarcode);
            var bitmapDataQRCode = CustomConvertToBinary.ImgToBinary(pictureBoxQRCode);

            _monitorsLogic?.Insert(textBoxCompanyFixedAssetMonitors.Text, textBoxTagServiceMonitors.Text,
                comboBoxLocationMonitors.Text, comboBoxUsers.Text, comboBoxModelMonitors.Text,
                richTextBoxComentsMonitors.Text, dateTimePickerWarrantyDateMonitors.Value.Date, dateTimePickerPurchaseDateMonitors.Value.Date,
                 bitmapDataBarcode, bitmapDataQRCode, comboBoxEquState.Text); 
        }
        #endregion

        #region Create Code
        private void buttonCreateQR_Click(object sender, EventArgs e)
        {
            labelDateTimeCode.Text = DateTime.Now.ToString();
            labelCompanyFixedCode.Text = textBoxCompanyFixedAssetMonitors.Text;
            labelModelCode.Text = comboBoxModelMonitors.Text;
            labelTahServiceCode.Text = textBoxTagServiceMonitors.Text;

            CustomCreateCode.CreateQRCode(pictureBoxQRCode, textBoxCompanyFixedAssetMonitors, textBoxTagServiceMonitors, comboBoxModelMonitors);

            CustomCreateCode.CreateBarcodeCode(pictureBoxBarcode, textBoxCompanyFixedAssetMonitors);

            buttonInsertDataMonitors.Enabled = true;
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
            CustomBorder.PaintBorderPictureBox(sender, e);
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
        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic?.InsertComboBoxLocation(comboBoxLocationMonitors.Text); 
            UploadData();
        }

        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic?.InsertComboBoxModelMonitor(comboBoxModelMonitors.Text); 
            UploadData();
        }
        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic?.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text); 
            UploadData();
        }
        private void linkLabelEquState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic?.InsertComboEquipmentStatus(comboBoxEquState.Text);  
            UploadData();
        }

        #endregion

        #region HelperMethod
        private void VisibleLabelLink(bool visible)
        {
            linkLabelEquState.Visible = visible;
            linkLabelEquState.Visible = visible;
            linkLabelAddNewLocation.Visible = visible;
            linkLabelAddNewModel.Visible = visible;
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
