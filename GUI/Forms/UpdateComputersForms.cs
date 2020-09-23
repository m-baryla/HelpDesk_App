﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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

            linkLabelEquState.Visible = false;
            linkLabelAddNewCPU.Visible = false;
            linkLabelAddNewHardDrive.Visible = false;
            linkLabelAddNewLocation.Visible = false;
            linkLabelAddNewMicrosoftOffice.Visible = false;
            linkLabelAddNewModel.Visible = false;
            linkLabelAddNewOperatingSystem.Visible = false;
            linkLabelAddNewRAM.Visible = false;
            linkLabelAddNewUser.Visible = false;
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

            comboBoxEquState.DataSource = _computersLogic.FillComboBoxEquipmentStatus().ToList();
            comboBoxEquState.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxEquState.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        #region COMBOBOX DATA
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

        #region BUTTON
        private void buttonUpdateDataComputer_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            pictureBoxBarcode.Image.Save(ms, ImageFormat.Png);
            var bitmapDataBarcode = ms.ToArray();

            pictureBoxQRCode.Image.Save(ms, ImageFormat.Png);
            var bitmapDataQRCode = ms.ToArray();

            _computersLogic.Update(Convert.ToInt32(textBoxIDComputer.Text), textBoxNameComputer.Text,comboBoxOperatigSystemComputer.Text,
                    textBoxCompanyFixedAssetComputer.Text, textBoxTagServiceComputer.Text,comboBoxLocationComputer.Text,
                    comboBoxUser.Text, comboBoxOfficeComputer.Text,textBoxIPComputer.Text, comboBoxModelComputer.Text,
                    comboBoxCPUComputer.Text, comboBoxRAMComputer.Text,comboBoxHardDriveComputer.Text,richTextBoxComentsComputer.Text,
                    dateTimePickerWarrantyDateComputer.Value.Date, dateTimePickerPurchaseDateComputer.Value.Date,
                    bitmapDataBarcode, bitmapDataQRCode, comboBoxEquState.Text);
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

            PictureBox panel = (PictureBox)sender;
            float width = (float)4.0;
            Pen pen = new Pen(Color.DarkRed, width) {DashStyle = DashStyle.DashDotDot};
            e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
        }

        private void pictureBoxBarcode_Paint(object sender, PaintEventArgs e)
        {

            PictureBox panel = (PictureBox)sender;
            float width = (float)4.0;
            Pen pen = new Pen(Color.DarkRed, width) {DashStyle = DashStyle.DashDotDot};
            e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
        }
        private void buttonCreateQR_Click(object sender, EventArgs e)
        {
            labelDateTimeCode.Text = DateTime.Now.ToString();
            labelCompanyFixedCode.Text = textBoxCompanyFixedAssetComputer.Text;
            labelModelCode.Text = comboBoxModelComputer.Text;
            labelTahServiceCode.Text = textBoxTagServiceComputer.Text;

            Zen.Barcode.CodeQrBarcodeDraw qrBarcodeDraw = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBoxQRCode.Image = qrBarcodeDraw.Draw(textBoxCompanyFixedAssetComputer.Text
                                                        + " " +
                                                        textBoxTagServiceComputer.Text
                                                        + " " +
                                                        comboBoxModelComputer.Text, pictureBoxQRCode.Width);

            Zen.Barcode.Code128BarcodeDraw barcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBoxBarcode.Image = barcodeDraw.Draw(textBoxCompanyFixedAssetComputer.Text, pictureBoxBarcode.Height);

            buttonUpdateDataComputer.Enabled = true;
        }
        private void buttonSaveAsJPG_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog {Filter = "JPG(*.JPG)|*.jpg"};

            if (f.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(paneLabelCode.Width + 50, paneLabelCode.Height + paneLabelCode.Height / 2);
                paneLabelCode.DrawToBitmap(bmp, paneLabelCode.Bounds);
                bmp.Save(f.FileName);
            }
        }
        #endregion

        #region LABEL LINK ADD NEW --VALUES

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
            _computersLogic.InsertComboEquipmentStatus(comboBoxEquState.Text);  // if != null
            UploadData();
        }

        #endregion

        private void radioButtonLabelLinkON_CheckedChanged(object sender, EventArgs e)
        {
            linkLabelEquState.Visible = true;
            linkLabelAddNewCPU.Visible = true;
            linkLabelAddNewHardDrive.Visible = true;
            linkLabelAddNewLocation.Visible = true;
            linkLabelAddNewMicrosoftOffice.Visible = true;
            linkLabelAddNewModel.Visible = true;
            linkLabelAddNewOperatingSystem.Visible = true;
            linkLabelAddNewRAM.Visible = true;
            linkLabelAddNewUser.Visible = true;
        }

        private void radioButtonLabelLinkOFF_CheckedChanged(object sender, EventArgs e)
        {
            linkLabelEquState.Visible = false;
            linkLabelAddNewCPU.Visible = false;
            linkLabelAddNewHardDrive.Visible = false;
            linkLabelAddNewLocation.Visible = false;
            linkLabelAddNewMicrosoftOffice.Visible = false;
            linkLabelAddNewModel.Visible = false;
            linkLabelAddNewOperatingSystem.Visible = false;
            linkLabelAddNewRAM.Visible = false;
            linkLabelAddNewUser.Visible = false;
        }
    }
}
