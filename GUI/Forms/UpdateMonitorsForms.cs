using System;
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

        #region BUTTON
        private void buttonUpdateDataMonitor_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            pictureBoxBarcode.Image.Save(ms, ImageFormat.Png);
            var bitmapDataBarcode = ms.ToArray();

            pictureBoxQRCode.Image.Save(ms, ImageFormat.Png);
            var bitmapDataQRCode = ms.ToArray();

            _monitorsLogic.Update(Convert.ToInt32(textBoxIDMonitor.Text), textBoxCompanyFixedAssetMonitors.Text,textBoxTagServiceMonitors.Text,
                comboBoxLocationMonitors.Text, comboBoxUsers.Text, comboBoxModelMonitors.Text,richTextBoxComentsMonitors.Text, dateTimePickerWarrantyDateMonitors.Value.Date,
                dateTimePickerPurchaseDateMonitors.Value.Date, bitmapDataBarcode, bitmapDataQRCode, comboBoxEquState.Text);
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

            buttonUpdateDataMonitor.Enabled = false;
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

        #region LABEL LINK ADD NEW --VALUES
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

       
    }
}
