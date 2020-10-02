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
    public partial class UpdateNotebooksForms : Form
    {
        private readonly INotebooksLogic _notebooksLogic;

        public UpdateNotebooksForms(INotebooksLogic notebooksLogic)
        {
            this._notebooksLogic = notebooksLogic;
            InitializeComponent();
            UploadData();

            groupBoxAddNewUser.Visible = false;
            buttonUpdateDataNotebooks.Enabled = false;

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

        #region ComboBox Data from DataGrindView
        public void EditDataLoad(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView)
        {
          
            DataGridViewRow dgViewRow = advancedDataGridView.Rows[e.RowIndex];

            // [UpdateNotebooksDataViev] must be like the view as [vwAll_Notebooks]
            comboBoxEquState.Text = dgViewRow.Cells[1].Value.ToString();
            textBoxIDNotebooks.Text = dgViewRow.Cells[2].Value.ToString();
            textBoxNameNotebook.Text = dgViewRow.Cells[3].Value.ToString();
            textBoxTagServiceNotebook.Text = dgViewRow.Cells[4].Value.ToString();
            textBoxIPNotebook.Text = dgViewRow.Cells[5].Value.ToString();
            dateTimePickerWarrantyDateNotebook.Value = Convert.ToDateTime(dgViewRow.Cells[6].Value);
            dateTimePickerPurchaseDateNotebook.Value = Convert.ToDateTime(dgViewRow.Cells[7].Value);
            richTextBoxComentsNotebook.Text = dgViewRow.Cells[8].Value.ToString();
            textBoxCompanyFixedAssetNotebook.Text = dgViewRow.Cells[9].Value.ToString();
            textBoxFirstName.Text = dgViewRow.Cells[10].Value.ToString();
            textBoxLastName.Text = dgViewRow.Cells[11].Value.ToString();
            textBoxJob.Text = dgViewRow.Cells[12].Value.ToString();
            comboBoxCPUNotebook.Text = dgViewRow.Cells[13].Value.ToString();
            comboBoxHardDriveNotebook.Text = dgViewRow.Cells[14].Value.ToString();
            comboBoxLocationNotebook.Text = dgViewRow.Cells[15].Value.ToString();
            comboBoxOfficeNotebook.Text = dgViewRow.Cells[16].Value.ToString();
            comboBoxModelNotebook.Text = dgViewRow.Cells[17].Value.ToString();
            comboBoxOperatigSystemNotebook.Text = dgViewRow.Cells[18].Value.ToString();
            comboBoxRAMNotebook.Text = dgViewRow.Cells[19].Value.ToString();
      
        }
        #endregion

        #region Update
        private void buttonUpdateDataNotebooks_Click(object sender, EventArgs e)
        {
            var bitmapDataBarcode = CustomConvertToBinary.ImgToBinary(pictureBoxBarcode);
            var bitmapDataQRCode = CustomConvertToBinary.ImgToBinary(pictureBoxQRCode);

            _notebooksLogic.Update(Convert.ToInt32(textBoxIDNotebooks.Text), textBoxNameNotebook.Text,
                    comboBoxOperatigSystemNotebook.Text, textBoxCompanyFixedAssetNotebook.Text, textBoxTagServiceNotebook.Text,
                    comboBoxLocationNotebook.Text, comboBoxUsers.Text, comboBoxOfficeNotebook.Text,
                    textBoxIPNotebook.Text, comboBoxModelNotebook.Text, comboBoxCPUNotebook.Text, comboBoxRAMNotebook.Text,
                    comboBoxHardDriveNotebook.Text, richTextBoxComentsNotebook.Text,
                    dateTimePickerWarrantyDateNotebook.Value.Date, dateTimePickerPurchaseDateNotebook.Value.Date,
                    bitmapDataBarcode, bitmapDataQRCode, comboBoxEquState.Text);
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

            buttonUpdateDataNotebooks.Enabled = true;
        }
        #endregion

        #region Buttons
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
        private void linkLabelAddNewOperatingSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxOperatingSystem(comboBoxOperatigSystemNotebook.Text);
            UploadData();
        }
        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxLocation(comboBoxLocationNotebook.Text);
            UploadData();
        }
        private void linkLabelAddNewMicrosoftOffice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxMicrosoftOffice(comboBoxOfficeNotebook.Text);
            UploadData();
        }
        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text);
            comboBoxUsers.DataSource = _notebooksLogic.FillComboBoxUsers().ToList();
            comboBoxUsers.Text = textBoxFirstName.Text + " " + textBoxLastName.Text;
        }
        private void linkLabelEquState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboEquipmentStatus(comboBoxEquState.Text);  // if != null
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
        private void tabPageEquipmentNotebooks_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(tabPageEquipmentNotebooks, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void tabPageComentsNotebooks_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(tabPageComentsNotebooks, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void tabPageBarcodeNotebooks_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(tabPageBarcodeNotebooks, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }

        private void panelUpdateNotebooks_Paint(object sender, PaintEventArgs e)
        {
            CustomPaintBackgound.PanelBackgruondPanit(panelUpdateNotebooks, e, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
        }
        #endregion

    }
}
