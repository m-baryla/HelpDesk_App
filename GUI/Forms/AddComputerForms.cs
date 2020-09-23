using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
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

            ///
        }

        #region Button

        private void buttonInsertDataComputer_Click(object sender, EventArgs e)
        {
            var strIP = ip_1.Text + '.' + ip_2.Text + '.' + ip_3.Text + '.' + ip_4.Text;


            var ms = new MemoryStream();

            pictureBoxBarcode.Image.Save(ms, ImageFormat.Png);
            var bitmapData = ms.ToArray();

            pictureBoxQRCode.Image.Save(ms, ImageFormat.Png);
            var bitmapDataQRCode = ms.ToArray();

            _computersLogic?.Insert(textBoxNameComputer.Text, comboBoxOperatigSystemComputer.Text,
                textBoxCompanyFixedAssetComputer.Text, textBoxTagServiceComputer.Text,
                comboBoxLocationComputer.Text, comboBoxUser.Text,
                comboBoxOfficeComputer.Text, strIP, comboBoxModelComputer.Text,
                comboBoxCPUComputer.Text, comboBoxRAMComputer.Text, comboBoxHardDriveComputer.Text,
                richTextBoxComentsComputer.Text, dateTimePickerWarrantyDateComputer.Value.Date, dateTimePickerPurchaseDateComputer.Value.Date,
                bitmapData, bitmapDataQRCode,comboBoxEquState.Text); // if != null
        }
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

        private void buttonCreateQR_Click(object sender, EventArgs e)
        {
            labelDateTimeCode.Text = DateTime.Now.ToString();
            labelCompanyFixedCode.Text = textBoxCompanyFixedAssetComputer.Text;
            labelModelCode.Text = comboBoxModelComputer.Text;
            labelTahServiceCode.Text = textBoxTagServiceComputer.Text;

            Zen.Barcode.CodeQrBarcodeDraw qrBarcodeDraw = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBoxQRCode.Image = qrBarcodeDraw.Draw(textBoxCompanyFixedAssetComputer.Text
                                                        +" "+
                                                        textBoxTagServiceComputer.Text
                                                        + " " +
                                                        comboBoxModelComputer.Text, pictureBoxQRCode.Width);

            Zen.Barcode.Code128BarcodeDraw barcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBoxBarcode.Image = barcodeDraw.Draw(textBoxCompanyFixedAssetComputer.Text, pictureBoxBarcode.Height);

            buttonInsertDataComputer.Enabled = true;
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

        private void linkLabelEquState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _computersLogic.InsertComboEquipmentStatus(comboBoxEquState.Text);  // if != null
            UploadData();
        }
        #endregion
      
    }
}
