﻿using System;
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
        }

        private void UploadData()
        {
            comboBoxLocationNotebook.DataSource = _notebooksLogic.FillComboBoxLocation().ToList();
            comboBoxModelNotebook.DataSource = _notebooksLogic.FillComboBoxModelNotebooks().ToList();
            comboBoxCPUNotebook.DataSource = _notebooksLogic.FillComboBoxCPU().ToList();
            comboBoxRAMNotebook.DataSource = _notebooksLogic.FillComboBoxRAM().ToList();
            comboBoxHardDriveNotebook.DataSource = _notebooksLogic.FillComboBoxHardDrive().ToList();
            comboBoxOfficeNotebook.DataSource = _notebooksLogic.FillComboBoxOffice().ToList();
            comboBoxOperatigSystemNotebook.DataSource = _notebooksLogic.FillComboBoxOperatingSystem().ToList();
        }

        #region COMBOBOX DATA
        public void EditDataLoad(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView)
        {
            
            var barcode = "edit barcode";

            var dialogResult = MessageBox.Show("Do you want to edit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                    {
                        DataGridViewRow dgViewRow = advancedDataGridView.Rows[e.RowIndex];

                        // [UpdateNotebooksDataViev] must be like the view as [vwAll_Notebooks]
                        textBoxIDNotebooks.Text = dgViewRow.Cells[0].Value.ToString();
                        textBoxNameNotebook.Text = dgViewRow.Cells[1].Value.ToString();
                        textBoxTagServiceNotebook.Text = dgViewRow.Cells[2].Value.ToString();
                        textBoxIPNotebook.Text = dgViewRow.Cells[3].Value.ToString();
                        dateTimePickerPurchaseDateNotebook.Value = Convert.ToDateTime(dgViewRow.Cells[4].Value);
                        dateTimePickerWarrantyDateNotebook.Value = Convert.ToDateTime(dgViewRow.Cells[5].Value);
                        barcode = dgViewRow.Cells[6].Value.ToString();
                        richTextBoxComentsNotebook.Text = dgViewRow.Cells[7].Value.ToString();
                        textBoxCompanyFixedAssetNotebook.Text = dgViewRow.Cells[8].Value.ToString();
                        textBoxFirstNameUserNotebook.Text = dgViewRow.Cells[9].Value.ToString();
                        comboBoxCPUNotebook.Text = dgViewRow.Cells[10].Value.ToString();
                        comboBoxHardDriveNotebook.Text = dgViewRow.Cells[11].Value.ToString();
                        comboBoxLocationNotebook.Text = dgViewRow.Cells[12].Value.ToString();
                        comboBoxOfficeNotebook.Text = dgViewRow.Cells[13].Value.ToString();
                        comboBoxModelNotebook.Text = dgViewRow.Cells[14].Value.ToString();
                        comboBoxOperatigSystemNotebook.Text = dgViewRow.Cells[15].Value.ToString();
                        comboBoxRAMNotebook.Text = dgViewRow.Cells[16].Value.ToString();
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
            _notebooksLogic.Update(Convert.ToInt32(textBoxIDNotebooks.Text), textBoxNameNotebook.Text,
                    comboBoxOperatigSystemNotebook.Text,textBoxCompanyFixedAssetNotebook.Text, textBoxTagServiceNotebook.Text,
                    comboBoxLocationNotebook.Text,textBoxFirstNameUserNotebook.Text, comboBoxOfficeNotebook.Text,
                    textBoxIPNotebook.Text, comboBoxModelNotebook.Text,comboBoxCPUNotebook.Text, comboBoxRAMNotebook.Text,
                    comboBoxHardDriveNotebook.Text, richTextBoxComentsNotebook.Text,
                    dateTimePickerPurchaseDateNotebook.Value, dateTimePickerWarrantyDateNotebook.Value);
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
            ///
        }
        #endregion
    }
}
