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
        private void buttonUpdateDataNotebooks_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            pictureBoxBarcode.Image.Save(ms, ImageFormat.Png);
            var bitmapDataBarcode = ms.ToArray();

            pictureBoxQRCode.Image.Save(ms, ImageFormat.Png);
            var bitmapDataQRCode = ms.ToArray();

            _notebooksLogic.Update(Convert.ToInt32(textBoxIDNotebooks.Text), textBoxNameNotebook.Text,
                    comboBoxOperatigSystemNotebook.Text,textBoxCompanyFixedAssetNotebook.Text, textBoxTagServiceNotebook.Text,
                    comboBoxLocationNotebook.Text,comboBoxUsers.Text, comboBoxOfficeNotebook.Text,
                    textBoxIPNotebook.Text, comboBoxModelNotebook.Text,comboBoxCPUNotebook.Text, comboBoxRAMNotebook.Text,
                    comboBoxHardDriveNotebook.Text, richTextBoxComentsNotebook.Text,
                    dateTimePickerWarrantyDateNotebook.Value.Date, dateTimePickerPurchaseDateNotebook.Value.Date, 
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

            buttonUpdateDataNotebooks.Enabled = true;

        }

        private void pictureBoxQRCode_Paint(object sender, PaintEventArgs e)
        {
            PictureBox panel = (PictureBox)sender;
            float width = (float)4.0;
            Pen pen = new Pen(Color.DarkRed, width)
            {
                DashStyle = DashStyle.DashDotDot
            };
            e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
        }

        private void pictureBoxBarcode_Paint(object sender, PaintEventArgs e)
        {
            PictureBox panel = (PictureBox)sender;
            float width = (float)4.0;
            Pen pen = new Pen(Color.DarkRed, width)
            {
                DashStyle = DashStyle.DashDotDot
            };
            e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
        }
        private void buttonSaveAsJPG_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog
            {
                Filter = "JPG(*.JPG)|*.jpg"
            };

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
        #endregion

        #region LABEL LINK ADD NEW --VALUES

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

       
    }
}
