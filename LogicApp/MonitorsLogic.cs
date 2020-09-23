using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Interfaces;
using Zuby.ADGV;

namespace LogicApp
{
    public class MonitorsLogic : IMonitorsLogic
    {
        private readonly IDataAcces _data;
        private readonly IInfoMessageBox _infoMessageBox;


        public MonitorsLogic(IDataAcces data, IInfoMessageBox infoMessageBox)
        {
            this._data = data;
            this._infoMessageBox = infoMessageBox;
        }

        #region Inset

        public void Insert(string _companyFixedAsset,string _tagService, string _location, string _user, 
            string _model, string _coments, DateTime _warrantyDate, DateTime _purchaseDate, 
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            _data.InsertMonitors(_companyFixedAsset,_tagService,_location, _user, _model,_coments, 
                _warrantyDate,_purchaseDate, _barcode,_qrCode, _equipmentStatus);
        }
        #endregion

        #region Update
        public void Update(int _id, string _companyFixedAsset, string _tagService, string _location, string _user,
            string _model, string _coments, DateTime _warrantyDate, DateTime _purchaseDate, 
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            _data.UpdateMonitors(_id, _companyFixedAsset, _tagService, _location, _user, _model, _coments,
                _warrantyDate,_purchaseDate, _barcode, _qrCode, _equipmentStatus);
        }
        #endregion

        #region Delete
        public void DeleteMonitors(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView)
        {
            DialogResult dialogResult = _infoMessageBox.InfoYesNo("Do you want to delete");
            try
            {
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        {
                            DataGridViewRow dgViewRow = advancedDataGridView.Rows[e.RowIndex];
                            var id = Convert.ToInt32(dgViewRow.Cells[0].Value.ToString());
                            _data.DeleteMonitor(id);
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
        public void ExportExelMonitors(AdvancedDataGridView advancedDataGridView)
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
        public void ChangeStateColorMonitors(AdvancedDataGridView advancedDataGridView)
        {
            for (int i = 0; i < advancedDataGridView.Rows.Count - 1; i++)
            {
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
        public void InsertComboBoxModelMonitor(string _value)
        {
            _data.InsertComboBoxModelMonitor(_value);
        }
        public void InsertComboBoxLocation(string _value)
        {
            _data.InsertComboBoxLocation(_value);
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
        public List<string> FillComboBoxModelMonitors()
        {
            return _data.FillComboBoxModelMonitors();
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
