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
    public partial class UpdateMonitorsForms : Form
    {
        private readonly IMonitorsLogic _monitorsLogic;

        public UpdateMonitorsForms(IMonitorsLogic monitorsLogic)
        {
            this._monitorsLogic = monitorsLogic;
            InitializeComponent();
            UploadData();

            groupBoxAddNewUser.Visible = false;
            buttonUpdateDataMonitor.Enabled = false;

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

        #region ComboBox Data from DataGrindView
        public void EditDataLoad(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView)
        {
            var dialogResult = MessageBox.Show("Do you want to edit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                    {
                        DataGridViewRow dgViewRow = advancedDataGridView.Rows[e.RowIndex];

                        // [UpdateMonitorsDataViev] must be like the view as [vwAll_Monitors]
                        comboBoxEquState.Text = dgViewRow.Cells[1].Value.ToString();
                        textBoxIDMonitor.Text = dgViewRow.Cells[2].Value.ToString();
                        textBoxTagServiceMonitors.Text = dgViewRow.Cells[3].Value.ToString();
                        dateTimePickerWarrantyDateMonitors.Value = Convert.ToDateTime(dgViewRow.Cells[4].Value);
                        dateTimePickerPurchaseDateMonitors.Value = Convert.ToDateTime(dgViewRow.Cells[5].Value);
                        richTextBoxComentsMonitors.Text = dgViewRow.Cells[6].Value.ToString();
                        textBoxCompanyFixedAssetMonitors.Text = dgViewRow.Cells[7].Value.ToString();
                        textBoxFirstName.Text = dgViewRow.Cells[8].Value.ToString();
                        textBoxLastName.Text = dgViewRow.Cells[9].Value.ToString();
                        textBoxJob.Text = dgViewRow.Cells[10].Value.ToString();
                        comboBoxLocationMonitors.Text = dgViewRow.Cells[11].Value.ToString();
                        comboBoxModelMonitors.Text = dgViewRow.Cells[12].Value.ToString();
                        break;
                    }
                    case DialogResult.No:
                    {
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Update
        private void buttonUpdateDataMonitor_Click(object sender, EventArgs e)
        {
            var bitmapDataBarcode = CustomConvertToBinary.ImgToBinary(pictureBoxBarcode);
            var bitmapDataQRCode = CustomConvertToBinary.ImgToBinary(pictureBoxQRCode);

            _monitorsLogic.Update(Convert.ToInt32(textBoxIDMonitor.Text), textBoxCompanyFixedAssetMonitors.Text, 
                textBoxTagServiceMonitors.Text,comboBoxLocationMonitors.Text, comboBoxUsers.Text, comboBoxModelMonitors.Text, 
                richTextBoxComentsMonitors.Text, dateTimePickerWarrantyDateMonitors.Value.Date,
                dateTimePickerPurchaseDateMonitors.Value.Date, bitmapDataBarcode, bitmapDataQRCode, comboBoxEquState.Text);
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

            buttonUpdateDataMonitor.Enabled = false;
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
            _monitorsLogic.InsertComboBoxModelMonitor(comboBoxModelMonitors.Text);
            UploadData();
        }

        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic.InsertComboBoxLocation(comboBoxLocationMonitors.Text);
            UploadData();
        }
        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text);
            comboBoxUsers.DataSource = _monitorsLogic.FillComboBoxUsers().ToList();
            comboBoxUsers.Text = textBoxFirstName.Text + " " + textBoxLastName.Text;
        }
        private void linkLabelEquState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic.InsertComboEquipmentStatus(comboBoxEquState.Text);  // if != null
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
