using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using GUI.CustomClass;
using Interfaces;

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
            buttonInsertDataComputer.Enabled = false;

            VisibleLabelLink(false);
        }

        #region Upload 
        private void UploadData()
        {
            comboBoxLocationComputer.DataSource = _computersLogic.FillComboBoxLocation().ToList();
            AutoSugestComplet(comboBoxLocationComputer);

            comboBoxModelComputer.DataSource = _computersLogic.FillComboBoxModelComputer().ToList();
            AutoSugestComplet(comboBoxModelComputer);

            comboBoxCPUComputer.DataSource = _computersLogic.FillComboBoxCPU().ToList();
            AutoSugestComplet(comboBoxCPUComputer);

            comboBoxRAMComputer.DataSource = _computersLogic.FillComboBoxRAM().ToList();
            AutoSugestComplet(comboBoxRAMComputer);

            comboBoxHardDriveComputer.DataSource = _computersLogic.FillComboBoxHardDrive().ToList();
            AutoSugestComplet(comboBoxHardDriveComputer);

            comboBoxOfficeComputer.DataSource = _computersLogic.FillComboBoxOffice().ToList();
            AutoSugestComplet(comboBoxOfficeComputer);

            comboBoxOperatigSystemComputer.DataSource = _computersLogic.FillComboBoxOperatingSystem().ToList();
            AutoSugestComplet(comboBoxOperatigSystemComputer);

            comboBoxUser.DataSource = _computersLogic.FillComboBoxUsers().ToList();
            AutoSugestComplet(comboBoxUser);

            comboBoxEquState.DataSource = _computersLogic.FillComboBoxEquipmentStatus().ToList();
            AutoSugestComplet(comboBoxEquState);
            ///
        }
        #endregion

        #region Insert
        private void buttonInsertDataComputer_Click(object sender, EventArgs e)
        {
            var strIP = ip_1.Text + '.' + ip_2.Text + '.' + ip_3.Text + '.' + ip_4.Text;

            var bitmapDataBarcode = CustomConvertToBinary.ImgToBinary(pictureBoxBarcode);
            var bitmapDataQRCode = CustomConvertToBinary.ImgToBinary(pictureBoxQRCode);

            _computersLogic?.Insert(textBoxNameComputer.Text, comboBoxOperatigSystemComputer.Text,
                textBoxCompanyFixedAssetComputer.Text, textBoxTagServiceComputer.Text,
                comboBoxLocationComputer.Text, comboBoxUser.Text,
                comboBoxOfficeComputer.Text, strIP, comboBoxModelComputer.Text,
                comboBoxCPUComputer.Text, comboBoxRAMComputer.Text, comboBoxHardDriveComputer.Text,
                richTextBoxComentsComputer.Text, dateTimePickerWarrantyDateComputer.Value.Date, dateTimePickerPurchaseDateComputer.Value.Date,
                bitmapDataBarcode, bitmapDataQRCode, comboBoxEquState.Text); // if != null
        }
        #endregion

        #region Create Code
        private void buttonCreateQR_Click(object sender, EventArgs e)
        {
            labelDateTimeCode.Text = DateTime.Now.ToString();
            labelCompanyFixedCode.Text = textBoxCompanyFixedAssetComputer.Text;
            labelModelCode.Text = comboBoxModelComputer.Text;
            labelTahServiceCode.Text = textBoxTagServiceComputer.Text;

            CustomCreateCode.CreateQRCode(pictureBoxQRCode, textBoxCompanyFixedAssetComputer, textBoxTagServiceComputer, comboBoxModelComputer);

            CustomCreateCode.CreateBarcodeCode(pictureBoxBarcode, textBoxCompanyFixedAssetComputer);

            buttonInsertDataComputer.Enabled = true;
        }
        #endregion

        #region Buttons

        private void radioButtonLabelLinkON_CheckedChanged(object sender, EventArgs e)
        {
            VisibleLabelLink(true);
        }
        private void radioButtonLabelLinkOFF_CheckedChanged(object sender, EventArgs e)
        {
            VisibleLabelLink(false);
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
        private void pictureBoxBarcode_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderPictureBox(sender, e);
        }
        private void pictureBoxQRCode_Paint(object sender, PaintEventArgs e)
        {
            CustomBorder.PaintBorderPictureBox(sender, e);
        }
        private void buttonSaveAsJPG_Click(object sender, EventArgs e)
        {
            CustomSaveFileDialog.SaveFile(paneLabelCode);
        }
        #endregion

        #region Label link add new values

        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic?.InsertComboBoxModelComputer(comboBoxModelComputer.Text);  
            UploadData();
        }

        private void linkLabelAddNewRAM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic?.InsertComboBoxRAM(comboBoxRAMComputer.Text);  
            UploadData();
        }

        private void linkLabelAddNewHardDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic?.InsertComboBoxHardDrive(comboBoxHardDriveComputer.Text);  
            UploadData();
        }

        private void linkLabelAddNewOperatingSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic?.InsertComboBoxOperatingSystem(comboBoxOperatigSystemComputer.Text);  
            UploadData();
        }

        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic?.InsertComboBoxLocation(comboBoxLocationComputer.Text);  
            UploadData();
        }

        private void linkLabelAddNewMicrosoftOffice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic?.InsertComboBoxMicrosoftOffice(comboBoxOfficeComputer.Text);  
            UploadData();
        }
        private void linkLabelAddNewCPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic?.InsertComboBoxCPU(comboBoxCPUComputer.Text);  
            UploadData();
        }

        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic?.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text);  
            UploadData();
        }

        private void linkLabelEquState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic?.InsertComboEquipmentStatus(comboBoxEquState.Text);  
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
            linkLabelAddNewMicrosoftOffice.Visible = visible;
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

        #region Paint
        private void tabPageInsertForm_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(tabPageInsertForm, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void tabPageComentsComputer_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(tabPageComentsComputer, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void tabPageBarcodeComputer_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(tabPageBarcodeComputer, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void panelAddNewComputer_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(panelAddNewComputer, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }
        #endregion

    }
}
