using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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

            linkLabelEquState.Visible = false;
            linkLabelEquState.Visible = false;
            linkLabelAddNewLocation.Visible = false;
            linkLabelAddNewModel.Visible = false;
            linkLabelAddNewUser.Visible = false;
        }

        private void UploadData()
        {
            comboBoxLocationMonitors.DataSource = _monitorsLogic.FillComboBoxLocation().ToList();
            comboBoxLocationMonitors.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxLocationMonitors.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxModelMonitors.DataSource = _monitorsLogic.FillComboBoxModelMonitors().ToList();
            comboBoxModelMonitors.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxModelMonitors.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxUsers.DataSource = _monitorsLogic.FillComboBoxUsers().ToList();
            comboBoxUsers.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxUsers.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxEquState.DataSource = _monitorsLogic.FillComboBoxEquipmentStatus().ToList();
            comboBoxEquState.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxEquState.AutoCompleteSource = AutoCompleteSource.ListItems;
            ///
        }

        #region Button
        private void buttonInsertDataMonitors_Click(object sender, EventArgs e)
        {
            var ms = new MemoryStream();

            pictureBoxBarcode.Image.Save(ms, ImageFormat.Png);
            var bitmapData = ms.ToArray();

            pictureBoxQRCode.Image.Save(ms, ImageFormat.Png);

            var bitmapDataQRCode = ms.ToArray();

            _monitorsLogic?.Insert(textBoxCompanyFixedAssetMonitors.Text, textBoxTagServiceMonitors.Text,
                comboBoxLocationMonitors.Text, comboBoxUsers.Text, comboBoxModelMonitors.Text, 
                richTextBoxComentsMonitors.Text, dateTimePickerWarrantyDateMonitors.Value.Date, dateTimePickerPurchaseDateMonitors.Value.Date, 
                 bitmapData, bitmapDataQRCode, comboBoxEquState.Text); // if != null
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
            labelCompanyFixedCode.Text = textBoxCompanyFixedAssetMonitors.Text;
            labelModelCode.Text = comboBoxModelMonitors.Text;
            labelTahServiceCode.Text = textBoxTagServiceMonitors.Text;

            Zen.Barcode.CodeQrBarcodeDraw qrBarcodeDraw = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBoxQRCode.Image = qrBarcodeDraw.Draw(textBoxCompanyFixedAssetMonitors.Text
                                                        + " " +
                                                        textBoxTagServiceMonitors.Text
                                                        + " " +
                                                        comboBoxModelMonitors.Text, pictureBoxQRCode.Width);

            Zen.Barcode.Code128BarcodeDraw barcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBoxBarcode.Image = barcodeDraw.Draw(textBoxCompanyFixedAssetMonitors.Text, pictureBoxBarcode.Height);

            buttonInsertDataMonitors.Enabled = true;
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
            linkLabelEquState.Visible = true;
            linkLabelAddNewLocation.Visible = true;
            linkLabelAddNewModel.Visible = true;
            linkLabelAddNewUser.Visible = true;
        }

        private void radioButtonLabelLinkOFF_CheckedChanged(object sender, EventArgs e)
        {
            linkLabelEquState.Visible = false;
            linkLabelEquState.Visible = false;
            linkLabelAddNewLocation.Visible = false;
            linkLabelAddNewModel.Visible = false;
            linkLabelAddNewUser.Visible = false;
        }
        #endregion

        #region Label link add new _values
        private void linkLabelAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic?.InsertComboBoxLocation(comboBoxLocationMonitors.Text); // if != null
            UploadData();
        }

        private void linkLabelAddNewModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic?.InsertComboBoxModelMonitor(comboBoxModelMonitors.Text); // if != null
            UploadData();
        }
        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic?.InsertComboBoxUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxJob.Text); // if != null
            UploadData();
        }
        private void linkLabelEquState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _monitorsLogic.InsertComboEquipmentStatus(comboBoxEquState.Text);  // if != null
            UploadData();
        }

        #endregion

        
    }
}
