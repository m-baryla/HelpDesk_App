using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zuby.ADGV;

namespace Interfaces
{
    public interface IMonitorsLogic
    {
        void Insert(string _companyFixedAsset,string _tagService, string _location, string _user, 
            string _model, string _coments, DateTime _purchaseDate, DateTime _warrantyDate, byte[] _barcode, byte[] _qrCode);

        void Update(int _id, string _companyFixedAsset, string _tagService, string _location, string _user,
            string _model, string _coments, DateTime _purchaseDate, DateTime _warrantyDate, byte[] _barcode, byte[] _qrCode);

        void InsertComboBoxModelMonitor(string _value);
        void InsertComboBoxLocation(string _value);
        void InsertComboBoxUser(string _firstName, string _lastName, string _job);
        void DeleteMonitors(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView);
        void ExportExelMonitors(AdvancedDataGridView advancedDataGridView);

        List<string> FillComboBoxLocation();
        List<string> FillComboBoxModelMonitors();
        List<string> FillComboBoxUsers();

    }
}