﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
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
            groupBoxAddNewUser.Visible = false;
            buttonInsertDataNotebooks.Enabled = false;

            linkLabelEquState.Visible = false;
            linkLabelAddNewCPU.Visible = false;
            linkLabelAddNewHardDrive.Visible = false;
            linkLabelAddNewLocation.Visible = false;
            linkLabelAddNewOffice.Visible = false;
            linkLabelAddNewModel.Visible = false;
            linkLabelAddNewOperatingSystem.Visible = false;
            linkLabelAddNewRAM.Visible = false;
            linkLabelAddNewUser.Visible = false;


        }

        private void UploadData()
        {
            comboBoxLocationNotebook.DataSource = _notebooksLogic.FillComboBoxLocation().ToList();
            comboBoxLocationNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxLocationNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxModelNotebook.DataSource = _notebooksLogic.FillComboBoxModelNotebooks().ToList();
            comboBoxModelNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxModelNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxCPUNotebook.DataSource = _notebooksLogic.FillComboBoxCPU().ToList();
            comboBoxCPUNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCPUNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxRAMNotebook.DataSource = _notebooksLogic.FillComboBoxRAM().ToList();
            comboBoxRAMNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxRAMNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxHardDriveNotebook.DataSource = _notebooksLogic.FillComboBoxHardDrive().ToList();
            comboBoxHardDriveNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxHardDriveNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxOfficeNotebook.DataSource = _notebooksLogic.FillComboBoxOffice().ToList();
            comboBoxOfficeNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxOfficeNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxOperatigSystemNotebook.DataSource = _notebooksLogic.FillComboBoxOperatingSystem().ToList();
            comboBoxOperatigSystemNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxOperatigSystemNotebook.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxUsers.DataSource = _notebooksLogic.FillComboBoxUsers().ToList();
            comboBoxUsers.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxUsers.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxEquState.DataSource = _notebooksLogic.FillComboBoxEquipmentStatus().ToList();
            comboBoxEquState.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxEquState.AutoCompleteSource = AutoCompleteSource.ListItems;
            ///
        }

        #region Button
        private void buttonInsertDataNotebooks_Click(object sender, EventArgs e)
        {
            var strIP = ip_1.Text + '.' + ip_2.Text + '.' + ip_3.Text + '.' + ip_4.Text;

            MemoryStream ms = new MemoryStream();

            pictureBoxBarcode.Image.Save(ms, ImageFormat.Png);
            var bitmapDataBarcode = ms.ToArray();

            pictureBoxQRCode.Image.Save(ms, ImageFormat.Png);
            var bitmapDataQRCode = ms.ToArray();

            _notebooksLogic?.Insert(textBoxNameNotebook.Text, comboBoxOperatigSystemNotebook.Text,
                    textBoxCompanyFixedAssetNotebook.Text, textBoxTagServiceNotebook.Text,
                    comboBoxLocationNotebook.Text, comboBoxUsers.Text,
                    comboBoxOfficeNotebook.Text, strIP, comboBoxModelNotebook.Text,
                    comboBoxCPUNotebook.Text, comboBoxRAMNotebook.Text, comboBoxHardDriveNotebook.Text,
                    richTextBoxComentsNotebook.Text,dateTimePickerWarrantyDateNotebook.Value.Date,
                    dateTimePickerPurchaseDateNotebook.Value.Date, bitmapDataBarcode, bitmapDataQRCode, comboBoxEquState.Text); // if != null
        }
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
        private void buttonCreateQR_Click(object sender, EventArgs e)
        {

            labelDateTimeCode.Text = DateTime.Now.ToString();
            labelCompanyFixedCode.Text = textBoxCompanyFixedAssetNotebook.Text;
            labelModelCode.Text = comboBoxModelNotebook.Text;
            labelTahServiceCode.Text = textBoxTagServiceNotebook.Text;

            Zen.Barcode.CodeQrBarcodeDraw qrBarcodeDraw = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBoxQRCode.Image = qrBarcodeDraw.Draw(textBoxCompanyFixedAssetNotebook.Text
                                                        + " " +
                                                        textBoxTagServiceNotebook.Text
                                                        + " " +
                                                        comboBoxModelNotebook.Text, pictureBoxQRCode.Width);

            Zen.Barcode.Code128BarcodeDraw barcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBoxBarcode.Image = barcodeDraw.Draw(textBoxCompanyFixedAssetNotebook.Text, pictureBoxBarcode.Height);

            buttonInsertDataNotebooks.Enabled = true;

        }
        private void pictureBoxQRCode_Paint(object sender, PaintEventArgs e)
        {
            PictureBox panel = (PictureBox)sender;
            float width = (float)4.0;
            Pen pen = new Pen(Color.DarkRed, width);
            pen.DashStyle = DashStyle.DashDotDot;
            e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
        }

        private void pictureBoxBarcode_Paint(object sender, PaintEventArgs e)
        {
            PictureBox panel = (PictureBox)sender;
            float width = (float)4.0;
            Pen pen = new Pen(Color.DarkRed, width);
            pen.DashStyle = DashStyle.DashDotDot;
            e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
        }
        private void buttonSaveAsJPG_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();

            f.Filter = "JPG(*.JPG)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(paneLabelCode.Width + 50, paneLabelCode.Height + paneLabelCode.Height / 2);
                paneLabelCode.DrawToBitmap(bmp, paneLabelCode.Bounds);
                bmp.Save(f.FileName);
            }
        }
        private void radioButtonLabelLinkON_CheckedChanged(object sender, EventArgs e)
        {
            linkLabelEquState.Visible = true;
            linkLabelAddNewCPU.Visible = true;
            linkLabelAddNewHardDrive.Visible = true;
            linkLabelAddNewLocation.Visible = true;
            linkLabelAddNewOffice.Visible = true;
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
            linkLabelAddNewOffice.Visible = false;
            linkLabelAddNewModel.Visible = false;
            linkLabelAddNewOperatingSystem.Visible = false;
            linkLabelAddNewRAM.Visible = false;
            linkLabelAddNewUser.Visible = false;
        }
        #endregion

        #region Label link add new _values
        private void linkLabelAddNewOffice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxMicrosoftOffice(comboBoxOfficeNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxLocation(comboBoxLocationNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewOperatingSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxOperatingSystem(comboBoxOperatigSystemNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxModelNotebook(comboBoxModelNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewCPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxCPU(comboBoxCPUNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewRAM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxRAM(comboBoxRAMNotebook.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewHardDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxHardDrive(comboBoxHardDriveNotebook.Text); // if != null
            UploadData();
        }
        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic?.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text); // if != null
            UploadData();
        }
        private void linkLabelEquState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _notebooksLogic.InsertComboEquipmentStatus(comboBoxEquState.Text);  // if != null
            UploadData();
        }

        #endregion

        
    }
}
