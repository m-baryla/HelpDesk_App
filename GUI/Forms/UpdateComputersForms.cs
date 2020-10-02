using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GUI.CustomClass;
using Interfaces;
using Zuby.ADGV;

namespace GUI.Forms
{
    public partial class UpdateComputersForms : Form
    {
        private readonly IComputersLogic _computersLogic;
        public UpdateComputersForms(IComputersLogic computersLogic)
        {
            this._computersLogic = computersLogic;
            InitializeComponent();
            UploadData();

            groupBoxAddNewUser.Visible = false;
            buttonUpdateDataComputer.Enabled = false;

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
        }
        #endregion

        #region ComboBox Data from DataGrindView
        public void EditDataLoad(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView)
        {
             DataGridViewRow dgViewRow = advancedDataGridView.Rows[e.RowIndex];

            // [UpdateComputersDataViev] must be like the view as [vwAll_Computers]
            comboBoxEquState.Text = dgViewRow.Cells[1].Value.ToString();
            textBoxIDComputer.Text = dgViewRow.Cells[2].Value.ToString();
            textBoxNameComputer.Text = dgViewRow.Cells[3].Value.ToString();
            textBoxTagServiceComputer.Text = dgViewRow.Cells[4].Value.ToString();
            textBoxIPComputer.Text = dgViewRow.Cells[5].Value.ToString();
            dateTimePickerWarrantyDateComputer.Value = Convert.ToDateTime(dgViewRow.Cells[6].Value);
            dateTimePickerPurchaseDateComputer.Value = Convert.ToDateTime(dgViewRow.Cells[7].Value);
            richTextBoxComentsComputer.Text = dgViewRow.Cells[8].Value.ToString();
            textBoxCompanyFixedAssetComputer.Text = dgViewRow.Cells[9].Value.ToString();
            textBoxFirstName.Text = dgViewRow.Cells[10].Value.ToString();
            textBoxLastName.Text = dgViewRow.Cells[11].Value.ToString();
            textBoxJob.Text = dgViewRow.Cells[12].Value.ToString();
            comboBoxCPUComputer.Text = dgViewRow.Cells[13].Value.ToString();
            comboBoxHardDriveComputer.Text = dgViewRow.Cells[14].Value.ToString();
            comboBoxLocationComputer.Text = dgViewRow.Cells[15].Value.ToString();
            comboBoxOfficeComputer.Text = dgViewRow.Cells[16].Value.ToString();
            comboBoxModelComputer.Text = dgViewRow.Cells[17].Value.ToString();
            comboBoxOperatigSystemComputer.Text = dgViewRow.Cells[18].Value.ToString();
            comboBoxRAMComputer.Text = dgViewRow.Cells[19].Value.ToString();
                     
        }
        #endregion

        #region Update
        private void buttonUpdateDataComputer_Click(object sender, EventArgs e)
        {
            var bitmapDataBarcode = CustomConvertToBinary.ImgToBinary(pictureBoxBarcode);
            var bitmapDataQRCode = CustomConvertToBinary.ImgToBinary(pictureBoxQRCode);

            _computersLogic.Update(Convert.ToInt32(textBoxIDComputer.Text), textBoxNameComputer.Text, comboBoxOperatigSystemComputer.Text,
                    textBoxCompanyFixedAssetComputer.Text, textBoxTagServiceComputer.Text, comboBoxLocationComputer.Text,
                    comboBoxUser.Text, comboBoxOfficeComputer.Text, textBoxIPComputer.Text, comboBoxModelComputer.Text,
                    comboBoxCPUComputer.Text, comboBoxRAMComputer.Text, comboBoxHardDriveComputer.Text, richTextBoxComentsComputer.Text,
                    dateTimePickerWarrantyDateComputer.Value.Date, dateTimePickerPurchaseDateComputer.Value.Date,
                    bitmapDataBarcode, bitmapDataQRCode, comboBoxEquState.Text);
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

            buttonUpdateDataComputer.Enabled = true;
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
        #endregion

        #region Label link add new values

        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxModelComputer(comboBoxModelComputer.Text);
            UploadData();
        }
        private void linkLabelAddNewCPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxCPU(comboBoxCPUComputer.Text);
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
        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboBoxUser(textBoxFirstName.Text,textBoxLastName.Text,textBoxJob.Text);
            comboBoxUser.DataSource = _computersLogic.FillComboBoxUsers().ToList();
            comboBoxUser.Text = textBoxFirstName.Text + " " + textBoxLastName.Text;

        }
        private void linkLabelEquState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboEquipmentStatus(comboBoxEquState.Text);  
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
        private void tabPageUpdateForms_Paint_1(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(tabPageUpdateForms, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void tabPageComentsComputer_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(tabPageComentsComputer, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void tabPageBarcodeComputer_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(tabPageBarcodeComputer, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void panelUpdateComputer_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(panelUpdateComputer, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        #endregion

    }
}
