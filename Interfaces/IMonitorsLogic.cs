using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zuby.ADGV;

namespace Interfaces
{
    public interface IMonitorsLogic
    {
        void Insert(string _companyFixedAsset,string _tagService, string _location, string _firstName, 
            string _model, string _coments, DateTime _purchaseDate, DateTime _warrantyDate);

        void Update(int _id, string _companyFixedAsset, string _tagService, string _location, string _firstName,
            string _model, string _coments, DateTime _purchaseDate, DateTime _warrantyDate);

        void InsertComboBoxModelMonitor(string _value);
        void InsertComboBoxLocation(string _value);
        void DeleteMonitors(DataGridViewCellEventArgs e, AdvancedDataGridView advancedDataGridView);
        List<string> FillComboBoxLocation();
        List<string> FillComboBoxModelMonitors();
    }
}