﻿
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Interfaces;
using Zuby.ADGV;

namespace LogicApp
{
    public class ComputersLogic : IComputersLogic
    {

        private readonly IDataAcces _data;
        private readonly IInfoMessageBox _infoMessageBox;

        public ComputersLogic(IDataAcces data, IInfoMessageBox infoMessageBox)
        {
            this._data = data;
            this._infoMessageBox = infoMessageBox;
        }

        #region Inset 
        public void Insert(string _computerName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime _warrantyDate, DateTime _purchaseDate, 
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            _data.InsertComputer(_computerName, _operatingSystem, _companyFixedAsset, _tagService, _location,
                _user, _office, _ip, _model, _cpu, _ram, _hardDrive, _coments, _warrantyDate,_purchaseDate, _barcode, _qrCode, _equipmentStatus);
        }
        #endregion

        #region Update
        public void Update(int _id, string _computerName, string _operatingSystem, string _companyFixedAsset,
           string _tagService, string _location, string _user, string _office, string _ip, string _model,
           string _cpu, string _ram, string _hardDrive, string _coments, DateTime _warrantyDate, DateTime _purchaseDate, 
           byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {

            _data.UpdateComputer(_id, _computerName, _operatingSystem, _companyFixedAsset, _tagService, _location,
                _user, _office, _ip, _model, _cpu, _ram, _hardDrive, _coments, _warrantyDate, _purchaseDate, _barcode, _qrCode, _equipmentStatus);
        }
        #endregion

        #region Delete
        public void DeleteComputer(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView)
        {
            DialogResult dialogResult = _infoMessageBox.InfoYesNo("Do you want to delete");
            try
            {
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        {
                            DataGridViewRow dgViewRow = advancedDataGridView.Rows[e.RowIndex];
                            // Celss[2] = id item
                            var id = Convert.ToInt32(dgViewRow.Cells[2].Value.ToString());
                            _data.DeleteComputer(id);
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
                _infoMessageBox.Error(exception.Message);
            }
        }

        #endregion

        #region ExportToExel
        public void ExportExelComputers(AdvancedDataGridView advancedDataGridView)
        {
            Microsoft.Office.Interop.Excel.Application exelApps = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook exelWorkbook = exelApps.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet exelWorkshet = null;
            exelApps.Visible = true;

            //exelWorkshet = exelWorkbook.Sheets["Arkusz1"];
            exelWorkshet = exelWorkbook.ActiveSheet;
            exelWorkshet.Name = "ExportDataGrindViewToExel";

            for (int i = 1; i < advancedDataGridView.Columns.Count + 1; i++)
            {
                exelWorkshet.Cells[1, i] = advancedDataGridView.Columns[i - 1].HeaderText;
            }

            for (int j = 0; j < advancedDataGridView.RowCount - 1; j++)
            {
                for (int k = 0; k < advancedDataGridView.ColumnCount; k++)
                {
                    exelWorkshet.Cells[j + 2, k + 1] = advancedDataGridView.Rows[j].Cells[k].Value.ToString();
                }
            }
        }
        #endregion

        #region ChangeColorState
        public void ChangeStateColorComputers(AdvancedDataGridView advancedDataGridView)
        {
            for (int i = 0; i < advancedDataGridView.Rows.Count - 1; i++)
            {
                // Celss[0] = id eq state
                int value = Int32.Parse(advancedDataGridView.Rows[i].Cells[0].Value.ToString());

                if (value == 1)
                {
                    advancedDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (value == 2)
                {
                    advancedDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else if (value == 3)
                {
                    advancedDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
        #endregion

        #region InsertComboBox
        public void InsertComboBoxModelComputer(string _value)
        {
            _data.InsertComboBoxModelComputer(_value);
        }
        public void InsertComboBoxRAM(string _value)
        {
            _data.InsertComboBoxRAM(_value);
        }
        public void InsertComboBoxHardDrive(string _value)
        {
            _data.InsertComboBoxHardDrive(_value);
        }
        public void InsertComboBoxOperatingSystem(string _value)
        {
            _data.InsertComboBoxOperatingSystem(_value);
        }
        public void InsertComboBoxLocation(string _value)
        {
            _data.InsertComboBoxLocation(_value);
        }
        public void InsertComboBoxMicrosoftOffice(string _value)
        {
            _data.InsertComboBoxMicrosoftOffice(_value);
        }
        public void InsertComboBoxCPU(string _value)
        {
            _data.InsertComboBoxCPU(_value);
        }
        public void InsertComboBoxUser(string _firstName, string _lastName, string _job)
        {
            _data.InsertComboBoxUser(_firstName, _lastName, _job);
        }
        public void InsertComboEquipmentStatus(string _value)
        {
            _data.InsertComboEquipmentStatus(_value);
        }

        #endregion

        #region GetFillComboBox

        public List<string> FillComboBoxLocation()
        {
            return _data.FillComboBoxLocation();
        }

        public List<string> FillComboBoxOffice()
        {
            return _data.FillComboBoxOffice();
        }

        public List<string> FillComboBoxOperatingSystem()
        {
            return _data.FillComboBoxOperatingSystem();
        }

        public List<string> FillComboBoxCPU()
        {
            return _data.FillComboBoxCPU();
        }

        public List<string> FillComboBoxHardDrive()
        {
            return _data.FillComboBoxHardDrive();
        }

        public List<string> FillComboBoxRAM()
        {
            return _data.FillComboBoxRAM();
        }

        public List<string> FillComboBoxModelComputer()
        {
            return _data.FillComboBoxModelComputer();
        }

        public List<string> FillComboBoxUsers()
        {
            return _data.FillComboBoxUsers();
        }
        public List<string> FillComboBoxEquipmentStatus()
        {
            return _data.FillComboBoxEquipmentStatus();
        }
        #endregion

    }
}
