using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports.Forms
{
    public partial class CompleteReportNotebooks : Form
    {
        IDataAcces _data;
        public CompleteReportNotebooks(IDataAcces data)
        {
            this._data = data;
            InitializeComponent();
            comboBoxStatus.DataSource = _data.FillComboBoxEquipmentStatus().ToList();

        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportsDataSet.sp_Show_All_Notebooks_FromDate_ToDate' table. You can move, or remove it, as needed.
            this.sp_Show_All_Notebooks_FromDate_ToDateTableAdapter.Fill(this.reportsDataSet.sp_Show_All_Notebooks_FromDate_ToDate,dateTimePickerFromDate.Value,dateTimePickerToDate.Value, comboBoxStatus.Text);
            Microsoft.Reporting.WinForms.ReportParameter[] reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
               {
                    new Microsoft.Reporting.WinForms.ReportParameter("fromDate",dateTimePickerFromDate.Value.Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("toDate",dateTimePickerToDate.Value.Date.ToShortDateString())
               };

            this.reportViewerReportsNotebooks.LocalReport.SetParameters(reportParameters);
            this.reportViewerReportsNotebooks.RefreshReport();
        }

   
    }
}
