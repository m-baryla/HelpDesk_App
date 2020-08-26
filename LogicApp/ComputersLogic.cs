using System;
using System.Collections.Generic;
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

        #region Inset / Update / Delete / UpdateView

        public void Insert(string _computerName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _firstName, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime _purchaseDate, DateTime _warrantyDate)
        {
            _data.InsertComputer(_computerName, _operatingSystem, _companyFixedAsset, _tagService, _location,
                _firstName, _office, _ip, _model, _cpu, _ram, _hardDrive, _coments, _purchaseDate, _warrantyDate);
        }
        public void Update(int _id, string _computerName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _firstName, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime _purchaseDate, DateTime _warrantyDate)
        {

            _data.UpdateComputer(_id, _computerName, _operatingSystem, _companyFixedAsset, _tagService, _location,
                                _firstName,_office, _ip, _model, _cpu, _ram, _hardDrive, _coments, _purchaseDate, _warrantyDate);
        }
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
                        var id = Convert.ToInt32(dgViewRow.Cells[0].Value.ToString());
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
        #endregion

    }
}
