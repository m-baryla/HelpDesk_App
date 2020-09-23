using DataBaseLayer.DeleteDataServiceReference;
using DataBaseLayer.GetDataServiceReference;
using DataBaseLayer.InsertDataServiceReference;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using DataBaseLayer.FillComboBoxDataServiceReference;
using DataBaseLayer.UpdateDataServiceReference;

namespace DataBaseLayer.DataBase
{
    public class DataAcces : IDataAcces
    {
        readonly GetDataServiceClient _getDataServiceClient = new GetDataServiceClient();
        readonly InsertDataServiceClient _insertDataServiceClient = new InsertDataServiceClient();
        readonly UpdateDataServiceClient _updateDataServiceClient = new UpdateDataServiceClient();
        readonly FillComboBoxDataServiceClient _fillComboBoxDataServiceClient = new FillComboBoxDataServiceClient();
        readonly DeleteDataServiceClient _deleteDataServiceClient = new DeleteDataServiceClient();

        private readonly IInfoMessageBox _infoMessageBox;

        public DataAcces(IInfoMessageBox infoMessageBox)
        {
            this._infoMessageBox = infoMessageBox;
        }


        #region GetData

        public void GetAllComputerses() => _getDataServiceClient?.GetAllComputerses(); // if != null

        public void GetAllNotebookses() => _getDataServiceClient?.GetAllNotebookses(); // if != null

        public void GetAllMonitors() => _getDataServiceClient?.GetAllMonitors(); // if != null

        #endregion

        #region InsertData

        public void InsertComputer(string _computerName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime warrantyDate, DateTime purchaseDate, 
            byte [] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComputer(_computerName, _operatingSystem, _companyFixedAsset,
                    _tagService, _location, _user, _office, _ip, _model,
                    _cpu, _ram, _hardDrive, _coments, warrantyDate,purchaseDate, _barcode,_qrCode, _equipmentStatus));
        }

        public void InsertNotebooks(string _notebooksName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime warrantyDate, DateTime purchaseDate, 
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertNotebooks(_notebooksName, _operatingSystem, _companyFixedAsset,
                           _tagService, _location, _user, _office, _ip, _model,
                           _cpu, _ram, _hardDrive, _coments, warrantyDate,purchaseDate, _barcode, _qrCode, _equipmentStatus));
        }
        public void InsertMonitors(string _companyFixedAsset, string _tagService, string _location,
            string _user, string _model, string _coments, DateTime warrantyDate, DateTime purchaseDate,  
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertMonitors(_companyFixedAsset, _tagService, _location,
                _user, _model, _coments, warrantyDate,purchaseDate, _barcode,_qrCode, _equipmentStatus));
        }
        public void InsertComboBoxCPU(string _value)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboBoxCPU(_value));
        }
        public void InsertComboBoxHardDrive(string _value)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboBoxHardDrive(_value));
        }
        public void InsertComboBoxLocation(string _value)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboBoxLocation(_value));
        }
        public void InsertComboBoxMicrosoftOffice(string _value)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboBoxMicrosoftOffice(_value));
        }
        public void InsertComboBoxModelComputer(string _value)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboBoxModelComputer(_value));
        }
        public void InsertComboBoxModelMonitor(string _value)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboBoxModelMonitor(_value));
        }
        public void InsertComboBoxModelNotebook(string _value)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboBoxModelNotebook(_value));
        }
        public void InsertComboBoxOperatingSystem(string _value)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboBoxOperatingSystem(_value));
        }
        public void InsertComboBoxRAM(string _value)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboBoxRAM(_value));
        }
        public void InsertComboBoxUser(string _firstName, string _lastName, string _job)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboBoxUser(_firstName, _lastName, _job));
        }
        public void InsertComboEquipmentStatus(string _value)
        {
            _infoMessageBox.Info(_insertDataServiceClient.InsertComboEquipmentStatus(_value));
        }

        #endregion

        #region UpdateData
        public void UpdateComputer(int _id, string _computerName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime warrantyDate, DateTime purchaseDate, 
            byte [] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            _infoMessageBox.Info(_updateDataServiceClient.UpdateComputer(_id, _computerName, _operatingSystem, _companyFixedAsset, _tagService, _location, _user,
                            _office, _ip, _model, _cpu, _ram, _hardDrive, _coments, warrantyDate,purchaseDate, _barcode,_qrCode, _equipmentStatus));
        }
        public void UpdateNotebooks(int _id, string _notebooksName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime warrantyDate, DateTime purchaseDate, 
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            _infoMessageBox.Info(_updateDataServiceClient.UpdateNotebooks(_id, _notebooksName, _operatingSystem, _companyFixedAsset, _tagService, _location, _user,
                            _office, _ip, _model, _cpu, _ram, _hardDrive, _coments, warrantyDate, purchaseDate, _barcode, _qrCode, _equipmentStatus));
        }
        public void UpdateMonitors(int _id, string _companyFixedAsset, string _tagService, string _location,
            string _user, string _model, string _coments, DateTime warrantyDate, DateTime purchaseDate, 
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            _infoMessageBox.Info(_updateDataServiceClient.UpdateMonitors(_id, _companyFixedAsset, _tagService, _location,
                _user, _model, _coments, warrantyDate, purchaseDate,_barcode,_qrCode, _equipmentStatus));
        }
        #endregion

        #region DeleteData
        public void DeleteComputer(int _id)
        {
            _infoMessageBox.Info(_deleteDataServiceClient.DeleteComputer(_id));
        }
        public void DeleteNotebook(int _id)
        {
            _infoMessageBox.Info(_deleteDataServiceClient.DeleteNotebook(_id));
        }
        public void DeleteMonitor(int _id)
        {
            _infoMessageBox.Info(_deleteDataServiceClient.DeleteMonitor(_id));
        }
        #endregion

        #region FillComboBox
        public List<string> FillComboBoxLocation()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxLocation().ToList(); // if != null
        }
        public List<string> FillComboBoxOffice()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxOffice().ToList(); // if != null
        }
        public List<string> FillComboBoxOperatingSystem()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxOperatingSystem().ToList(); // if != null
        }
        public List<string> FillComboBoxCPU()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxCPU().ToList(); // if != null
        }
        public List<string> FillComboBoxHardDrive()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxHardDrive().ToList(); // if != null
        }
        public List<string> FillComboBoxRAM()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxRAM().ToList(); // if != null
        }
        public List<string> FillComboBoxModelComputer()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxModelComputer().ToList(); // if != null
        }
        public List<string> FillComboBoxModelMonitors()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxModelMonitors().ToList(); // if != null
        }
        public List<string> FillComboBoxModelNotebooks()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxModelNotebooks().ToList(); // if != null
        }
        public List<string> FillComboBoxUsers()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxUsers().ToList(); // if != null
        }
        public List<string> FillComboBoxEquipmentStatus()
        {
            return _fillComboBoxDataServiceClient.FillComboBoxEquipmentStatus().ToList(); // if != null
        }
        #endregion
    }


}
