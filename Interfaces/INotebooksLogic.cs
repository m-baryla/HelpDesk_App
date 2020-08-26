﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zuby.ADGV;

namespace Interfaces
{
    public interface INotebooksLogic
    {
        void Insert(string _notebooksName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _firstName, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime _purchaseDate, DateTime _warrantyDate);

        void Update(int _id, string _notebooksName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _firstName, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime _purchaseDate, DateTime _warrantyDate);

        void DeleteNotebooks(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView);
        void InsertComboBoxModelNotebook(string _value);
        void InsertComboBoxRAM(string _value);
        void InsertComboBoxHardDrive(string _value);
        void InsertComboBoxOperatingSystem(string _value);
        void InsertComboBoxLocation(string _value);
        void InsertComboBoxMicrosoftOffice(string _value);
        void InsertComboBoxCPU(string _value);
        List<string> FillComboBoxLocation();
        List<string> FillComboBoxOffice();
        List<string> FillComboBoxOperatingSystem();
        List<string> FillComboBoxCPU();
        List<string> FillComboBoxHardDrive();
        List<string> FillComboBoxRAM();
        List<string> FillComboBoxModelNotebooks();
    }
}