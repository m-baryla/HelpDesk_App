using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IDataAcces
    {
        void GetAllComputerses();
        void GetAllNotebookses();
        void GetAllMonitors();

        void InsertComputer(string _computerName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive,string _coments, DateTime warrantyDate, DateTime purchaseDate,  
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus);

        void InsertNotebooks(string _notebooksName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime warrantyDate, DateTime purchaseDate, 
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus);

        void InsertMonitors(string _companyFixedAsset, string _tagService, string _location,
            string _user, string _model,string _coments, DateTime warrantyDate, DateTime purchaseDate,
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus);

        void InsertComboBoxCPU(string _value);
        void InsertComboBoxHardDrive(string _value);
        void InsertComboBoxLocation(string _value);
        void InsertComboBoxMicrosoftOffice(string _value);
        void InsertComboBoxModelComputer(string _value);
        void InsertComboBoxModelMonitor(string _value);
        void InsertComboBoxModelNotebook(string _value);
        void InsertComboBoxOperatingSystem(string _value);
        void InsertComboBoxRAM(string _value);
        void InsertComboBoxUser(string _firstName, string _lastName, string _job);
        void InsertComboEquipmentStatus(string _value);

        void UpdateComputer(int _id, string _computerName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime warrantyDate, DateTime purchaseDate,  
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus);

        void UpdateNotebooks(int _id, string _notebooksName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime warrantyDate, DateTime purchaseDate, 
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus);

        void UpdateMonitors(int _id, string _companyFixedAsset, string _tagService, string _location,
            string _user, string _model, string _coments, DateTime warrantyDate, DateTime purchaseDate, 
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus);

        void DeleteComputer(int _id);
        void DeleteNotebook(int _id);
        void DeleteMonitor(int _id);
        List<string> FillComboBoxLocation();
        List<string> FillComboBoxOffice();
        List<string> FillComboBoxOperatingSystem();
        List<string> FillComboBoxCPU();
        List<string> FillComboBoxHardDrive();
        List<string> FillComboBoxRAM();
        List<string> FillComboBoxModelComputer();
        List<string> FillComboBoxModelMonitors();
        List<string> FillComboBoxModelNotebooks();
        List<string> FillComboBoxUsers();
        List<string> FillComboBoxEquipmentStatus();


    }
}